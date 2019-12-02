using MachineRepairScheduler.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class SelectedUserForm : Form
    {
        private StartupForm _startupForm;
        private ConfirmDeleteUserForm _confirmDeleteUserForm;
        private string _userId;
        public SelectedUserForm(string userID, StartupForm startupForm)
        {
            InitializeComponent();
            _startupForm = startupForm;
            _startupForm.ShowInTaskbar = false;
            _userId = userID;
            userRoleEditUserComboBox.DataSource = new[] { Role.Employee.ToString(), Role.PlanningManager.ToString().Replace("PlanningManager", "Planning manager"), Role.Technician.ToString(), Role.SysAdmin.ToString().Replace("SysAdmin", "System administrator") };
            LoadSelectedUserTable(_userId);
        }
        private async void LoadSelectedUserTable(string userId)
        {
            var userData = await ApiHelper.Instance.GetSelectedUserAsync(userId);
            List<GetSelectedUserResponse> data = new List<GetSelectedUserResponse>();
            data.Add(userData);
            if (data[0].role.ToString() == "SysAdmin")
            {
                deleteSelectedUserPictureBox.Enabled = false;
                userRoleEditUserComboBox.Enabled = false;
            }
            else
            {
                userRoleEditUserComboBox.DataSource = new[] { Role.Employee.ToString(), Role.PlanningManager.ToString().Replace("PlanningManager", "Planning manager"), Role.Technician.ToString() };
            }
            selectedUserTable.DataSource = data;
            LoadEditUserForm(data);
            selectedUserTable.Columns[0].Visible = false;
            for (int i = 1; i < selectedUserTable.ColumnCount; i++)
            {
                selectedUserTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            selectedUserTable.RowTemplate.Height = 65;
        }

        private void LoadEditUserForm(List<GetSelectedUserResponse> data)
        {
            emailEditUserTextBox.Text = data[0].emailAddress;
            nameEditUserTextBox.Text = data[0].firstName;
            surnameEditUserTextBox.Text = data[0].lastName;
            birthCertificateNumberEditUserTextBox.Text = data[0].birthCertificateNumber;
            userRoleEditUserComboBox.SelectedIndex = userRoleEditUserComboBox.FindString(data[0].role.ToString().Replace("PlanningManager", "Planning manager").Replace("SysAdmin", "System administrator"));
            phoneEditUserTextBox.Text = data[0].phoneNumber;
        }
        private void SelectedUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm.LoadAllUsers();
            _startupForm.Enabled = true;
            _startupForm.ShowInTaskbar = true;
        }

        private async void editUser_Click(object sender, System.EventArgs e)
        {
            errorEditUserLabel.Text = String.Empty;
            Role role;
            Enum.TryParse<Role>(userRoleEditUserComboBox.SelectedValue.ToString().Replace("Planning manager", "PlanningManager").Replace("System administrator", "SysAdmin"), out role);


            if (passwordEditUserTextBox.Text != confirmPasswordEditUserTextBox.Text)
            {
                errorEditUserLabel.Text += "Password and confirm password does not match";
                return;
            }

            var response = await ApiHelper.Instance.EditSelectedUserAsync(_userId, emailEditUserTextBox.Text, passwordEditUserTextBox.Text, nameEditUserTextBox.Text, surnameEditUserTextBox.Text, phoneEditUserTextBox.Text, birthCertificateNumberEditUserTextBox.Text, role);

            if (response.Success)
            {
                errorEditUserLabel.Text = String.Empty;
                errorEditUserLabel.Text += "Edited succesfully";
                LoadSelectedUserTable(_userId);
                passwordEditUserTextBox.Text = "";
                confirmPasswordEditUserTextBox.Text = "";
                return;
            }

            foreach (var error in response.Errors)
            {
                errorEditUserLabel.Text += error + Environment.NewLine;
            }
        }

        private void deleteSelectedUserPictureBox_Click_1(object sender, System.EventArgs e)
        {
            _confirmDeleteUserForm = new ConfirmDeleteUserForm(this, _userId);
            this.Enabled = false;
            _confirmDeleteUserForm.Show();
        }

        private void showEditUserPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showEditUserPassword.Checked)
            {
                passwordEditUserTextBox.PasswordChar = '\0';
                confirmPasswordEditUserTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordEditUserTextBox.PasswordChar = '*';
                confirmPasswordEditUserTextBox.PasswordChar = '*';
            }
        }
    }
}
