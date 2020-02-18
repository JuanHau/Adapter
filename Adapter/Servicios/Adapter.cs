using Adapter.Entidades;
using Adapter.Entidades.Interfaces;
using Adapter.Servicios.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Adapter.Servicios
{
    public class Adapter : IAdapter
    {
        protected IServiceSucursalJson _serviceSucursalJson;

        public Adapter(IServiceSucursalJson serviceSucursalJson)
        {
            _serviceSucursalJson = serviceSucursalJson;
        }

        public List<ISucursal> ObtenerSucursalesOxxo()
        {
            JObject jObject = _serviceSucursalJson.ObtenerSucursales();

            return new List<ISucursal>() { jObject.ToObject<Sucursal>() };
        }
    }
}
