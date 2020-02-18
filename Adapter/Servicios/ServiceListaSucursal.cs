using Adapter.Entidades.Interfaces;
using Adapter.Servicios.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Adapter.Servicios
{
    public class ServiceListaSucursal : IServiceSucursalConcret
    {
        protected IServiceSucursal _serviceSucursal;

        public ServiceListaSucursal(IServiceSucursal serviceSucursal)
        {
            _serviceSucursal = serviceSucursal;
        }

        public List<ISucursal> ObtenerSucursalesOxxo()
        {
            IEnumerable<ISucursal> sucursalesOxxo = _serviceSucursal.ObtenerSucursales().Where(x => x.Nombre == "Oxxo");

            return sucursalesOxxo.ToList();
        }
    }
}
