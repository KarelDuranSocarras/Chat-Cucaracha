using Chat_Cucaracha.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chat_Cucaracha.ViewModels
{
    public class UsuariosConectadosViewModel : BaseViewModel
    {
        #region Propiedades
        public ICommand AccederChatCommand { get; set; }
        public ObservableCollection<Usuario> usuariosConectados { get; set; }
        public ObservableCollection<Chat> chatsDisponibles { get; set; }
        #endregion
        private Usuario chatSeleccionado;

        public Usuario ChatSeleccionado
        {
            get { return chatSeleccionado; }
            set { 
                if (value != chatSeleccionado)
                {
                    chatSeleccionado = value;
                    OnPropertyChanged();
                }}
        }

        public UsuariosConectadosViewModel()
        {
            chatSeleccionado = new();
            this.AccederChatCommand = new Command<Usuario>(AccederChat);
            usuariosConectados = new ObservableCollection<Usuario>();
            chatsDisponibles = new ObservableCollection<Chat>();

            for (int i = 0; i < 10; i++)
            {
                usuariosConectados.Add(new Usuario()
                {
                    id = i.ToString(),
                    direccionImagen = "th.jpg",
                    nombre = "karel" + i.ToString(),
                    cantidadUsuarios = 11
                });
            }
            for (int i = 0; i < 10; i++)
            {
                chatsDisponibles.Add(new Chat()
                {
                    direccionImagen="th.jpg",
                    horaUltimoMensaje = "0:09",
                    mensajesSinLeer= i,
                    nombreChat = "karel",
                    ultimoMensaje = "karel esta programando"+i                    
                });
            }

        }
        public async void AccederChat(Usuario s)
        {
            ChatSeleccionado = s;
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Shell.Current.GoToAsync("ChatView");
            });
        }
    }
}
