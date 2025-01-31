using Chat_Cucaracha.Util.ASP.NET;
using Microsoft.Extensions.Logging;
using Chat_Cucaracha.Util.Dependencias;

namespace Chat_Cucaracha
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .DependenciasViews()
                .DependenciasViewModels();

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ConexionAspNet>();
            return builder.Build();
        }
    }
}
