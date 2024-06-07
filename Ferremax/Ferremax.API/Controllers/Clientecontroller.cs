using Ferremax.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ferremax.API.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class Clientecontroller : ControllerBase
    {

        private static IList<Cliente> cliente = new List<Cliente>();

        [HttpGet]
        [Route("listar")]
        public dynamic ListarCliente()
        {
            Cliente cliente1 = new Cliente(1, "Ferreteria don gato Lmtada", "122342341", "avenida cardenal caro 2140, Loprado");
            Cliente cliente2 = new Cliente(2, "Ferreteria pepito el constructor Lmtada", "121231233", "avenida vicuña mackenna 4860, macul");

            cliente.Add(cliente1);
            cliente.Add(cliente2);
            return cliente;

        }

        [HttpPost]
        [Route("nuevo")]
        public void NuevoCliente([FromBody] Cliente nuevoCliente)
        {

            cliente.Add(nuevoCliente);

        }



    }
}
