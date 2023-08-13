using System;
using System.Collections.Generic;

namespace gtech_adminltev1.Models;

public partial class Categoria
{
    public long Id { get; set; }

    public string? NombreCat { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
