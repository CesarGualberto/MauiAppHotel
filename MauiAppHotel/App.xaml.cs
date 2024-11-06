using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
       public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Súite Super Luxo",
                ValorDiariaAdulto = 110.00,
                ValorDiariaCrianca = 55.00
            },
            
            new Quarto()
            {
                Descricao = "Súite Luxo",
                ValorDiariaAdulto = 80.00,
                ValorDiariaCrianca = 40.00
            },
            
            new Quarto()
            {
                Descricao = "Súite Single",
                ValorDiariaAdulto = 50.00,
                ValorDiariaCrianca = 25.00
            },

            new Quarto()
            {
                Descricao = "Súite Crise",
                ValorDiariaAdulto = 25.00,
                ValorDiariaCrianca = 12.5
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var Window = base.CreateWindow(activationState);

            Window.Width = 400;
            Window.Height = 600;

            return Window;
        }
    }
}
