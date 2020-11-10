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

        [HttpGet("CalculaJuros/{valorInicial}/{meses}")]
        public IActionResult CalculaJuros(double valorInicial, int meses)
        {
            return Ok(_service.CalculoJuros(valorInicial, meses));
        }

        [HttpGet("ShowMeTheCode")]
        public IActionResult ShowMeTheCode()
        {
            return Ok(_service.ShowMeTheCode());
        }
    }
}
