using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Cita
{
    public int Id_Cita { get; set; }

    [Required]
    public DateTime FechaHora { get; set; }

    public string Motivo { get; set; }

    [Required]
    public string Estado { get; set; } // Pendiente, Realizada, Cancelada

    [ForeignKey("Mascota")]
    public int MascotaId { get; set; }
    public virtual Mascota Mascota { get; set; }

    [ForeignKey("Veterinario")]
    public int VeterinarioId { get; set; }
    public virtual Usuario Veterinario { get; set; }
}