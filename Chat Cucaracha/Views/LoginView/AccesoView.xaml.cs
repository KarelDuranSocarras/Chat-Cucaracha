using Chat_Cucaracha.ViewModels;

namespace Chat_Cucaracha.Views.LoginView;

public partial class AccesoView : ContentPage
{
    public AccesoView(LoginViewModel loginViewModel)
	{
        InitializeComponent();
        this.BindingContext = loginViewModel;
	}
}