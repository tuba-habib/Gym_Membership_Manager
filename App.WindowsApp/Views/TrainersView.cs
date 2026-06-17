using App.Core.Contracts;
using App.Core.Models;
using App.WindowsApp.Forms;

namespace App.WindowsApp.Views
{
    public partial class TrainersView : UserControl
    {
        private readonly ITrainerService _trainerService;
        private BindingSource _bindingSource = new BindingSource();

        public TrainersView(ITrainerService service)
        {
            _trainerService = service;
            InitializeComponent();
            dgvTrainers.DataSource = _bindingSource;
            this.Load += TrainersView_Load;
        }

        private async void TrainersView_Load(object sender, EventArgs e)
        {
            await LoadTrainersAsync();
        }

        private async Task LoadTrainersAsync()
        {
            _bindingSource.DataSource = await _trainerService.GetAllAsync();
        }

        private async void tsbAdd_Click(object sender, EventArgs e)
        {
            var form = new TrainerForm(_trainerService, TrainerFormModeEnum.Add);
            if (form.ShowDialog() == DialogResult.OK) await LoadTrainersAsync();
        }

        private async void tsbEdit_Click(object sender, EventArgs e)
        {
            Trainer selected = _bindingSource.Current as Trainer;
            if (selected != null)
            {
                var form = new TrainerForm(_trainerService, TrainerFormModeEnum.Edit, selected);
                if (form.ShowDialog() == DialogResult.OK) await LoadTrainersAsync();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Trainer selected = _bindingSource.Current as Trainer;
            if (selected != null)
            {
                var form = new TrainerForm(_trainerService, TrainerFormModeEnum.View, selected);
                form.ShowDialog();
            }
        }

        private async void tsbDelete_Click(object sender, EventArgs e)
        {
            Trainer selected = _bindingSource.Current as Trainer;
            if (selected != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this trainer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    await _trainerService.DeleteAsync(selected.Id);
                    await LoadTrainersAsync();
                }
            }
        }

        private async void tsbRefresh_Click(object sender, EventArgs e) => await LoadTrainersAsync();

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            if (string.IsNullOrWhiteSpace(query))
                await LoadTrainersAsync();
            else
                _bindingSource.DataSource = await _trainerService.SearchAsync(query);
        }
    }
}