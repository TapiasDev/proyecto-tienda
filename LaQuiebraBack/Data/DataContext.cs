using Microsoft.EntityFrameworkCore;
using LaQuiebraModelo.Entidades;

namespace LaQuiebraBack.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Credito> Creditos { get; set; }
    public DbSet<Pago> Pagos { get; set; }
    public DbSet<EstadoCartera> EstadoCartera { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //La vista no tiene clave primaria, solo se consulta
        modelBuilder.Entity<EstadoCartera>().HasNoKey().ToView("Vw_EstadoCartera");

        //La tabla Pagos tiene un trigger que descuenta el saldo del crédito,
        //se le avisa a Entity Framework para que el insert funcione
        modelBuilder.Entity<Pago>().ToTable(tb => tb.HasTrigger("trg_actualizar_saldo_pago"));
    }
}
