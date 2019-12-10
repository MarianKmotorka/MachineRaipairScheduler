using MachineRepairScheduler.Desktop.Models;
using MachineRepairScheduler.Desktop.Responses;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class SelectedReportForm : Form
    {
        private MainForm _startupForm;
        private string _reportID;
        private ToolTip UserInfoToolTip = new ToolTip();
        private ToolTip MachineInfoToolTip = new ToolTip();
        List<GetSelectedReportResponse> data;
        public SelectedReportForm(string reportID, MainForm startupForm)
        {
            InitializeComponent();
            _startupForm = startupForm;
            _startupForm.ShowInTaskbar = false;
            _reportID = reportID;
            fixDateMonthCalendar.MaxSelectionCount = 1;
            LoadSelectedReportTable(_reportID);
        }
        private async void LoadTechniciansCheckListAsync(List<Technician> technicians)
        {
            GetUsersResponse response = null;
            response = await ApiHelper.Instance.GetUsersAsync(pageSize: 100000, roleFilter: "Technician");
            List<User> reportMachines = (List<User>)response.Data;
            selectTechniciansCheckList.DataSource = reportMachines;
            selectTechniciansCheckList.DisplayMember = nameof(User.EmailAddress);

            for (int count = 0; count < selectTechniciansCheckList.Items.Count; count++)
            {
                for (int i = 0; i < technicians.Count; i++)
                {
                    if (technicians[i].EmailAddress == reportMachines[count].EmailAddress)
                    {
                        selectTechniciansCheckList.SetItemChecked(count, true);
                    }
                }
            }
        }
        private async void LoadSelectedReportTable(string reportID)
        {
            var reportData = await ApiHelper.Instance.GetSelectedReportAsync(reportID);
            data = new List<GetSelectedReportResponse>();
            data.Add(reportData);
            List<Technician> technicians = (List<Technician>)data[0].Technicians;
            LoadSelectedTechniciansTable(technicians);
            LoadTechniciansCheckListAsync(technicians);
            if (data[0].PlannedFixDate.HasValue)
            {
                fixDateMonthCalendar.SetDate(data[0].PlannedFixDate.Value);
            }
            data[0].MadeByEmail = data[0].MadeBy.EmailAddress;
            data[0].MachineName = data[0].Machine.Name;
            data[0].TechniciansCount = technicians.Count;
            selectedReportTable.DataSource = data;
            selectedReportTable.Columns[0].Visible = false;
            selectedReportTable.Columns[2].Visible = false;
            selectedReportTable.Columns[4].Visible = false;
            selectedReportTable.Columns[11].Visible = false;
            selectedReportTable.Columns[5].HeaderText = "Made by";
            for (int i = 1; i < selectedReportTable.ColumnCount; i++)
            {
                selectedReportTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            selectedReportTable.RowTemplate.Height = 50;
        }
        private void LoadSelectedTechniciansTable(List<Technician> technicians)
        {
            selectedTechniciansTable.DataSource = technicians;
            selectedTechniciansTable.Columns[0].Visible = false;
            for (int i = 1; i < selectedTechniciansTable.ColumnCount; i++)
            {
                selectedTechniciansTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            selectedTechniciansTable.RowTemplate.Height = 50;
        }
        private void SelectedReportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm._reportsCurrentPageNumber = 1;
            _startupForm.LoadAllReports();
            _startupForm.Enabled = true;
            _startupForm.ShowInTaskbar = true;
        }

        private void selectedReportTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < selectedReportTable.ColumnCount; i++)
            {
                selectedReportTable.Columns[i].HeaderText = Regex.Replace(selectedReportTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }

        private void selectedTechniciansTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < selectedTechniciansTable.ColumnCount; i++)
            {
                selectedTechniciansTable.Columns[i].HeaderText = Regex.Replace(selectedTechniciansTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }

        private void selectedReportTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.RowIndex > -1)
                {
                    string UserInfo = $@"Name:{data[0].MadeBy.Name}
Email address:{data[0].MadeBy.EmailAddress}";
                    UserInfoToolTip.Show(UserInfo, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2147483647);
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (e.RowIndex > -1)
                {
                    string MachineInfo = $@"Name:{data[0].Machine.Name}
Serial number:{data[0].Machine.SerialNumber}";
                    MachineInfoToolTip.Show(MachineInfo, this, Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y, 2147483647);
                }
            }
        }

        private void selectedReportTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            UserInfoToolTip.Hide(this);
            MachineInfoToolTip.Hide(this);
        }
        private async void changeDetails_Click(object sender, EventArgs e)
        {
            errorSelectTechniciansLabel.Text = String.Empty;

            if (selectTechniciansCheckList.CheckedItems.Count == 0)
            {
                errorSelectTechniciansLabel.Text += "No technician checked";
                return;
            }
            else if (fixDateMonthCalendar.SelectionRange.Start.Date <= DateTime.Today)
            {
                errorSelectTechniciansLabel.Text += "Date is in the past";
                return;
            }
            List<User> checkedTechnicians = new List<User>();
            foreach (object itemChecked in selectTechniciansCheckList.CheckedItems)
            {
                checkedTechnicians.Add(itemChecked as User);
            }
            string[] checkedTechniciansID = new string[checkedTechnicians.Count];
            for (int i = 0; i < checkedTechnicians.Count; i++)
            {
                checkedTechniciansID[i] = checkedTechnicians[i].UserID;
            }
            var response = await ApiHelper.Instance.PlanFixAsync(_reportID, checkedTechniciansID, fixDateMonthCalendar.SelectionRange.Start.Date);

            if (response.Success)
            {
                errorSelectTechniciansLabel.Text = String.Empty;
                errorSelectTechniciansLabel.Text += "Planned succesfully";
                LoadSelectedReportTable(_reportID);
                return;
            }

            foreach (var error in response.Errors)
            {
                errorSelectTechniciansLabel.Text += error + Environment.NewLine;
            }
        }
    }
}
