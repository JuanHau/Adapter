using Adapter.Servicios.Interfaces;
using Newtonsoft.Json.Linq;

namespace Adapter.Servicios
{
    public class ServiceSucursalJson : IServiceSucursalJson
    {
        public JObject ObtenerSucursales()
        {
            return JObject.Parse("{'Id':'45584', 'Nombre':'Oxxo', 'VentaDia':'232383.32'}, {'Id':'887653', 'Nombre':'Oxxo', 'VentaDia':'56888.32'}");
        }
    }
}
