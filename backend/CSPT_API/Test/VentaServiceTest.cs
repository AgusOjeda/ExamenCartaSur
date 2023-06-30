using Application.Interfaces;
using Application.Service;
using Domain.DTOs.Response;
using Moq;


namespace Test
{
    public class VentaServiceTest
    {
        private readonly Mock<IVentaQuery> _queryMock;

        public VentaServiceTest()
        {
            _queryMock = new Mock<IVentaQuery>();
        }


        [Fact]
        public async void VentasReporte_ReturnsFechaConMasVentas()
        {
            //Arrange
            var fechaConMasVentas = new DateTime(2023, 06, 28);
            var totalVentas = 3;
            var expected = new FechaConMasVentasResponse(fechaConMasVentas, totalVentas);
            _queryMock.Setup(q => q.ObtenerFechaConMasVentas()).ReturnsAsync(expected);
            var service = new VentaService(_queryMock.Object);
            //Act
            var result = await service.VentasReporte();
            //Assert
            Assert.Equal(expected, result);

        }
    }
}