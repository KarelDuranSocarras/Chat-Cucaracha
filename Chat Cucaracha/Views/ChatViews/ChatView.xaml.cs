using Chat_Cucaracha.Models;
using Chat_Cucaracha.Util.ASP.NET;
using Chat_Cucaracha.ViewModels;
using Microsoft.AspNetCore.SignalR.Client;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Diagnostics;

namespace Chat_Cucaracha.Views.ChatViews;

public partial class ChatView : ContentPage
{
    ObservableCollection<Mensaje> Message { get; set; }
    private readonly HubConnection _connection;

    public ChatView(ChatViewModel chatViewModel)
	{
        Message = new ObservableCollection<Mensaje>();
        InitializeComponent();
        this.BindingContext = chatViewModel;

        //MessagesListView.ItemsSource = Message;
        _connection = new HubConnectionBuilder()
                //.WithUrl("http://152.206.118.65:5000/chat")
                .WithUrl("http://localhost:5050/chat")
                .Build();
        
        //_connection.On<string>("MessageRecived", (message) =>
        //{
        //    Dispatcher.Dispatch(() =>
        //    {
        //        if (!string.IsNullOrEmpty(message))
        //        {

        //            Message.Add(new Mensaje() { mensaje = message });
        //            //chatMessages.Text += $"{Environment.NewLine}{message}";
        //        }
        //    });
        //});
        //Task.Run(() =>
        //{
        //    Dispatcher.Dispatch(async () =>
        //    {
        //        await _connection.StartAsync();
        //    });
        //});
    }
    private async void OnCounterClicked(object sender, EventArgs e)
    {
        //await _connection.InvokeCoreAsync("SendMessage", args: new[]
        //{
        //       myChatMessage.Text
        //});
        
        myChatMessage.Text = string.Empty;
    }
}