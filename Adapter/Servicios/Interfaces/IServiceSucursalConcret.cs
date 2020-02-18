using Adapter.Entidades.Interfaces;
using System.Collections.Generic;

namespace Adapter.Servicios.Interfaces
{
    public interface IServiceSucursalConcret
    {
        List<ISucursal> ObtenerSucursalesOxxo();
    }
}
