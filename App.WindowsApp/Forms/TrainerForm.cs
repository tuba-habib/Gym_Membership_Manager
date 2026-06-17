using App.Core.Contracts;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class TrainerForm : Form
    {
        private ITrainerService _trainerService;
        private TrainerFormModeEnum _mode;
        private Trainer _trainer;

        public TrainerForm(ITrainerService service, TrainerFormModeEnum mode, Trainer? trainer = null)
        {
            InitializeComponent();
            _trainerService = service;
            _mode = mode;
            _trainer = trainer ?? new Trainer();
            PopulateFields();
            SetupMode();
        }

        private void PopulateFields()
        {
            txtId.Text = _trainer.Id;
            txtName.Text = _trainer.Name;
            txtPhone.Text = _trainer.Phone;
            txtEmail.Text = _trainer.Email;
            txtSpecialization.Text = _trainer.Specialization;
        }

        private void SetupMode()
        {
            switch (_mode)
            {
                case TrainerFormModeEnum.Add:
                    this.Text = "Add Trainer";
                    lblId.Visible = false;
                    txtId.Visible = false;
                    break;
                case TrainerFormModeEnum.Edit:
                    this.Text = "Edit Trainer";
                    btnSave.Text = "Update";
                    break;
                case TrainerFormModeEnum.View:
                    this.Text = "View Trainer";
                    txtName.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtSpecialization.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }

        private bool ValidateData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name cannot be empty", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone cannot be empty", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    _trainer.Name = txtName.Text;
                    _trainer.Phone = txtPhone.Text;
                    _trainer.Email = txtEmail.Text;
                    _trainer.Specialization = txtSpecialization.Text;

                    if (_mode == TrainerFormModeEnum.Add)
                    {
                        await _trainerService.AddAsync(_trainer);
                        MessageBox.Show("Trainer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        await _trainerService.UpdateAsync(_trainer);
                        MessageBox.Show("Trainer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving trainer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}