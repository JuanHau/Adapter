using Adapter.Entidades.Interfaces;
using System.Collections.Generic;

namespace Adapter.Servicios.Interfaces
{
    public interface IServiceSucursal
    {
        List<ISucursal> ObtenerSucursales();
    }
}
