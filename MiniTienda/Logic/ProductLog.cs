using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Data;

namespace Logic
{
    public class ProductLog
    {
        // Asumiendo que ProductDat es la clase que contiene los métodos para la gestión de productos
        ProductDat objProd = new ProductDat();

        // Método para mostrar todos los productos
        public DataSet showProducts()
        {
            return objProd.showProducts();
        }

        // Método para guardar un nuevo producto
        public bool saveProduct(string code, string description, int amount, decimal price, int fkProvider, int fkCategory)
        {
            return objProd.saveProduct(code, description, amount, price, fkProvider, fkCategory);
        }

        // Método para actualizar un producto
        public bool updateProduct(int id, string code, string description, int amount, decimal price, int fkProvider, int fkCategory)
        {
            return objProd.updateProduct(id, code, description, amount, price, fkProvider, fkCategory);
        }

        // Método para borrar un producto
        public bool deleteProduct(int id)
        {
            return objProd.deleteProduct(id);
        }
    }
}