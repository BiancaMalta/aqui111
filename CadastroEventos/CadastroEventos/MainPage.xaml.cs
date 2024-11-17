using CadastroEventos.Models;

namespace CadastroEventos
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Evento();                      
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var evento = (Evento)BindingContext;

            // Navegar para a página de resumo passando o evento como BindingContext
            var resumoPage = new ResumoEventoPage
            {
                BindingContext = evento
            };
            await Navigation.PushAsync(resumoPage);
        }
                               
    }
}