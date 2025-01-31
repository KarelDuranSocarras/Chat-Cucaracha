namespace Chat_Cucaracha.Models
{
    public class Chat
    {
        public string nombreChat{ get; set; }
        public string direccionImagen{ get; set; }
        public string ultimoMensaje{ get; set; }
        public string horaUltimoMensaje{ get; set; }
        public int mensajesSinLeer{ get; set; }
    }
}
