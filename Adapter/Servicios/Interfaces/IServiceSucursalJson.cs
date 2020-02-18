using Newtonsoft.Json.Linq;

namespace Adapter.Servicios.Interfaces
{
    public interface IServiceSucursalJson
    {
        JObject ObtenerSucursales();
    }
}
