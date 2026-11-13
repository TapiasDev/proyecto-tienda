using LaQuiebra.Logica;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace LaQuiebra
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txUsuario.Text.Trim()) || String.IsNullOrEmpty(txContrasena.Text))
            {
                MessageBox.Show("Debe ingresar toda la informacion.");
                return;
            }

            //Se envía el usuario y la contraseña al API en formato Json
            Usuario objUsuario = new Usuario(txUsuario.Text.Trim(), txContrasena.Text);
            string json = JsonConvert.SerializeObject(objUsuario);
            dynamic respuesta = DBApi.Post(DBApi.urlApi + "Usuarios/login", json);

            if (respuesta == null)
            {
                MessageBox.Show("No se pudo conectar con el API, verifique que se esté ejecutando");
                return;
            }

            if ((bool)respuesta.exito)
            {
                string rol = respuesta.rol.ToString();
                MessageBox.Show(respuesta.mensaje.ToString() + "\nRol: " + rol);
                txUsuario.Clear();
                txContrasena.Clear();
                this.Hide();
                MenuPrincipal objMenu = new MenuPrincipal(rol, this);
                objMenu.Show();
            }
            else
            {
                MessageBox.Show(respuesta.mensaje.ToString());
                txContrasena.Clear();
                txContrasena.Focus();
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
