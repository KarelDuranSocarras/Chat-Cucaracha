using Microsoft.AspNetCore.SignalR.Client;

namespace Chat_Cucaracha.Util.ASP.NET
{
    public class ConexionAspNet
    {
        public HubConnection _connection { get; set; }
        //public string url = "http://152.206.118.65:5000/chat";
        public string url = "http://localhost:5001/chat";
        public ConexionAspNet()
        {
            _connection = new HubConnectionBuilder()
                //.WithUrl("http://152.206.118.65:5000/chat")
                .WithUrl(url)
                .Build();
            _connection.StartAsync();
        }
        public ConexionAspNet(string _url)
        {
            url = _url; 
            _connection = new HubConnectionBuilder()
                .WithUrl(url)
                .Build();
            _connection.StartAsync();
        }
        public async Task IniciarConexion()
        {
            await _connection.StartAsync();
        }
    }
}
