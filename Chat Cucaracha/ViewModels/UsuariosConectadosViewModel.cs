using Chat_Cucaracha.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chat_Cucaracha.ViewModels
{
    public class UsuariosConectadosViewModel : BaseViewModel
    {
        #region Propiedades
        private List<Usuario> _usuariosOriginales;
        public ICommand AccederChatCommand { get; set; }
        //public ICommand BuscarUsuarioCommand => new Command<string>((string query) =>
        //{
        //    UsuariosBuscados = this.BuscarUsuario(query);
        //});

        public ObservableCollection<Usuario> usuariosConectados { get; set; }
        private string? texto;

        public string? Texto
        {
            get { return texto; }
            set { if (texto != value)
                {
                    texto = value;
                    OnPropertyChanged();
                    if (texto != null)
                    {
                        this.BuscarUsuario(texto);
                    }
                }
}
        }

        private ObservableCollection<Usuario> usuariosBuscados;
        public ObservableCollection<Usuario> UsuariosBuscados
        {
            get
            {
                return usuariosBuscados;
            }
            set
            {
                usuariosBuscados = value;
                OnPropertyChanged();
            }
        }
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
            _usuariosOriginales = new();
            chatSeleccionado = new();
            UsuariosBuscados = new ObservableCollection<Usuario>();
            this.AccederChatCommand = new Command<Usuario>(AccederChat);
            //this.BuscarUsuarioCommand = new Command<string>(BuscarUsuario);
            //this.BuscarUsuarioCommand
            usuariosConectados = new ObservableCollection<Usuario>();
            chatsDisponibles = new ObservableCollection<Chat>();

            for (int i = 0; i < 10; i++)
            {
                _usuariosOriginales.Add(new Usuario()
                {
                    id = i.ToString(),
                    direccionImagen = "th.jpg",
                    nombre = "karel" + i.ToString(),
                });
            }
            ActualizarUsuariosConectados(_usuariosOriginales);
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
        //public void BuscarUsuario(string s)
        //{
        //    var karel = usuariosConectados;
        //    var f =  karel.Where(us=> us.nombre.ToLower().Contains(s.ToLower())).ToList();
        //    usuariosConectados.Clear();
        //    foreach (var us in f)
        //    {
        //        usuariosConectados.Add(us);
        //    }
        //}
        public void BuscarUsuario(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                ActualizarUsuariosConectados(_usuariosOriginales);
            }
            else
            {
                var usuariosFiltrados = _usuariosOriginales
                    .Where(us => us.nombre.ToLower().Contains(s.ToLower()))
                    .ToList();

                ActualizarUsuariosConectados(usuariosFiltrados);
            }
        }
        private void ActualizarUsuariosConectados(List<Usuario> usuarios)
        {
            usuariosConectados.Clear();
            foreach (var usuario in usuarios)
            {
                usuariosConectados.Add(usuario);
            }
        }
    }
}
