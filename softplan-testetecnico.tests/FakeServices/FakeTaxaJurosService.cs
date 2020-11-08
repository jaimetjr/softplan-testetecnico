using softplan_testetecnico.Services.TaxaJurosService;
using System;
using System.Collections.Generic;
using System.Text;

namespace softplan_testetecnico.tests.FakeServices
{
    public class FakeTaxaJurosService : ITaxaJurosService
    {
        public double Get()
        {
            return 0.01;
        }
    }
}
