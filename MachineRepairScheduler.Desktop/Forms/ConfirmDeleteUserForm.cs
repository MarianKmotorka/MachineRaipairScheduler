using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class ConfirmDeleteUserForm : Form
    {
        private SelectedUserForm _selectedUserForm;
        public ConfirmDeleteUserForm(SelectedUserForm selectedUserForm, string userID)
        {
            _selectedUserForm = selectedUserForm;
            _selectedUserForm.ShowInTaskbar = false;
            InitializeComponent();
        }

        private void confirmDeleteUserNoButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void ConfirmDeleteUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedUserForm.Enabled = true;
            _selectedUserForm.ShowInTaskbar = true;
        }
    }
}
