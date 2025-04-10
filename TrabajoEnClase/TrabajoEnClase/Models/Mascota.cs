using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Mascota
{
    public int Id_Mascota { get; set; }

    [Required]
    public string Nombre { get; set; }

    [Required]
    public string Especie { get; set; }

    public string Raza { get; set; }

    public int Edad { get; set; }

    public decimal Peso { get; set; }

    public DateTime FechaRegistro { get; set; } = DateTime.Now;

    // Relaciones
    [ForeignKey("Propietario")]
    public int PropietarioId { get; set; }
    public virtual Usuario Propietario { get; set; }

    [ForeignKey("UsuarioRegistro")]
    public int UsuarioRegistroId { get; set; }
    public virtual Usuario UsuarioRegistro { get; set; }
}