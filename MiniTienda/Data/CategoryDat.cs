using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class CategoryDat
    {
        Persistence objPer = new Persistence();

        // Metodo para mostrar todas las Categorias
        public DataSet showCategories()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectCategory";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para mostrar unicamente el id y la descripcion
        public DataSet showCategoriesDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectCategoryDDL";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para guardar una nueva Categoria
        public bool saveCategory(string _description, DateTime _fecha)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spInsertCategory", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_description", MySqlDbType.VarChar).Value = _description;

                try
                {
                    int row = objSelectCmd.ExecuteNonQuery();
                    executed = (row == 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.ToString());
                }
            }
            return executed;
        }

        // Metodo para actualizar una Categoria
        public bool updateCategory(int _idCategory, string _description, DateTime _fecha)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spUpdateCategory", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = _idCategory;
                objSelectCmd.Parameters.Add("p_description", MySqlDbType.VarChar).Value = _description;

                try
                {
                    int row = objSelectCmd.ExecuteNonQuery();
                    executed = (row == 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.ToString());
                }
            }
            return executed;
        }

        // Metodo para borrar una Categoria
        public bool deleteCategory(int _idCategory)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spDeleteCategory", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = _idCategory;

                try
                {
                    int row = objSelectCmd.ExecuteNonQuery();
                    executed = (row == 1);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error " + e.ToString());
                }
            }
            return executed;
        }
    }
}
