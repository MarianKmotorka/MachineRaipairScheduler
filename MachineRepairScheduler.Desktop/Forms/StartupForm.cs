using MachineRepairScheduler.Desktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class StartupForm : Form
    {
        private SelectedUserForm _selectedUserForm;
        private TabPage _registerTabPage => tabControl1.TabPages["registerTabPage"];
        private TabPage _registeredUsersTabPage => tabControl1.TabPages["registeredUsersTabPage"];
        public int _currentPageNumber = 1;
        private int _pagesCount;
        private bool _filterActive = false;
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
            }
        }
        public void LoadUsersTable(List<User> data)
        {
            registeredUsersTable.DataSource = data;
            registeredUsersTable.Columns[0].Visible = false;
            for (int i = 1; i < registeredUsersTable.ColumnCount; i++)
            {
                registeredUsersTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            registeredUsersTable.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            registeredUsersTable.RowTemplate.Height = 35;
        }
        public async void LoadAllUsers()
        {
            var data = await ApiHelper.Instance.GetUsersAsync(_currentPageNumber);
            _pagesCount = data.Pages;
            LoadUsersTable(data.Data.ToList());
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
            if (_currentPageNumber > 1)
            {
                if (_filterActive)
                {

                }
                else
                {
                    _currentPageNumber--;
                    LoadAllUsers();
                    return;
                }
            }
            return;
        }

        private void nextPageUsersPictureBox_Click(object sender, EventArgs e)
        {
            if (_currentPageNumber < _pagesCount)
            {
                if (_filterActive)
                {

                }
                else
                {
                    _currentPageNumber++;
                    LoadAllUsers();
                    return;
                }
            }
            return;
        }

        private async void findUser_Click(object sender, EventArgs e)
        {
            if (searchUserTextBox.Text != "")
            {
                _filterActive = true;
                _currentPageNumber = 1;
                var rolesFiltered = await ApiHelper.Instance.GetUsersAsync(_currentPageNumber, roleFilter: searchUserTextBox.Text);
                var emailsFiltered = await ApiHelper.Instance.GetUsersAsync(_currentPageNumber, emailFilter: searchUserTextBox.Text);
                var result = rolesFiltered.Data.Union(emailsFiltered.Data, new UserComparer());
                _pagesCount = (result.Count() / 11) + 1;
                LoadUsersTable(result.ToList());
            }
            else
            {
                LoadAllUsers();
                _filterActive = false;
            }
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            _currentPageNumber = 1;
            LoadAllUsers();
        }
    }
}
