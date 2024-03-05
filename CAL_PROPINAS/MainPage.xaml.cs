using CAL_PROPINAS.Model;
using CAL_PROPINAS.ViewModel;
using Microsoft.Maui.Controls;

namespace CAL_PROPINAS
{
    public partial class MainPage : ContentPage
    {
        private CalculadoraPropinaViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            viewModel = new CalculadoraPropinaViewModel();
            BindingContext = viewModel;
        }

        private void OnPorcentajePropinaClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                double.TryParse(button.Text.Trim('%'), out double porcentajePropina);
                viewModel.PorcentajePropina = porcentajePropina;
            }
        }

        private void OnCalcularClicked(object sender, EventArgs e)
        {
            viewModel.CalcularPropina();
        }

        private void OnLimpiarClicked(object sender, EventArgs e)
        {
            viewModel.Limpiar();
        }
    }
}
