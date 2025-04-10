using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrabajoEnClase.Models
{
    public class TrabajoEnClaseContext : DbContext
    {

	public TrabajoEnClaseContext() : base("DefaultConnection")
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<HistorialMedico> HistorialesMedicos { get; set; }
    }
}