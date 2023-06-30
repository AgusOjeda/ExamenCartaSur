using Application.Interfaces;
using Domain.DTOs.Response;
using Domain.Entities;
using Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Querys
{
    public class VentaQuery : IVentaQuery
    {
        private readonly AppDbContext _context;

        public VentaQuery(AppDbContext context)
        {
            _context = context;
        }

        public async Task<FechaConMasVentasResponse> ObtenerFechaConMasVentas()
        {
            var result = await _context.Ventas
                .GroupBy(v => v.FechaVenta)
                .Select(g => new { FechaVenta = g.Key, TotalVentas = g.Count() })
                .OrderByDescending(g => g.TotalVentas)
                .FirstOrDefaultAsync();

            return new FechaConMasVentasResponse(result.FechaVenta.Value, result.TotalVentas);
        }

        public async Task<List<Venta>> ObtenerTodos()
        {
            return await _context.Ventas.ToListAsync();
        }
    }
}
