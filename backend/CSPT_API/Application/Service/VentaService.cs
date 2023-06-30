using Application.Interfaces;
using Domain.DTOs.Response;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class VentaService : IVentaService
    {
        private readonly IVentaQuery _query;

        public VentaService(IVentaQuery query)
        {
            _query = query;
        }

        public async Task<FechaConMasVentasResponse> VentasReporte()
        {
            return await _query.ObtenerFechaConMasVentas();
        }
    }
}
