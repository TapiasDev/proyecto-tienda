using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaQuiebra.Logica;

namespace LaQuiebra
{
    public partial class FormConsultas : Form
    {
        public FormConsultas()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txInfo.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            if (!rbID.Checked && !rbNom.Checked)
            {
                MessageBox.Show("Seleccione una opcion");
                return;
            }

            try
            {

                DataTable tabla = new DataTable();

                if (rbID.Checked)
                {
                    int Id = Convert.ToInt32(criterio);
                    tabla = Conexion.ConsultarClientePorCodigo(Id);
                }

                else if (rbNom.Checked)
                {
                    tabla = Conexion.ConsultarClientePorNombre(criterio);
                }

                dgvClientes.DataSource = tabla;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros con ese dato");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la consulta: " + ex.ToString());
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txInfo.Clear();
            dgvClientes.DataSource = null;
            rbID.Checked = true;
            rbNom.Checked = false;
        }
    }
}
