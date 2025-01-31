using Chat_Cucaracha.ViewModels;

namespace Chat_Cucaracha.Views.ChatViews;

public partial class UsuariosConectadosView : ContentPage
{
	public UsuariosConectadosView(UsuariosConectadosViewModel usuariosConectadosViewModel)
	{
		InitializeComponent();
		this.BindingContext = usuariosConectadosViewModel;
	}
}