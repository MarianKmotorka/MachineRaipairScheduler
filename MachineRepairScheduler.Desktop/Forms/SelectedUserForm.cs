using MachineRepairScheduler.Desktop.Models;
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
            userRoleEditUserComboBox.DataSource = new[] { Role.Employee.ToString(), Role.PlanningManager.ToString().Replace("M", " m"), Role.Technician.ToString() };
            LoadSelectedUserTable(_userId);
        }
        private async void LoadSelectedUserTable(string userId)
        {
            var userData = await ApiHelper.Instance.GetSelectedUserAsync(userId);
            List<GetSelectedUserResponse> data = new List<GetSelectedUserResponse>();
            data.Add(userData);
            selectedUserTable.DataSource = data;
            LoadEditUserForm(data);
            selectedUserTable.Columns[0].Visible = false;
            for (int i = 1; i < selectedUserTable.ColumnCount; i++)
            {
                selectedUserTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }
        private void LoadEditUserForm(List<GetSelectedUserResponse> data)
        {
            emailEditUserTextBox.Text = data[0].emailAddress;
            nameEditUserTextBox.Text = data[0].firstName;
            surnameEditUserTextBox.Text = data[0].lastName;
            birthCertificateNumberEditUserTextBox.Text = data[0].birthCertificateNumber;
            userRoleEditUserComboBox.SelectedIndex = userRoleEditUserComboBox.FindString(data[0].role.ToString().Replace("M", " m"));
            phoneEditUserTextBox.Text = data[0].phoneNumber;
        }
        private void SelectedUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm.Enabled = true;
            _startupForm.ShowInTaskbar = true;
        }

        private void editUser_Click(object sender, System.EventArgs e)
        {

        }

        private void deleteSelectedUserPictureBox_Click_1(object sender, System.EventArgs e)
        {
            _confirmDeleteUserForm = new ConfirmDeleteUserForm(this, _userId);
            this.Enabled = false;
            _confirmDeleteUserForm.Show();
        }
    }
}
