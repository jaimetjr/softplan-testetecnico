using softplan_testetecnico.Services.TaxaJurosService;
using softplan_testetecnico.tests.FakeServices;
using System;
using Xunit;

namespace softplan_testetecnico.tests
{
    public class TaxaJurosService
    {

        [Fact]
        public void TestaSeRetornoDaTaxaEstaCorreto()
        {
            var fakeService = new FakeTaxaJurosService();

            // Arrange
            double valorEsperado = 0.01;

            // Act
            var result = fakeService.Get();

            // Assert
            Assert.Equal(result, valorEsperado);
            
        }
    }
}
