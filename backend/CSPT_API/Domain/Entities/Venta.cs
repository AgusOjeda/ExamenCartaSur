using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Venta
{
    public int IdVenta { get; set; }

    public DateTime? FechaVenta { get; set; }

    public string? DniCliente { get; set; }

    public string? NombreEmpleado { get; set; }

    public string? NombreCliente { get; set; }

    public decimal? ImporteTotal { get; set; }

    public string? DireccionEnvioCliente { get; set; }

    public string? DireccionSucursalVenta { get; set; }

    public string? NombreSucursalVenta { get; set; }

    public string? Producto { get; set; }

    public int? Cantidad { get; set; }
}
