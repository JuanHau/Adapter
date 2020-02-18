using Adapter.Entidades.Interfaces;
using Adapter.Servicios.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Adapter.Servicios
{
    public class ServiceJsonSucursal : IServiceSucursalConcret
    {
        protected IAdapter _adapter;

        public ServiceJsonSucursal(IAdapter adapter)
        {
            _adapter = adapter;
        }

        public List<ISucursal> ObtenerSucursalesOxxo()
        {
            IEnumerable<ISucursal> sucursales = _adapter.ObtenerSucursalesOxxo().Where(x => x.Nombre == "Oxxo");

            return sucursales.ToList();
        }
    }
}
