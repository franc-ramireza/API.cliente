using Ferremax.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ferremax.API.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class Clientecontroller: ControllerBase
    {
        [HttpGet]
        [Route("Listar")]

        public dynamic ListarCliente()
        {
            List<Cliente> cliente = new List<Cliente>
            {
                new Cliente
                {
                    id = "1",
                    razonSocial = "Ferreteria pepito Lmtada",
                    rut = "121231231",
                    direccion = " avenida vicuña mackenna 4860 , Macul"
                },

                new Cliente
                {
                    id = "2",
                    razonSocial = "Ferreteria don gato Lmtada",
                    rut = "122342341",
                    direccion = "avenida cardenal caro 2140, Loprado"


                },

            };
            return cliente;

        }
    }
}
