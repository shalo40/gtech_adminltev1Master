using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace gtech_adminltev1.Models;

public partial class Cliente
{
    public long Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Rut { get; set; }

    public string? Telefono { get; set; }

    public string? CorreoE { get; set; }

    public string? Domicilio { get; set; }

    [DataType(DataType.Date)]
    public DateTime FechaIng { get; set; }  
}
