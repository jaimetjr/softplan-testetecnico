using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using softplan_testetecnico.Services.TaxaJurosService;

namespace softplan_testetecnico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _service;

        public TaxaJurosController(ITaxaJurosService service)
        {
            _service = service;
        }

        /// <summary>
        /// Retorna o Valor de Juros
        /// </summary>
        /// <response code="200">Apenas retorna o valor fixo em código</response>
        [HttpGet]
        public double Get()
        {
            return _service.Get();
        }
    }
}
