using Chat_Cucaracha.Models;
using Chat_Cucaracha.Views.PruebasViews;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Chat_Cucaracha.ViewModels
{
    public class ChatViewModel
    {
        #region Propiedades
        public ObservableCollection<Mensaje> mensajes {  get; set; }

        private readonly HubConnection _connection;

        public ICommand TestCommand { get; set; }
        #endregion
        public ChatViewModel()
        {
            mensajes = new ObservableCollection<Mensaje>();
            _connection = new HubConnectionBuilder()
                //.WithUrl("http://192.168.43.111:5069/chat")
                .WithUrl("http://localhost:5050")
                .Build();
            TestCommand = new Command(Hacer);
            for (int i = 0; i < 10; i++)
            {
                mensajes.Add(new Mensaje()
                {
                    enviado = (i%2==0)? true : false,
                    mensaje = "text"+i
                });
            }
        }
        public async void Hacer()
        {
            //await MainThread.InvokeOnMainThreadAsync(async () =>
            //{
                await Shell.Current.GoToAsync("..");
            //});
        }
    }
}
