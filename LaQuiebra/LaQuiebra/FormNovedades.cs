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
    public partial class FormNovedades : Form
    {
        public FormNovedades()
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

        private void btPagar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txIDCredito.Text.Trim()) || string.IsNullOrEmpty(txValorPago.Text.Trim()))
            {
                MessageBox.Show("No pueden haber campos vacios");
                return;
            }

            try
            {
                int idCredito = Convert.ToInt32(txIDCredito.Text.Trim());
                double valorCuota = Convert.ToDouble(txValorPago.Text.Trim());
                string observacion = txObsPago.Text.Trim();

                if (valorCuota <= 0)
                {
                    MessageBox.Show("El valor del pago debe ser mayor a cero");
                    return;
                }

                int resultado = Conexion.RegistrarPagoCuota(idCredito, valorCuota, observacion);

                if (resultado > 0)
                {
                    MessageBox.Show("Pago registrado correctamente, " + resultado + " fila alterada");
                }
                else if (resultado == 0)
                {
                    MessageBox.Show("No se pudo conectar con la base de datos");
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pago");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al registrar el pago: " + ex.ToString());
            }
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txIDConsultar.Clear();
            txIDCredito.Clear();
            txValorPago.Clear();
            txObsPago.Clear();
            dgvCreditos.DataSource = null;
            txIDConsultar.Focus();
        }
    }
}
