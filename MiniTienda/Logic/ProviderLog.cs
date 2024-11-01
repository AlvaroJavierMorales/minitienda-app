using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProviderLog
    {
        // Asumiendo que ProviderDat es la clase que contiene los métodos para la gestión de proveedores
        ProviderDat objProv = new ProviderDat();

        // Método para mostrar todos los proveedores
        public DataSet showProviders()
        {
            return objProv.showProviders();
        }

        // Método para mostrar solo el ID y nombre concatenado de los proveedores (DDL)
        public DataSet showProvidersDDL()
        {
            return objProv.showProvidersDDL();
        }

        // Método para guardar un nuevo proveedor
        public bool saveProvider(string nit, string name)
        {
            return objProv.saveProvider(nit, name);
        }

        // Método para actualizar un proveedor
        public bool updateProvider(int id, string nit, string name)
        {
            return objProv.updateProvider(id, nit, name);
        }

        // Método para borrar un proveedor
        public bool deleteProvider(int id)
        {
            return objProv.deleteProvider(id);
        }

    }
}