using System;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class ConfirmDeleteMachineForm : Form
    {
        private SelectedMachineForm _selectedMachineForm;
        private string _machineID;
        public ConfirmDeleteMachineForm(SelectedMachineForm selectedMachineForm, string machineID)
        {
            _selectedMachineForm = selectedMachineForm;
            _selectedMachineForm.ShowInTaskbar = false;
            _machineID = machineID;
            InitializeComponent();
        }

        private void ConfirmDeleteMachineForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _selectedMachineForm.ShowInTaskbar = true;
            _selectedMachineForm.Enabled = true;
        }

        private void confirmDeleteMachineNoButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private async void confirmDeleteMachineYesButton_Click(object sender, System.EventArgs e)
        {
            var response = await ApiHelper.Instance.DeleteSelectedMachineAsync(_machineID);

            if (response.Success)
            {
                this.Close();
                _selectedMachineForm.Close();
                return;
            }

            foreach (var error in response.Errors)
            {
                errorConfirmDeleteSelectedMachineLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
