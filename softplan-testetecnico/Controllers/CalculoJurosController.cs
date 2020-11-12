using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using softplan_testetecnico.Services.CalculoJurosService;

namespace softplan_testetecnico.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculoJurosController : ControllerBase
    {
        private readonly ICalculoJurosService _service;

        public CalculoJurosController(ICalculoJurosService service)
        {
            _service = service;
        }

        /// <summary>
        /// Calculo de Valor Final de Juros
        /// </summary>
        /// <remarks>
        /// Ele espera dois parametros - Valor Inicial e Meses
        /// Valor Inicial - Double
        /// Meses - Int
        /// </remarks>
        /// <response code="200">Valor do calculo retornado</response>
        [HttpGet("CalculaJuros/{valorInicial}/{meses}")]
        public IActionResult CalculaJuros(double valorInicial, int meses)
        {
            return Ok(_service.CalculoJuros(valorInicial, meses));
        }

        /// <summary>
        /// Mostra o código fonte no GitHub
        /// </summary>
        /// <response code="200">Aparece a URL do GitHub</response>
        [HttpGet("ShowMeTheCode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok(_service.ShowMeTheCode());
        }
    }
}
