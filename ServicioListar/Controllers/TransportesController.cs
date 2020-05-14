using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ServicioListar.Models;

namespace ServicioListar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Transportes>>> Get()
        {
            var listTrans = GetListTransportes();
            if (listTrans.Count < 0)
                return NotFound();
            return listTrans;
        }
        private List<Transportes> GetListTransportes()
        {

            var listTransportes = new List<Transportes>()
            {
                new Transportes(){Id = 1, Name = "El Rapido", Description = "Empresa de Transporte el Rapido."},
                new Transportes(){Id = 2, Name = "Etuchisa", Description = "Empresa de Transporte los Chinos."},
                new Transportes(){Id = 3, Name = "Evifasa", Description = "Empresa de Transporte Evifasa."},
                new Transportes(){Id = 4, Name = "Etupsa", Description = "Empresa de Transporte Etupsa."},
                new Transportes(){Id = 5, Name = "Chama", Description = "Empresa de Transporte Chama."},
            };
            return listTransportes;
        }
    }
}