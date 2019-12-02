using MachineRepairScheduler.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class StartupForm : Form
    {
        private SelectedUserForm _selectedUserForm;
        private TabPage _registerTabPage => tabControl1.TabPages["registerTabPage"];
        private TabPage _registeredUsersTabPage => tabControl1.TabPages["registeredUsersTabPage"];
        private TabPage _changePasswordTabPage => tabControl1.TabPages["changePasswordTabPage"];
        private TabPage _machinesTabPage => tabControl1.TabPages["machinesTabPage"];
        private TabPage _addMachineTabPage => tabControl1.TabPages["addMachineTabPage"];
        public int _currentPageNumber = 1;
        private int _pagesCount;
        public StartupForm()
        {
            InitializeComponent();
            showRegisterPassword.CheckedChanged += new EventHandler(showRegisterPassword_CheckedChanged);
            InitializeHandlers();
            userRoleRegisterComboBox.DataSource = new[] { Role.Employee.ToString(), Role.PlanningManager.ToString().Replace("M", " m"), Role.Technician.ToString() };
        }
        public void FilterOutUnathorizedTabs()
        {
            if (CurrentUser.User.Role != Role.SysAdmin)
            {
                tabControl1.TabPages.Remove(_registerTabPage);
                tabControl1.TabPages.Remove(_registeredUsersTabPage);
                tabControl1.TabPages.Remove(_addMachineTabPage);
                tabControl1.TabPages.Remove(_machinesTabPage);
            }
            else
            {
                tabControl1.TabPages.Remove(_changePasswordTabPage);
            }
        }
        public void LoadUsersTable(IEnumerable<User> data)
        {
            registeredUsersTable.DataSource = data;
            registeredUsersTable.Columns[0].Visible = false;
            for (int i = 1; i < registeredUsersTable.ColumnCount; i++)
            {
                registeredUsersTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            registeredUsersTable.RowTemplate.Height = 35;
        }
        public async void LoadAllUsers()
        {
            GetUsersResponse response = null;

            if (filterRoleRB.Checked)
                response = await ApiHelper.Instance.GetUsersAsync(_currentPageNumber, pageSize: (int)pageSizeUsersNumericUpDown.Value, roleFilter: searchUserTextBox.Text);
            else if (filterEmailRB.Checked)
                response = await ApiHelper.Instance.GetUsersAsync(_currentPageNumber, pageSize: (int)pageSizeUsersNumericUpDown.Value, emailFilter: searchUserTextBox.Text);

            _pagesCount = response.Pages;
            _currentPageNumber = response.PageNumber;
            totalPagesUsersLabel.Text = response.Pages.ToString();
            pageNumberUsersLabel.Text = response.PageNumber.ToString();
            LoadUsersTable(response.Data);
        }
        private void InitializeHandlers()
        {
            signUp.Click += new System.EventHandler(signUp_Click);
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            Hide();
            ShowInTaskbar = false;
            new LoginForm(this).Show();

        }

        private void showRegisterPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showRegisterPassword.Checked)
            {
                passwordRegisterTextBox.PasswordChar = '\0';
                confirmPasswordRegisterTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordRegisterTextBox.PasswordChar = '*';
                confirmPasswordRegisterTextBox.PasswordChar = '*';
            }
        }

        private async void signUp_Click(object sender, EventArgs e)
        {
            errorRegisterLabel.Text = String.Empty;
            Role role;
            Enum.TryParse<Role>(userRoleRegisterComboBox.SelectedValue.ToString().Replace(" m", "M"), out role);
            if (emailRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Login is empty";
                return;
            }
            else if (nameRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Name is empty";
                return;
            }
            else if (passwordRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Password is empty";
                return;
            }
            else if (surnameRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Surname is empty";
                return;
            }
            else if (confirmPasswordRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Confirm password is empty";
                return;
            }
            else if (passwordRegisterTextBox.Text != confirmPasswordRegisterTextBox.Text)
            {
                errorRegisterLabel.Text += "Password and confirm password does not match";
                return;
            }
            else if (birthCertificateNumberRegisterTextBox.Text == "")
            {
                errorRegisterLabel.Text += "Birth certificate number is empty";
                return;
            }
            var response = await ApiHelper.Instance.Register(emailRegisterTextBox.Text, passwordRegisterTextBox.Text, nameRegisterTextBox.Text, surnameRegisterTextBox.Text, phoneRegisterTextBox.Text, birthCertificateNumberRegisterTextBox.Text, role);

            if (response.Success)
            {
                errorRegisterLabel.Text = String.Empty;
                errorRegisterLabel.Text += "Registered succesfully";
                _currentPageNumber = 1;
                LoadAllUsers();
                emailRegisterTextBox.Text = "";
                passwordRegisterTextBox.Text = "";
                confirmPasswordRegisterTextBox.Text = "";
                nameRegisterTextBox.Text = "";
                surnameRegisterTextBox.Text = "";
                phoneRegisterTextBox.Text = "";
                birthCertificateNumberRegisterTextBox.Text = "";
                userRoleRegisterComboBox.SelectedIndex = userRoleRegisterComboBox.FindString("Employee");
                return;
            }

            foreach (var error in response.Errors)
            {
                errorRegisterLabel.Text += error + Environment.NewLine;
            }
        }

        private void registeredUsersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string dataValue = registeredUsersTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedUserForm = new SelectedUserForm(dataValue, this);
                this.Enabled = false;
                _selectedUserForm.Show();
            }
        }

        private void previousPageUsersPictureBox_Click(object sender, EventArgs e)
        {
            if (_currentPageNumber <= 1) return;

            _currentPageNumber--;
            LoadAllUsers();
        }

        private void nextPageUsersPictureBox_Click(object sender, EventArgs e)
        {
            if (_currentPageNumber >= _pagesCount) return;

            _currentPageNumber++;
            LoadAllUsers();
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            _currentPageNumber = 1;
            LoadAllUsers();
        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentPageNumber = 1;
            LoadAllUsers();
        }

        private void filterRB_changed(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void pageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _currentPageNumber = 1;
            LoadAllUsers();
        }

        private async void changePassword_Click(object sender, EventArgs e)
        {
            errorChangePasswordLabel.Text = String.Empty;

            if (changePasswordOldPasswordTextBox.Text == "")
            {
                errorChangePasswordLabel.Text += "Old password is empty";
                return;
            }
            else if (changePasswordNewPasswordTextBox.Text == "")
            {
                errorChangePasswordLabel.Text += "New password is empty";
                return;
            }
            else if (changePasswordConfirmPasswordTextBox.Text == "")
            {
                errorChangePasswordLabel.Text += "Confirm password is empty";
                return;
            }
            else if (changePasswordNewPasswordTextBox.Text != changePasswordConfirmPasswordTextBox.Text)
            {
                errorChangePasswordLabel.Text += "New password and confirm password does not match";
                return;
            }

            var response = await ApiHelper.Instance.ChangePasswordAsync(changePasswordOldPasswordTextBox.Text, changePasswordNewPasswordTextBox.Text);

            if (response.Success)
            {
                errorChangePasswordLabel.Text = String.Empty;
                errorChangePasswordLabel.Text += "Password changed succesfully";
                changePasswordOldPasswordTextBox.Text = "";
                changePasswordNewPasswordTextBox.Text = "";
                changePasswordConfirmPasswordTextBox.Text = "";
                return;
            }

            foreach (var error in response.Errors)
            {
                errorChangePasswordLabel.Text += error + Environment.NewLine;
            }
        }

        private void showChangePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showChangePassword.Checked)
            {
                changePasswordOldPasswordTextBox.PasswordChar = '\0';
                changePasswordNewPasswordTextBox.PasswordChar = '\0';
                changePasswordConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                changePasswordOldPasswordTextBox.PasswordChar = '*';
                changePasswordNewPasswordTextBox.PasswordChar = '*';
                changePasswordConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private void registeredUsersTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private async void addMachine_Click(object sender, EventArgs e)
        {
            errorAddMachineLabel.Text = String.Empty;

            if (serialNumberAddMachineTextBox.Text == "")
            {
                errorAddMachineLabel.Text += "Serial number is empty";
                return;
            }
            else if (machineNameAddMachineTextBox.Text == "")
            {
                errorAddMachineLabel.Text += "Machine name is empty";
                return;
            }
            else if (manufacturerNameAddMachineTextBox.Text == "")
            {
                errorAddMachineLabel.Text += "Manufacturer name is empty";
                return;
            }
            else if (yearOfManufactureAddMachineTextBox.Text == "")
            {
                errorAddMachineLabel.Text += "Year of manufacture is empty";
                return;
            }

            var response = await ApiHelper.Instance.AddMachineAsync(serialNumberAddMachineTextBox.Text, machineNameAddMachineTextBox.Text, manufacturerNameAddMachineTextBox.Text, yearOfManufactureAddMachineTextBox.Text);

            if (response.Success)
            {
                errorAddMachineLabel.Text = String.Empty;
                errorRegisterLabel.Text += "Machine added succesfully";
                //current page
                serialNumberAddMachineTextBox.Text = "";
                machineNameAddMachineTextBox.Text = "";
                manufacturerNameAddMachineTextBox.Text = "";
                yearOfManufactureAddMachineTextBox.Text = "";
                return;
            }

            foreach (var error in response.Errors)
            {
                errorAddMachineLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
