using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Usuario
{
    public int Id_Usuario { get; set; }

    [Required]
    public string NombreUsuario { get; set; }

    [Required]
    public string NombreCompleto { get; set; }

    [Required, EmailAddress]
    public string Correo { get; set; }

    public string Telefono { get; set; }

    [Required]
    public string Contrasena { get; set; }

    [Required]
    public string Rol { get; set; }

    public virtual ICollection<Mascota> MascotasPropietario { get; set; }
    public virtual ICollection<Mascota> MascotasRegistradas { get; set; }
    public virtual ICollection<Cita> CitasVeterinario { get; set; }
}

