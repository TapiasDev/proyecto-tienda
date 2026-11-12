using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaQuiebraModelo.Entidades
{
    //Tabla Creditos: cada crédito pertenece a un cliente (codigo_cliente)
    [Table("Creditos")]
    public class Credito
    {
        [Key]
        [Column("id_credito")]
        public int Id { get; set; }

        [Column("codigo_cliente")]
        public int CodigoCliente { get; set; }

        [Column("monto_inicial", TypeName = "decimal(12,2)")]
        public decimal MontoInicial { get; set; }

        [Column("saldo_actual", TypeName = "decimal(12,2)")]
        public decimal SaldoActual { get; set; }

        //Activo, Cumplido o Anulado
        [Column("estado")]
        public string Estado { get; set; } = "Activo";

        [Column("fecha_otorgamiento", TypeName = "date")]
        public DateTime FechaOtorgamiento { get; set; }
    }
}
