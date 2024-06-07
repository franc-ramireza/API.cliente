
namespace Ferremax.API.Models

{
    public class Cliente
    {
        public int id { get; set; }
        public string razonSocial { get; set; }

        public string rut { get; set; }

        public string direccion { get; set; }


        public Cliente(int id, String razonSocial, String rut, String direccion)
        {
            this.id = id;
            this.razonSocial = razonSocial;
            this.rut = rut;
            this.direccion = direccion;

        }

        public Cliente()
        {
            this.id = new int();
            this.razonSocial = string.Empty;
            this.rut = string.Empty;
            this.direccion = string.Empty;

        }

    }

}