using softplan_testetecnico.Services.TaxaJurosService;
using System;
using Xunit;

namespace softplan_testetecnico.tests
{
    public class TaxaJurosService
    {

        [Fact]
        public void TestaSeRetornoDaTaxaEstaCorreto()
        {
            var service = new Services.TaxaJurosService.TaxaJurosService();

            // Arrange
            double valorEsperado = 0.01;

            // Act
            var result = service.Get();

            // Assert
            Assert.Equal(result, valorEsperado);
            
        }
    }
}
