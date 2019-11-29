using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class EditUserForm : Form
    {
        private StartupForm _startupForm;
        public EditUserForm(string userID, StartupForm startupForm)
        {
            this.ShowInTaskbar = false;
            _startupForm = startupForm;
            //userTable.DataSource = 
            InitializeComponent();
        }

        private void EditUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _startupForm.Enabled = true;
        }

        private void deleteUser_Click(object sender, System.EventArgs e)
        {

        }
    }
}
