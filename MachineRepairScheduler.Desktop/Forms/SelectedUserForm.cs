using MachineRepairScheduler.Desktop.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class SelectedUserForm : Form
    {
        private StartupForm _startupForm;
        private ConfirmDeleteUserForm _confirmDeleteUserForm;
        private string _userId;
        public SelectedUserForm(string userID, StartupForm startupForm)
        {
            _startupForm = startupForm;
            _startupForm.ShowInTaskbar = false;
            _userId = userID;
            LoadSelectedUserTable(_userId);
            InitializeComponent();
        }
        public async void LoadSelectedUserTable(string userId)
        {
            var userData = await ApiHelper.Instance.GetSelectedUserAsync(userId);
            List<GetSelectedUserResponse> data = new List<GetSelectedUserResponse>();
            data.Add(userData);
            selectedUserTable.DataSource = data;
            selectedUserTable.Columns[0].Visible = false;
            for (int i = 1; i < selectedUserTable.ColumnCount; i++)
            {
                selectedUserTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void SelectedUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm.Enabled = true;
            _startupForm.ShowInTaskbar = true;
        }

        private void deleteSelectedUserPictureBox_Click(object sender, System.EventArgs e)
        {
            _confirmDeleteUserForm = new ConfirmDeleteUserForm(this, _userId);
            this.Enabled = false;
            _confirmDeleteUserForm.Show();
        }
    }
}
