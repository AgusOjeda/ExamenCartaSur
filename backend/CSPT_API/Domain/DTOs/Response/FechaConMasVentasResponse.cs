using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs.Response
{
    public record FechaConMasVentasResponse(DateTime Fecha, int Cantidad);
}
