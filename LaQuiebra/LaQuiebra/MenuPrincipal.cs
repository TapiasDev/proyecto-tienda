using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaQuiebra
{
    public partial class MenuPrincipal : Form
    {
        private FormLogin objLogin;
        private bool cerrandoSesion = false;

        public MenuPrincipal(string rol, FormLogin objLogin)
        {
            InitializeComponent();
            this.objLogin = objLogin;
            olNingunoToolStripMenuItem.Text = "Rol: " + rol;

            //El Invitado solo puede consultar, el Administrador puede hacer todo
            if (rol != "Administrador")
            {
                actualizacionToolStripMenuItem.Enabled = false;
                novedadesToolStripMenuItem.Enabled = false;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultas objConsulta = new FormConsultas();
            objConsulta.MdiParent = this;
            objConsulta.Show();
        }

        private void actualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActualizaciones objActualizaciones = new FormActualizaciones();
            objActualizaciones.MdiParent = this;
            objActualizaciones.Show();
        }

        private void novedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovedades objNovedades = new FormNovedades();
            objNovedades.MdiParent = this;
            objNovedades.Show();
        }

        private void cerrarSesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se cierra el menu principal y se abre el formulario de login nuevamente
            cerrandoSesion = true;
            objLogin.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Si se cierra con la X (y no con Cerrar Sesión) se termina la aplicación
            if (!cerrandoSesion)
            {
                Application.Exit();
            }
        }
    }
}
