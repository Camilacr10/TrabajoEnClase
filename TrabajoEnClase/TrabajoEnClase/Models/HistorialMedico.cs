using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class HistorialMedico
{
    public int Id_Historial_Medico { get; set; }

    public string Diagnostico { get; set; }

    public string Tratamiento { get; set; }

    public string Observaciones { get; set; }

    public DateTime? FechaSeguimiento { get; set; }

    [ForeignKey("Cita")]
    public int CitaId { get; set; }
    public virtual Cita Cita { get; set; }
}