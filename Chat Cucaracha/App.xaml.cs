using Chat_Cucaracha.Views.PruebasViews;

namespace Chat_Cucaracha
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new NavigationPage(new AppShell());
            MainPage = new AppShell();
        }
    }
}
