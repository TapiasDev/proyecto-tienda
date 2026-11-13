using LaQuiebra.Logica;
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
    public partial class FormActualizaciones : Form
    {
        public FormActualizaciones()
        {
            InitializeComponent();
        }

        private void btConsulta_Click(object sender, EventArgs e)
        {
            string criterio = txIDConsultar.Text.Trim();

            if (string.IsNullOrEmpty(criterio))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            try
            {
                int codigoCliente = Convert.ToInt32(criterio);
                DataTable tabla = Conexion.ConsultarCreditosPorCliente(codigoCliente);
                dgvCreditos.DataSource = tabla;

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron créditos para este cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la consulta: " + ex.ToString());
            }
        }

        private void btIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txCodigoIngresar.Text.Trim()) || string.IsNullOrEmpty(txMontoIngresar.Text.Trim()))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            try
            {
                int codigoCliente = Convert.ToInt32(txCodigoIngresar.Text.Trim());
                double monto = Convert.ToDouble(txMontoIngresar.Text.Trim());

                int resultado = Conexion.IngresarCredito(codigoCliente, monto, DateTime.Now);

                if (resultado > 0)
                {
                    MessageBox.Show("Crédito ingresado correctamente, " + resultado + " fila alterada");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("No se pudo conectar con la base de datos");
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el crédito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al ingresar el crédito: " + ex.ToString());
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txIDModificar.Text.Trim()) ||
                string.IsNullOrEmpty(txMontoModificar.Text.Trim()) ||
                string.IsNullOrEmpty(txSaldoModificar.Text.Trim()) ||
                string.IsNullOrEmpty(txEstadoModificar.Text.Trim()))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            try
            {
                int idCredito = Convert.ToInt32(txIDModificar.Text.Trim());
                double monto = Convert.ToDouble(txMontoModificar.Text.Trim());
                double saldo = Convert.ToDouble(txSaldoModificar.Text.Trim());
                string estado = txEstadoModificar.Text.Trim();

                int resultado = Conexion.ModificarCredito(idCredito, monto, saldo, estado);

                if (resultado > 0)
                {
                    MessageBox.Show("Crédito modificado correctamente, " + resultado + " fila alterada");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("No se pudo conectar con la base de datos");
                }
                else
                {
                    MessageBox.Show("No se encontró el crédito o el estado no es válido (use: Activo, Cumplido o Anulado)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al modificar el crédito: " + ex.ToString());
            }
        }

        private void btRetirar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txIDRetirar.Text.Trim()))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            try
            {
                int idCredito = Convert.ToInt32(txIDRetirar.Text.Trim());
                int resultado = Conexion.RetirarCreditoCumplido(idCredito);

                if (resultado > 0)
                {
                    MessageBox.Show("Crédito cumplido retirado correctamente, " + resultado + " fila alterada");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("No se pudo conectar con la base de datos");
                }
                else
                {
                    MessageBox.Show("No se pudo retirar: el crédito no existe o su estado aún no es 'Cumplido'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al retirar el crédito: " + ex.ToString());
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txIDConsultar.Clear();
            txCodigoIngresar.Clear();
            txMontoIngresar.Clear();
            txIDModificar.Clear();
            txMontoModificar.Clear();
            txSaldoModificar.Clear();
            txEstadoModificar.Clear();
            txIDRetirar.Clear();
            dgvCreditos.DataSource = null;
            txIDConsultar.Focus();
        }
    }
}
