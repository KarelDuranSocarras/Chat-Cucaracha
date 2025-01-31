namespace Chat_Cucaracha.Util.Dependencias
{
    public static class Dependencias
    {
        public static MauiAppBuilder DependenciasViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            //mauiAppBuilder.Services.AddTransient<Chat_Cucaracha.ViewModels.ChatViewModel>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.ViewModels.ChatViewModel>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.ViewModels.LoginViewModel>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.ViewModels.UsuariosConectadosViewModel>();

            return mauiAppBuilder;
        }
        public static MauiAppBuilder DependenciasViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.Views.LoginView.AccesoView>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.Views.ChatViews.ChatView>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.Views.PruebasViews.PruebaView>();
            mauiAppBuilder.Services.AddSingleton<Chat_Cucaracha.Views.ChatViews.UsuariosConectadosView>();
            
            //mauiAppBuilder.Services.AddTransient<Chat_Cucaracha.Views.LoginView.AccesoView>();

            return mauiAppBuilder;
        }
    }
}
