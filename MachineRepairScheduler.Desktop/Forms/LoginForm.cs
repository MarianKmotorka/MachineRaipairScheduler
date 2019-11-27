using MachineRepairScheduler.Desktop.Models;
using System;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class LoginForm : Form
    {
        private StartupForm _startupForm;

        public LoginForm(StartupForm startupForm)
        {
            _startupForm = startupForm;
            InitializeComponent();
            this.showLoginPassword.Click += showLoginPassword_CheckedChanged;
            this.logIn.Click += logIn_Click;
            loginEmailTextBox.Text = "admin@test.com";
            loginPasswordTextBox.Text = "Vinco123";
        }

        private void LoginForm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            _startupForm.Close();
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
            var response = await ApiHelper.Instance.Login(loginEmailTextBox.Text, loginPasswordTextBox.Text);
            if (response.Success)
            {
                CurrentUser.User.Token = response.Token;
                CurrentUser.User.Email = loginEmailTextBox.Text;
                CurrentUser.User.Role = response.UserRole;
                _startupForm.Show();
                _startupForm.ShowInTaskbar = true;
                this.Close();
                _startupForm.FilterOutUnathorizedTabs();
                return;
            }
            foreach (var error in response.Errors)
            {
                errorLoginLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
