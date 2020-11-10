using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace softplan_testetecnico.Services.CalculoJurosService
{
    public interface ICalculoJurosService
    {
        double CalculoJuros(double valorInicial, int meses);
        string ShowMeTheCode();
    }
}
