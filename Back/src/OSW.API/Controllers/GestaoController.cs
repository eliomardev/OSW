using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OSW.API.Models;

namespace OSW.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GestaoController : ControllerBase
    {
        public IEnumerable<Gestao> _gestao = new Gestao[]{
            new Gestao() {
                EmbarqueId = 1,
                TipoEmbarque = "Carros",
                Porto = "TVV",
                Navio = "Thousand Sunny",
                QtdTPA = 15,
                DataEmbarque = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.jpg"
            },
            new Gestao() {
                EmbarqueId = 2,
                TipoEmbarque = "Celulose",
                Porto = "Portocel",
                Navio = "Moby Dick",
                QtdTPA = 20,
                DataEmbarque = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "foto1.jpg"
            }
        };
        public GestaoController()
        {
        }

        [HttpGet]
        public IEnumerable<Gestao> Get()
        {
            return _gestao;

        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de um Post";
        }
    }
}
