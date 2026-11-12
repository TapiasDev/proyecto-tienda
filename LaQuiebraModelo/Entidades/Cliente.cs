using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaQuiebraModelo.Entidades
{
    //Tabla Clientes (los acreedores de la cartera)
    [Table("Clientes")]
    public class Cliente
    {
        //El código lo digita el usuario, no es autoincremental
        [Key]
        [Column("codigo")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Column("telefono")]
        public string? Telefono { get; set; }

        [Column("correo")]
        public string? Correo { get; set; }

        [Column("direccion")]
        public string? Direccion { get; set; }

        [Column("fecha_registro")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? FechaRegistro { get; set; }
    }
}
