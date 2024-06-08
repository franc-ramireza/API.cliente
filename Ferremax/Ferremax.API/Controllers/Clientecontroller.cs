using Ferremax.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ferremax.API.Controllers
{
    [ApiController]
    [Route("Cliente")]
    public class Clientecontroller : ControllerBase
    {
        Cliente cliente1 = new Cliente(1, "Ferreteria don gato Lmtada", "122342341", "avenida cardenal caro 2140, Loprado");
        Cliente cliente2 = new Cliente(2, "Ferreteria pepito el constructor Lmtada", "44444", "avenida vicuña mackenna 4860, macul");
        private static IList<Cliente> cliente = new List<Cliente>() { new Cliente(2, "Ferreteria pepito el constructor Lmtada", "44444", "avenida vicuña mackenna 4860, macul"), new Cliente(2, "Ferreteria pepito el constructor Lmtada", "44444", "avenida vicuña mackenna 4860, macul") };
  

        [HttpGet]
        [Route("listar")]
        public dynamic ListarCliente()
        {
       
            return cliente;

        }

        [HttpGet]
        [Route("buscar")]
        public Cliente ListarCliente2(String rut)
        {
            Cliente clienteEncontrado = cliente.FirstOrDefault(x => x.rut == rut);
            return  clienteEncontrado;
        }
      

        [HttpPost]
        [Route("nuevo")]
        public void NuevoCliente([FromBody] Cliente nuevoCliente)
        {

            cliente.Add(nuevoCliente);

        }

        [HttpDelete]
        [Route("borra")]
        public IList<Cliente> borrarCliente([FromBody] String rut)
        {

            cliente.Remove(cliente.FirstOrDefault(x => x.rut == rut));
            return cliente;
        }


        [HttpPut]
        [Route("actualizar")]
        public Cliente actualizarCliente([FromBody] Cliente clienteActualizado)
        {
            Cliente clienteEncontrado = cliente.FirstOrDefault(x => x.rut == clienteActualizado.rut);
            return cliente[cliente.IndexOf(clienteEncontrado)] = clienteActualizado;
        }
        

    }
}
