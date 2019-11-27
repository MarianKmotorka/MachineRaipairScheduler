using MachineRepairScheduler.Desktop.Models;
using System;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class StartupForm : Form
    {
        private TabPage _registerTabPage => tabControl1.TabPages["RegisterTabPage"];

        public StartupForm()
        {
            InitializeComponent();
            showRegisterPassword.CheckedChanged += new EventHandler(showRegisterPassword_CheckedChanged);
            InitializeHandlers();
            userRoleComboBox.DataSource = new[] { Role.Employee, Role.PlanningManager, Role.Technician };
        }

        public void FilterOutUnathorizedTabs()
        {
            if (CurrentUser.User.Role != Role.SysAdmin)
                tabControl1.TabPages.Remove(_registerTabPage);
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
                registerPasswordTextBox.PasswordChar = '\0';
                registerConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                registerPasswordTextBox.PasswordChar = '*';
                registerConfirmPasswordTextBox.PasswordChar = '*';
            }
        }

        private async void signUp_Click(object sender, EventArgs e)
        {
            errorRegisterLabel.Text = String.Empty;
            Role role;
            Enum.TryParse<Role>(userRoleComboBox.SelectedValue.ToString(), out role);
            var response = await ApiHelper.Instance.Register(registerEmailTextBox.Text, registerPasswordTextBox.Text, role);
            if (response.Success)
            {
                errorRegisterLabel.Text += "Registered succesfully";
                return;
            }
            foreach (var error in response.Errors)
            {
                errorRegisterLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
