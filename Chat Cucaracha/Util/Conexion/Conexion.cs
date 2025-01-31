namespace Chat_Cucaracha.Util.Conexion
{
    public static class Conexion
    {
        private static string user = "Username=neider;"; 
        private static string pass = "Password=Gallina*23;"; 
        private static string host = "Host=152.206.118.65;"; 
        private static string port = "Port=5432;"; 
        private static string database = "Database=chat"; 
        public static string conexionString = $"{host}{port}{user}{pass}{database}"; 
    }
}
