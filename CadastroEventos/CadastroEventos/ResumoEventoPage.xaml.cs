using Microsoft.Maui.Controls;

namespace CadastroEventos
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}