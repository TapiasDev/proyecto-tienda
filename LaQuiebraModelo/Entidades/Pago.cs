using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaQuiebraModelo.Entidades
{
    //Tabla Pagos: cada pago es una cuota de un crédito (id_credito)
    [Table("Pagos")]
    public class Pago
    {
        [Key]
        [Column("id_pago")]
        public int Id { get; set; }

        [Column("id_credito")]
        public int IdCredito { get; set; }

        [Column("valor_cuota", TypeName = "decimal(12,2)")]
        public decimal ValorCuota { get; set; }

        [Column("fecha_pago")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? FechaPago { get; set; }

        [Column("observacion")]
        public string? Observacion { get; set; }
    }
}
