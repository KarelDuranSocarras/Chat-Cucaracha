using Microsoft.AspNetCore.SignalR.Client;
using System.Diagnostics;
namespace Chat_Cucaracha
{
    public partial class MainPage : ContentPage
    {
        private readonly HubConnection _connection;
        public MainPage()
        {
            InitializeComponent();
            _connection = new HubConnectionBuilder()
                .WithUrl("http://152.206.118.65:5000/chat")
                //.WithUrl("http://localhost:5069/")
                .Build();

            _connection.On<string>("MessageRecived", (message) =>
            {
                Debug.WriteLine($"\n--------------{message}--------------\n");
                Dispatcher.Dispatch(() =>
                {
                    if (!string.IsNullOrEmpty(message))
                    {
                        chatMessages.Text += $"{Environment.NewLine}{message}";
                    }
                });
            });
            Task.Run(() =>
            {
                Dispatcher.Dispatch(async () =>
                {
                    await _connection.StartAsync();
                });
            });
        }

        
    }

}
