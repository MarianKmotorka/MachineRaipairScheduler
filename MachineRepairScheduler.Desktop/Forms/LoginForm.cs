using MachineRepairScheduler.Desktop.Models;
using System;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private MainForm _startupForm;
        private BackgroundForm _backgroundForm;
        private bool login = false;
        public LoginForm(BackgroundForm backgroundForm)
        {
            _backgroundForm = backgroundForm;
            InitializeComponent();
            loginLoadBar.Visible = false;
            this.showLoginPassword.Click += showLoginPassword_CheckedChanged;
            this.logIn.Click += logIn_Click;
            loginEmailTextBox.Text = "tech@test.com";
            loginPasswordTextBox.Text = "Vinco123";
        }

        private void showLoginPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showLoginPassword.Checked)
                loginPasswordTextBox.PasswordChar = '\0';
            else
                loginPasswordTextBox.PasswordChar = '*';
        }

        private async void logIn_Click(object sender, EventArgs e)
        {
            errorLoginLabel.Text = String.Empty;
            if (loginEmailTextBox.Text == "")
            {
                errorLoginLabel.Text += "Login is empty";
                return;
            }
            else if (loginPasswordTextBox.Text == "")
            {
                errorLoginLabel.Text += "Password is empty";
                return;
            }

            loginLoadBar.Visible = true;
            loginLoadBar.Style = ProgressBarStyle.Marquee;


            loginLoadBar.Visible = true;
            logIn.Enabled = false;

            var response = await ApiHelper.Instance.Login(loginEmailTextBox.Text, loginPasswordTextBox.Text);

            loginLoadBar.Visible = false;

            if (response.Success)
            {
                CurrentUser.User.Token = response.Token;
                CurrentUser.User.Email = loginEmailTextBox.Text;
                CurrentUser.User.Role = response.UserRole;
                _startupForm = new MainForm(_backgroundForm);
                _startupForm.Show();
                _startupForm.ShowInTaskbar = true;
                login = true;
                this.Close();
                _startupForm.FilterOutUnathorizedTabs();
                if (CurrentUser.User.Role == Role.SysAdmin)
                {
                    _startupForm.LoadAllUsers();
                    _startupForm.LoadAllMachines();
                }
                if (CurrentUser.User.Role == Role.Employee)
                {
                    _startupForm.LoadMachinesCombo();
                }
                if (CurrentUser.User.Role == Role.PlanningManager)
                {
                    _startupForm.LoadAllReports();
                }
                if (CurrentUser.User.Role == Role.Technician)
                {
                    _startupForm.LoadTechnicianReports();
                }
                return;
            }

            logIn.Enabled = true;
            foreach (var error in response.Errors)
            {
                errorLoginLabel.Text += error + Environment.NewLine;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login == false)
            {
                _backgroundForm.Close();
            }
        }
    }
}
