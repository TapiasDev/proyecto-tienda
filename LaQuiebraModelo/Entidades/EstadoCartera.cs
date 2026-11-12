using System.ComponentModel.DataAnnotations.Schema;

namespace LaQuiebraModelo.Entidades
{
    //Vista Vw_EstadoCartera: une Clientes con Creditos (solo lectura, no tiene clave)
    public class EstadoCartera
    {
        [Column("codigo_cliente")]
        public int CodigoCliente { get; set; }

        [Column("nombre_cliente")]
        public string NombreCliente { get; set; } = string.Empty;

        [Column("id_credito")]
        public int IdCredito { get; set; }

        [Column("monto_inicial", TypeName = "decimal(12,2)")]
        public decimal MontoInicial { get; set; }

        [Column("saldo_actual", TypeName = "decimal(12,2)")]
        public decimal SaldoActual { get; set; }

        [Column("estado_credito")]
        public string? EstadoCredito { get; set; }
    }
}
