using System.Data.Entity;

public class PetCareContext : DbContext
{
    public PetCareContext() : base("PetCareConnection") { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<HistorialMedico> HistorialesMedicos { get; set; }
}