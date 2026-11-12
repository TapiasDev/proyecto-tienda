namespace LaQuiebraFront.Servicios
{
    //Guarda quién inició sesión y su rol mientras la página esté abierta
    public class Sesion
    {
        public string Usuario { get; private set; } = string.Empty;
        public string Rol { get; private set; } = string.Empty;
        public bool Activa => !string.IsNullOrEmpty(Rol);

        //Avisa al menú y al layout cuando se inicia o se cierra la sesión
        public event Action? Cambio;

        public void Iniciar(string usuario, string rol)
        {
            Usuario = usuario;
            Rol = rol;
            Cambio?.Invoke();
        }

        public void Cerrar()
        {
            Usuario = string.Empty;
            Rol = string.Empty;
            Cambio?.Invoke();
        }
    }
}
