using App.Core.Contracts;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class TrainerPicker : Form
    {
        private readonly ITrainerService _trainerService;
        private BindingSource _bindingSource;
        public Trainer SelectedTrainer { get; private set; }

        public TrainerPicker(ITrainerService service)
        {
            InitializeComponent();
            _trainerService = service;
            _bindingSource = new BindingSource();
            lsTrainers.DataSource = _bindingSource;
            this.Load += TrainerPicker_Load;
        }

        private async void TrainerPicker_Load(object sender, EventArgs e)
        {
            await LoadTrainersAsync(string.Empty);
        }

        private async Task LoadTrainersAsync(string query)
        {
            var trainers = string.IsNullOrWhiteSpace(query)
                ? await _trainerService.GetAllAsync()
                : await _trainerService.SearchAsync(query);
            _bindingSource.DataSource = trainers;
            lsTrainers.DisplayMember = "Name";
            lsTrainers.ValueMember = "Id";
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadTrainersAsync(txtSearch.Text);
        }

        private void SelectTrainer()
        {
            if (lsTrainers.SelectedItem != null && lsTrainers.SelectedItem is Trainer)
            {
                SelectedTrainer = (Trainer)lsTrainers.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a trainer", "Trainer Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) => SelectTrainer();
        private void lsTrainers_DoubleClick(object sender, EventArgs e) => SelectTrainer();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}