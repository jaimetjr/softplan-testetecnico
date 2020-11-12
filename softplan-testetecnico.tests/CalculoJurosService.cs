using System;
using System.Collections.Generic;
using System.Text;
using Xunit;


namespace softplan_testetecnico.tests
{
    public class CalculoJurosService
    {
        [Theory]
        [InlineData(200, 10, 220.92)]
        [InlineData(150, 24, 190.46)]
        [InlineData(350, 36, 500.77)]
        [InlineData(50, 2, 51)]
        public void TestaSeFazOCalculoCorreto(double valorInicial, int meses, double valorEsperado)
        {
            
            var calculoJurosService = new Services.CalculoJurosService.CalculoJurosService(null);
            Assert.Equal(valorEsperado, calculoJurosService.CalculoJuros(valorInicial, meses));
        }
    }
}
