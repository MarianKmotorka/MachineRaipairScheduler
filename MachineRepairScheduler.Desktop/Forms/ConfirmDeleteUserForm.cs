using System;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class ConfirmDeleteUserForm : Form
    {
        private SelectedUserForm _selectedUserForm;
        private string _userId;
        public ConfirmDeleteUserForm(SelectedUserForm selectedUserForm, string userID)
        {
            _selectedUserForm = selectedUserForm;
            _selectedUserForm.ShowInTaskbar = false;
            _userId = userID;
            InitializeComponent();
        }

        private void ConfirmDeleteUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedUserForm.ShowInTaskbar = true;
            _selectedUserForm.Enabled = true;
        }

        private void confirmDeleteUserNoButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void confirmDeleteUserYesButton_Click(object sender, EventArgs e)
        {
            var response = await ApiHelper.Instance.DeleteSelectedUserAsync(_userId);

            if (response.Success)
            {
                this.Close();
                _selectedUserForm.Close();
                return;
            }

            foreach (var error in response.Errors)
            {
                errorConfirmDeleteSelectedUserLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
