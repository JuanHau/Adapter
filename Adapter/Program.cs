using Adapter.Entidades.Interfaces;
using Adapter.Servicios;
using System;
using System.Collections.Generic;

namespace Adapter
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ServiceSucursal serviceSucursal = new ServiceSucursal();
            ServiceSucursalJson serviceSucursalJson = new ServiceSucursalJson();

            ServiceListaSucursal serviceListaSucursal = new ServiceListaSucursal(serviceSucursal);

            Imprimir(serviceListaSucursal.ObtenerSucursalesOxxo());

            Servicios.Adapter adapter = new Servicios.Adapter(serviceSucursalJson);
            ServiceJsonSucursal serviceJsonSucursal = new ServiceJsonSucursal(adapter);

            Imprimir(serviceJsonSucursal.ObtenerSucursalesOxxo());

            Console.ReadLine();
        }

        public static void Imprimir(List<ISucursal> sucursales)
        {
            foreach (ISucursal sucursal in sucursales)
            {
                Console.WriteLine(string.Format("La sucursal con nombre {0} vendio {1}", sucursal.Nombre, sucursal.VentaDia));
            }
        }
    }
}
