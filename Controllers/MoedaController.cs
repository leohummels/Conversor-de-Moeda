
using TradeMoeda.Models;
using Microsoft.AspNetCore.Mvc;


namespace TradeMoeda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoedaController : ControllerBase
    { 
        private static Moeda moeda = new Moeda();
        private static Cambio cambio = new Cambio();

        [HttpPost]
        public Moeda efetuarCambio([FromBody] Moeda bodyPost)
        {
            moeda.name = bodyPost.name;
            moeda.valor = bodyPost.valor;

            return cambio.CambioExecute(moeda);
        }
    }
}
