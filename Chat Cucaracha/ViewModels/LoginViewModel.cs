using System.Windows.Input;

namespace Chat_Cucaracha.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Propiedades
        public Command AccederCommand { get; set; }

        private string? userName;

        public string? UserName
        {
            get { return userName; }

            set {
                if (userName != value)
                {
                    userName = value;
                    OnPropertyChanged();
                    AccederCommand.ChangeCanExecute();
                }
            }
        }
        #endregion

        public LoginViewModel()
        {
            AccederCommand = new Command(Acceder, Validacion);
        }
        public async void Acceder()
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.GoToAsync("UsuariosConectadosView");
            });
            UserName = null;
        }
        private bool Validacion()
        {
            // El botón se habilita solo si el Entry no está vacío
            return !string.IsNullOrEmpty(UserName);
        }
    }
}
