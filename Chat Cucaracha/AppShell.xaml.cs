namespace Chat_Cucaracha
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("AccesoView", typeof(Chat_Cucaracha.Views.LoginView.AccesoView));
            Routing.RegisterRoute("UsuariosConectadosView", typeof(Chat_Cucaracha.Views.ChatViews.UsuariosConectadosView));
            Routing.RegisterRoute("ChatView", typeof(Chat_Cucaracha.Views.ChatViews.ChatView));
        }
    }
}
