using MachineRepairScheduler.Desktop.Models;
using MachineRepairScheduler.Desktop.Responses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class MainForm : Form
    {
        private BackgroundForm _backgroundForm;
        private LoginForm _loginForm;
        private SelectedUserForm _selectedUserForm;
        private SelectedMachineForm _selectedMachineForm;
        private SelectedReportForm _selectedReportForm;
        private TabPage _registerTabPage => tabControl1.TabPages["registerTabPage"];
        private TabPage _registeredUsersTabPage => tabControl1.TabPages["registeredUsersTabPage"];
        private TabPage _changePasswordTabPage => tabControl1.TabPages["changePasswordTabPage"];
        private TabPage _machinesTabPage => tabControl1.TabPages["machinesTabPage"];
        private TabPage _addMachineTabPage => tabControl1.TabPages["addMachineTabPage"];
        private TabPage _reportMalfunctionTabPage => tabControl1.TabPages["reportMalfunctionTabPage"];
        private TabPage _reportedMalfunctionsTabPage => tabControl1.TabPages["reportedMalfunctionsTabPage"];
        private TabPage _plannedFixesTabPage => tabControl1.TabPages["plannedFixesTabPage"];
        private List<Report> MalfunctionsTableData = null;
        private ToolTip UserInfoToolTip = new ToolTip();
        private ToolTip MachineInfoToolTip = new ToolTip();
        public int _usersCurrentPageNumber = 1;
        private int _usersPagesCount;
        public int _machinesCurrentPageNumber = 1;
        private int _machinesPagesCount;
        public int _reportsCurrentPageNumber = 1;
        private int _reportsPagesCount;
        public int _reportsTechCurrentPageNumber = 1;
        private int _reportsTechPagesCount;
        private bool logout = false;
        public MainForm(BackgroundForm backgroundForm)
        {
            _backgroundForm = backgroundForm;
            InitializeComponent();
            showRegisterPassword.CheckedChanged += new EventHandler(showRegisterPassword_CheckedChanged);
            InitializeHandlers();
            userRoleRegisterComboBox.DataSource = new[] { Role.Employee.ToString(), Role.PlanningManager.ToString().Replace("M", " m"), Role.Technician.ToString() };
            reportPriorityComboBox.DataSource = new[] { Priority.Low.ToString(), Priority.Medium.ToString(), Priority.High.ToString() };
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
            if (CurrentUser.User.Role == Role.SysAdmin)
            {
                tabControl1.TabPages.Remove(_changePasswordTabPage);
            }
            if (CurrentUser.User.Role != Role.PlanningManager)
            {
                tabControl1.TabPages.Remove(_reportedMalfunctionsTabPage);
            }
            if (CurrentUser.User.Role != Role.Employee)
            {
                tabControl1.TabPages.Remove(_reportMalfunctionTabPage);
            }
            if (CurrentUser.User.Role != Role.Technician)
            {
                tabControl1.TabPages.Remove(_plannedFixesTabPage);
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
                response = await ApiHelper.Instance.GetUsersAsync(_usersCurrentPageNumber, pageSize: (int)pageSizeUsersNumericUpDown.Value, roleFilter: searchUserTextBox.Text);
            else if (filterEmailRB.Checked)
                response = await ApiHelper.Instance.GetUsersAsync(_usersCurrentPageNumber, pageSize: (int)pageSizeUsersNumericUpDown.Value, emailFilter: searchUserTextBox.Text);

            _usersPagesCount = response.Pages;
            _usersCurrentPageNumber = response.PageNumber;
            totalPagesUsersLabel.Text = response.Pages.ToString();
            pageNumberUsersLabel.Text = response.PageNumber.ToString();
            LoadUsersTable(response.Data);
        }

        public void LoadMachinesTable(IEnumerable<Machine> data)
        {
            allMachinesTable.DataSource = data;
            allMachinesTable.Columns[0].Visible = false;
            for (int i = 1; i < allMachinesTable.ColumnCount; i++)
            {
                allMachinesTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            allMachinesTable.RowTemplate.Height = 35;
        }

        public async void LoadMachinesCombo()
        {
            GetMachinesResponse response = null;
            response = await ApiHelper.Instance.GetMachinesAsync(pageSize: 100000);
            List<Machine> reportMachines = (List<Machine>)response.Data;
            reportMachineComboBox.DataSource = reportMachines;
            reportMachineComboBox.DisplayMember = nameof(Machine.SerialNumber);
        }

        public async void LoadAllMachines()
        {
            GetMachinesResponse response = null;

            if (filterNameRB.Checked)
                response = await ApiHelper.Instance.GetMachinesAsync(_machinesCurrentPageNumber, pageSize: (int)pageSizeMachinesNumericUpDown.Value, nameFilter: searchMachineTextBox.Text);
            else if (filterSerialNumberRB.Checked)
                response = await ApiHelper.Instance.GetMachinesAsync(_machinesCurrentPageNumber, pageSize: (int)pageSizeMachinesNumericUpDown.Value, serialNumberFilter: searchMachineTextBox.Text);

            _machinesPagesCount = response.Pages;
            _machinesCurrentPageNumber = response.PageNumber;
            totalPagesMachinesLabel.Text = response.Pages.ToString();
            pageNumberMachinesLabel.Text = response.PageNumber.ToString();
            LoadMachinesTable(response.Data);
        }

        public async void LoadAllReports()
        {
            GetReportsResponse response = null;


            response = await ApiHelper.Instance.GetReportsAsync(_reportsCurrentPageNumber, pageSize: (int)pageSizeMalfunctionsNumericUpDown.Value, searchMachineNameMalfunctionTextBox.Text, notScheduledCheckBox.Checked, scheduledCheckBox.Checked, notFixedCheckBox.Checked, fixedCheckBox.Checked, overdueCheckBox.Checked);


            _reportsPagesCount = response.Pages;
            _reportsCurrentPageNumber = response.PageNumber;
            totalPagesMalfunctionsLabel.Text = response.Pages.ToString();
            pageNumberMalfunctionsLabel.Text = response.PageNumber.ToString();
            LoadReportsTable(response.Data);
        }

        public void LoadReportsTable(IEnumerable<Report> data)
        {
            MalfunctionsTableData = (List<Report>)data;
            for (int i = 0; i < MalfunctionsTableData.Count; i++)
            {
                MalfunctionsTableData[i].MadeByEmail = MalfunctionsTableData[i].MadeBy?.EmailAddress;
            }
            for (int i = 0; i < MalfunctionsTableData.Count; i++)
            {
                MalfunctionsTableData[i].MachineName = MalfunctionsTableData[i].Machine.Name;
            }
            allMalfunctionsTable.DataSource = MalfunctionsTableData;
            allMalfunctionsTable.Columns[0].Visible = false;
            allMalfunctionsTable.Columns[2].Visible = false;
            allMalfunctionsTable.Columns[4].Visible = false;
            allMalfunctionsTable.Columns[11].Visible = false;
            allMalfunctionsTable.Columns[5].HeaderText = "Made by";
            for (int i = 1; i < allMalfunctionsTable.ColumnCount; i++)
            {
                allMalfunctionsTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            allMalfunctionsTable.RowTemplate.Height = 35;
        }
        public async void LoadTechnicianReports()
        {
            GetReportsResponse response = null;


            response = await ApiHelper.Instance.GetReportsAsync(_reportsTechCurrentPageNumber, pageSize: (int)pageSizePlannedFixesNumericUpDown.Value, searchMachineNamePlannedFixesTextBox.Text);


            _reportsTechPagesCount = response.Pages;
            _reportsTechCurrentPageNumber = response.PageNumber;
            totalPagesPlannedFixesLabel.Text = response.Pages.ToString();
            pageNumberPlannedFixesLabel.Text = response.PageNumber.ToString();
            LoadTechnicianReportsTable(response.Data);
        }
        public void LoadTechnicianReportsTable(IEnumerable<Report> data)
        {
            MalfunctionsTableData = (List<Report>)data;
            for (int i = 0; i < MalfunctionsTableData.Count; i++)
            {
                MalfunctionsTableData[i].MadeByEmail = MalfunctionsTableData[i].MadeBy.EmailAddress;
            }
            for (int i = 0; i < MalfunctionsTableData.Count; i++)
            {
                MalfunctionsTableData[i].MachineName = MalfunctionsTableData[i].Machine.Name;
            }
            allPlannedFixesTable.DataSource = MalfunctionsTableData;
            allPlannedFixesTable.Columns[0].Visible = false;
            allPlannedFixesTable.Columns[2].Visible = false;
            allPlannedFixesTable.Columns[4].Visible = false;
            allPlannedFixesTable.Columns[5].Visible = false;
            allPlannedFixesTable.Columns[7].Visible = false;
            allPlannedFixesTable.Columns[8].Visible = false;
            allPlannedFixesTable.Columns[10].Visible = false;
            allPlannedFixesTable.Columns[11].Visible = false;

            for (int i = 1; i < allPlannedFixesTable.ColumnCount; i++)
            {
                allPlannedFixesTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            allPlannedFixesTable.RowTemplate.Height = 35;
        }
        private void InitializeHandlers()
        {
            signUp.Click += new System.EventHandler(signUp_Click);
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
            else if (userRoleRegisterComboBox.SelectedValue == null)
            {
                errorRegisterLabel.Text += "Invalid role";
                return;
            }
            Enum.TryParse<Role>(userRoleRegisterComboBox.SelectedValue.ToString().Replace(" m", "M"), out role);
            var response = await ApiHelper.Instance.Register(emailRegisterTextBox.Text, passwordRegisterTextBox.Text, nameRegisterTextBox.Text, surnameRegisterTextBox.Text, phoneRegisterTextBox.Text, birthCertificateNumberRegisterTextBox.Text, role);

            if (response.Success)
            {
                errorRegisterLabel.Text = String.Empty;
                errorRegisterLabel.Text += "Registered succesfully";
                _usersCurrentPageNumber = 1;
                LoadAllUsers();
                emailRegisterTextBox.Text = "";
                passwordRegisterTextBox.Text = "";
                confirmPasswordRegisterTextBox.Text = "";
                nameRegisterTextBox.Text = "";
                surnameRegisterTextBox.Text = "";
                phoneRegisterTextBox.Text = "";
                birthCertificateNumberRegisterTextBox.Text = "";
                userRoleRegisterComboBox.SelectedIndex = 0;
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
            if (_usersCurrentPageNumber <= 1) return;

            _usersCurrentPageNumber--;
            LoadAllUsers();
        }

        private void nextPageUsersPictureBox_Click(object sender, EventArgs e)
        {
            if (_usersCurrentPageNumber >= _usersPagesCount) return;

            _usersCurrentPageNumber++;
            LoadAllUsers();
        }

        private void refreshPictureBox_Click(object sender, EventArgs e)
        {
            _usersCurrentPageNumber = 1;
            LoadAllUsers();
        }

        private void searchUserTextBox_TextChanged(object sender, EventArgs e)
        {
            _usersCurrentPageNumber = 1;
            LoadAllUsers();
        }

        private void filterUsersRB_changed(object sender, EventArgs e)
        {
            LoadAllUsers();
        }

        private void pageSizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _usersCurrentPageNumber = 1;
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
            for (int i = 0; i < registeredUsersTable.ColumnCount; i++)
            {
                registeredUsersTable.Columns[i].HeaderText = Regex.Replace(registeredUsersTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }

        private void allMachinesTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < allMachinesTable.ColumnCount; i++)
            {
                allMachinesTable.Columns[i].HeaderText = Regex.Replace(allMachinesTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }

        private void allMalfunctionsTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < allMalfunctionsTable.ColumnCount; i++)
            {
                allMalfunctionsTable.Columns[i].HeaderText = Regex.Replace(allMalfunctionsTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
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

            var response = await ApiHelper.Instance.AddMachineAsync(serialNumberAddMachineTextBox.Text, machineNameAddMachineTextBox.Text, manufacturerNameAddMachineTextBox.Text, yearOfManufactureAddMachineTextBox.Text);

            if (response.Success)
            {
                errorAddMachineLabel.Text = String.Empty;
                errorAddMachineLabel.Text += "Machine added succesfully";
                _machinesCurrentPageNumber = 1;
                LoadAllMachines();
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

        private void previousPageMachinesPictureBox_Click(object sender, EventArgs e)
        {
            if (_machinesCurrentPageNumber <= 1)
                return;

            _machinesCurrentPageNumber--;
            LoadAllMachines();
        }

        private void nextPageMachinesPictureBox_Click(object sender, EventArgs e)
        {
            if (_machinesCurrentPageNumber >= _machinesPagesCount)
                return;

            _machinesCurrentPageNumber++;
            LoadAllMachines();
        }

        private void refreshMachinesPictureBox_Click(object sender, EventArgs e)
        {
            _machinesCurrentPageNumber = 1;
            LoadAllMachines();
        }

        private void searchMachineTextBox_TextChanged(object sender, EventArgs e)
        {
            _machinesCurrentPageNumber = 1;
            LoadAllMachines();
        }

        private void pageSizeMachinesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _machinesCurrentPageNumber = 1;
            LoadAllMachines();
        }

        private void filterMachinesRB_changed(object sender, EventArgs e)
        {
            LoadAllMachines();
        }

        private void allMachinesTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string dataValue = allMachinesTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedMachineForm = new SelectedMachineForm(dataValue, this);
                this.Enabled = false;
                _selectedMachineForm.Show();
            }
        }

        private async void reportMalfunction_Click(object sender, EventArgs e)
        {
            errorReportLabel.Text = String.Empty;
            Priority priority;
            Machine machine;

            if (reportMachineComboBox.SelectedValue == null)
            {
                errorReportLabel.Text += "Invalid machine";
                return;
            }
            else if (reportPriorityComboBox.SelectedValue == null)
            {
                errorReportLabel.Text += "Invalid priority";
                return;
            }
            else if (reportDescriptionTextBox.Text == "")
            {
                errorReportLabel.Text += "Description is empty";
                return;
            }
            Enum.TryParse<Priority>(reportPriorityComboBox.SelectedValue.ToString(), out priority);
            machine = (Machine)reportMachineComboBox.SelectedItem;

            var response = await ApiHelper.Instance.ReportMalfunctionAsync(machine.Id, reportDescriptionTextBox.Text, priority);

            if (response.Success)
            {
                errorReportLabel.Text = String.Empty;
                errorReportLabel.Text += "Reported succesfully";
                reportMachineComboBox.SelectedIndex = 0;
                reportPriorityComboBox.SelectedIndex = 0;
                reportDescriptionTextBox.Text = "";
                return;
            }

            foreach (var error in response.Errors)
            {
                errorReportLabel.Text += error + Environment.NewLine;
            }
        }

        private void previousPageMalfunctionsPictureBox_Click(object sender, EventArgs e)
        {
            if (_reportsCurrentPageNumber <= 1)
                return;

            _reportsCurrentPageNumber--;
            LoadAllReports();
        }

        private void nextPageMalfunctionsPictureBox_Click(object sender, EventArgs e)
        {
            if (_reportsCurrentPageNumber >= _reportsPagesCount)
                return;

            _reportsCurrentPageNumber++;
            LoadAllReports();
        }

        private void refreshMalfunctionsPictureBox_Click(object sender, EventArgs e)
        {
            _reportsCurrentPageNumber = 1;
            LoadAllReports();
        }

        private void searchMachineNameMalfunctionTextBox_TextChanged(object sender, EventArgs e)
        {
            _reportsCurrentPageNumber = 1;
            LoadAllReports();
        }

        private void pageSizeMalfunctionsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _reportsCurrentPageNumber = 1;
            LoadAllReports();
        }

        private void reportsFilterChB_Changed(object sender, EventArgs e)
        {
            LoadAllReports();
        }

        private void allMalfunctionsTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex > -1)
                {
                    if (MalfunctionsTableData[e.RowIndex].MadeBy != null)
                    {
                        string UserInfo = $@"Name:{MalfunctionsTableData[e.RowIndex].MadeBy.Name}
Email address:{MalfunctionsTableData[e.RowIndex].MadeBy.EmailAddress}";
                        UserInfoToolTip.Show(UserInfo, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2147483647);
                    }
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (e.RowIndex > -1)
                {
                    string MachineInfo = $@"Name:{MalfunctionsTableData[e.RowIndex].Machine.Name}
Serial number:{MalfunctionsTableData[e.RowIndex].Machine.SerialNumber}";
                    MachineInfoToolTip.Show(MachineInfo, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2147483647);
                }
            }
        }

        private void allMalfunctionsTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            UserInfoToolTip.Hide(this);
            MachineInfoToolTip.Hide(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout == false)
            {
                _backgroundForm.Close();
            }
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            _loginForm = new LoginForm(_backgroundForm);
            _loginForm.Show();
            _loginForm.ShowInTaskbar = true;
            logout = true;
            ApiHelper.Instance.LogoutUser();
            this.Close();
        }

        private void allMalfunctionsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string dataValue = allMalfunctionsTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                _selectedReportForm = new SelectedReportForm(dataValue, this);
                this.Enabled = false;
                _selectedReportForm.Show();
            }
        }

        private void previousPagePlannedFixesPictureBox_Click(object sender, EventArgs e)
        {
            if (_reportsTechCurrentPageNumber <= 1)
                return;

            _reportsTechCurrentPageNumber--;
            LoadTechnicianReports();
        }

        private void nextPagePlannedFixesPictureBox_Click(object sender, EventArgs e)
        {
            if (_reportsTechCurrentPageNumber >= _reportsTechPagesCount)
                return;

            _reportsTechCurrentPageNumber++;
            LoadTechnicianReports();
        }

        private void refreshPlannedFixesPictureBox_Click(object sender, EventArgs e)
        {
            _reportsTechCurrentPageNumber = 1;
            LoadTechnicianReports();
        }

        private void searchMachineNamePlannedFixesTextBox_TextChanged(object sender, EventArgs e)
        {
            _reportsTechCurrentPageNumber = 1;
            LoadTechnicianReports();
        }

        private void pageSizePlannedFixesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            _reportsTechCurrentPageNumber = 1;
            LoadTechnicianReports();
        }

        private void allPlannedFixesTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.RowIndex > -1)
                {
                    string MachineInfo = $@"Name:{MalfunctionsTableData[e.RowIndex].Machine.Name}
Serial number:{MalfunctionsTableData[e.RowIndex].Machine.SerialNumber}";
                    MachineInfoToolTip.Show(MachineInfo, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2147483647);
                }
            }
        }

        private void allPlannedFixesTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            MachineInfoToolTip.Hide(this);
        }

        private async void fixedStatus_ClickAsync(object sender, EventArgs e)
        {
            errorReportLabel.Text = String.Empty;
            string reportId = allPlannedFixesTable[0, allPlannedFixesTable.CurrentRow.Index].Value.ToString();
            if (reportId == "")
            {
                errorPlannedFixesLabel.Text += "Row not selected";
                return;
            }
            var response = await ApiHelper.Instance.ChangeFixedStatusAsync(reportId);

            if (response.Success)
            {
                errorPlannedFixesLabel.Text = String.Empty;
                errorPlannedFixesLabel.Text += "Status changed to fixed";
                LoadTechnicianReports();
                return;
            }

            foreach (var error in response.Errors)
            {
                errorPlannedFixesLabel.Text += error + Environment.NewLine;
            }
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = $"{DateTime.UtcNow.ToString("dddd, dd. MMMM yyyy, HH:mm:ss", new CultureInfo("en-GB", false))} UTC";
        }

        private void allPlannedFixesTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < allPlannedFixesTable.ColumnCount; i++)
            {
                allPlannedFixesTable.Columns[i].HeaderText = Regex.Replace(allPlannedFixesTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }
    }
}
