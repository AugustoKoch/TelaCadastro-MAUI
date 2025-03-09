using Microsoft.Maui.Controls;

namespace MeuPrimeiroAppMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCadastreseClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///Cadastro");
        }
    }

}
