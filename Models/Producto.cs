using System;
using System.Collections.Generic;

namespace gtech_adminltev1.Models;

public partial class Producto
{
    public long Id { get; set; }

    public string? NombreP { get; set; }

    public long? Categoria { get; set; }

    public double? Costo { get; set; }

    public double? Precio { get; set; }

    public string? Descripcion { get; set; }

    public byte[]? FechaCompra { get; set; }

    public byte[]? FechaRecepcion { get; set; }

    public long? Cantidad { get; set; }

    public string? Estado { get; set; }

    public virtual Categoria? CategoriaNavigation { get; set; }
}
