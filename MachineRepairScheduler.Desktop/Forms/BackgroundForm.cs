using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class BackgroundForm : Form
    {
        public BackgroundForm()
        {
            InitializeComponent();
        }

        private void BackgroundForm_Load(object sender, System.EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;
            new LoginForm(this).Show();
        }
    }
}
