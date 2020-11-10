using Microsoft.Extensions.Options;
using softplan_testetecnico.Config;
using softplan_testetecnico.Services.TaxaJurosService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplan_testetecnico.Services.CalculoJurosService
{
    public class CalculoJurosService : ICalculoJurosService
    {
        private readonly AppConfig _config;

        public CalculoJurosService(IOptions<AppConfig> config)
        {
            _config = config.Value;
        }

        public double CalculoJuros(double valorInicial, int meses)
        {
            try
            {
                double taxaJuros = RetornaTaxaDeJuros();
                double valorFinal = Math.Round(valorInicial * Math.Pow(1 + taxaJuros, meses), 2);

                return valorFinal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string ShowMeTheCode()
        {
            return _config.UrlGitHub;
        }

        private double RetornaTaxaDeJuros()
        {
            var taxaJurosService = new TaxaJurosService.TaxaJurosService();
            return taxaJurosService.Get();
        }
    }
}
