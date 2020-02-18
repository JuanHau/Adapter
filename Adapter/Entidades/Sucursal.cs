using Adapter.Entidades.Interfaces;

namespace Adapter.Entidades
{
    public class Sucursal : ISucursal
    {
        public double VentaDia { get; set; }
        public string Id { get; set; }
        public string Nombre { get; set; }
    }
}
