using Adapter.Entidades;
using Adapter.Entidades.Interfaces;
using Adapter.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Servicios
{
    public class ServiceSucursal : IServiceSucursal
    {
        public List<ISucursal> ObtenerSucursales()
        {
            ISucursal sucursal1 = new Sucursal()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Oxxo",
                VentaDia = 29333.22
            };

            ISucursal sucursal2 = new Sucursal()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Oxxo",
                VentaDia = 28372.76
            };

            ISucursal sucursal3 = new Sucursal()
            {
                Id = Guid.NewGuid().ToString(),
                Nombre = "Oxxo",
                VentaDia = 4747.212
            };

            return new List<ISucursal>() { sucursal1, sucursal2, sucursal3 };
        }
    }
}
