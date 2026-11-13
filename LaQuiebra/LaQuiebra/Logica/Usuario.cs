namespace LaQuiebra.Logica
{
    //Datos que se envían al API para iniciar sesión
    public class Usuario
    {
        public string usuario { get; set; }
        public string contrasena { get; set; }

        public Usuario(string usuario, string contrasena)
        {
            this.usuario = usuario;
            this.contrasena = contrasena;
        }
    }
}
