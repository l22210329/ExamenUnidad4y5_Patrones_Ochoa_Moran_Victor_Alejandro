using EXAMEN_4_Y_5_Unidad.ViewModels;

namespace EXAMEN_4_Y_5_Unidad
{
    public partial class MainPage : ContentPage
    {
        public AgendaViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();
            ViewModel = new AgendaViewModel();
            BindingContext = ViewModel;
        }

        private void OnAgregarClick(object sender, EventArgs e)
        {
            ViewModel.AgregarEvento();
        }

        private void OnRestaurarClick(object sender, EventArgs e)
        {
            ViewModel.Restaurar();
        }
    }
}
