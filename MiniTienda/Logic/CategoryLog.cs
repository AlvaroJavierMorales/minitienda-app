using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CategoryLog
    {
        CategoryDat objCat = new CategoryDat();

        // Método para mostrar todas las Categorías
        public DataSet showCategories()
        {
            return objCat.showCategories();
        }

        // Método para mostrar únicamente el ID y la descripción de las Categorías
        public DataSet showCategoriesDDL()
        {
            return objCat.showCategoriesDDL();
        }

        // Método para guardar una nueva Categoría
        public bool saveCategory(string _description, DateTime _fecha)
        {
            return objCat.saveCategory(_description, _fecha);
        }

        // Método para actualizar una Categoría
        public bool updateCategory(int _idCategory, string _description, DateTime _fecha)
        {
            return objCat.updateCategory(_idCategory, _description, _fecha);
        }

        // Método para borrar una Categoría
        public bool deleteCategory(int _idCategory)
        {
            return objCat.deleteCategory(_idCategory);
        }
    }
}