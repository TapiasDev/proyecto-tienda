namespace LaQuiebraModelo.Entidades
{
    //Datos que envía el cliente (escritorio o web) para iniciar sesión
    public class Login
    {
        public string Usuario { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
    }

    //Respuesta del API al iniciar sesión
    public class LoginRespuesta
    {
        public bool Exito { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Rol { get; set; } = string.Empty;
        public string Mensaje { get; set; } = string.Empty;
    }
}
