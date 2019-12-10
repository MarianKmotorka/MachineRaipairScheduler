using MachineRepairScheduler.Desktop.Responses;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MachineRepairScheduler.Desktop.Forms
{
    public partial class SelectedMachineForm : Form
    {
        private MainForm _startupForm;
        private ConfirmDeleteMachineForm _confirmDeleteMachineForm;
        private string _machineID;
        public SelectedMachineForm(string machineID, MainForm startupForm)
        {
            InitializeComponent();
            _startupForm = startupForm;
            _startupForm.ShowInTaskbar = false;
            _machineID = machineID;
            LoadSelectedMachineTable(_machineID);
        }
        private async void LoadSelectedMachineTable(string machineID)
        {
            var machineData = await ApiHelper.Instance.GetSelectedMachineAsync(machineID);
            List<GetSelectedMachineResponse> data = new List<GetSelectedMachineResponse>();
            data.Add(machineData);
            selectedMachineTable.DataSource = data;
            LoadEditMachineForm(data);
            selectedMachineTable.Columns[0].Visible = false;
            for (int i = 1; i < selectedMachineTable.ColumnCount; i++)
            {
                selectedMachineTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            selectedMachineTable.RowTemplate.Height = 70;
        }
        private void LoadEditMachineForm(List<GetSelectedMachineResponse> data)
        {
            serialNumberEditMachineTextBox.Text = data[0].SerialNumber;
            machineNameEditMachineTextBox.Text = data[0].MachineName;
            manufacturerNameEditMachineTextBox.Text = data[0].ManufacturerName;
            yearOfManufactureEditMachineTextBox.Text = data[0].YearOfManufacture;
        }
        private void SelectedMachineForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _startupForm._machinesCurrentPageNumber = 1;
            _startupForm.LoadAllMachines();
            _startupForm.Enabled = true;
            _startupForm.ShowInTaskbar = true;
        }
        private async void editMachine_Click(object sender, EventArgs e)
        {
            errorEditMachineLabel.Text = String.Empty;

            if (serialNumberEditMachineTextBox.Text == "")
            {
                errorEditMachineLabel.Text += "Serial number is empty";
                return;
            }
            else if (machineNameEditMachineTextBox.Text == "")
            {
                errorEditMachineLabel.Text += "Machine name is empty";
                return;
            }
            else if (manufacturerNameEditMachineTextBox.Text == "")
            {
                errorEditMachineLabel.Text += "Manufacturer name is empty";
                return;
            }

            var response = await ApiHelper.Instance.EditSelectedMachineAsync(_machineID, serialNumberEditMachineTextBox.Text, machineNameEditMachineTextBox.Text, manufacturerNameEditMachineTextBox.Text, yearOfManufactureEditMachineTextBox.Text);

            if (response.Success)
            {
                errorEditMachineLabel.Text = String.Empty;
                errorEditMachineLabel.Text += "Edited succesfully";
                LoadSelectedMachineTable(_machineID);
                return;
            }

            foreach (var error in response.Errors)
            {
                errorEditMachineLabel.Text += error + Environment.NewLine;
            }
        }

        private void deleteSelectedMachinePictureBox_Click(object sender, EventArgs e)
        {
            _confirmDeleteMachineForm = new ConfirmDeleteMachineForm(this, _machineID);
            this.Enabled = false;
            _confirmDeleteMachineForm.Show();
        }

        private void selectedMachineTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < selectedMachineTable.ColumnCount; i++)
            {
                selectedMachineTable.Columns[i].HeaderText = Regex.Replace(selectedMachineTable.Columns[i].HeaderText, @"\B[A-Z]", m => " " + m.ToString().ToLower());
            }
        }
    }
}
