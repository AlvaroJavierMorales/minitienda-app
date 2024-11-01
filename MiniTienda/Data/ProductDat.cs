using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class ProductDat
    {
        Persistence objPer = new Persistence();

        // Metodo para mostrar todos los productos
        public DataSet showProducts()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectProducts";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para guardar un nuevo producto
        public bool saveProduct(string code, string description, int amount, decimal price, int fkProvider, int fkCategory)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spInsertProduct", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_code", MySqlDbType.VarChar).Value = code;
                objSelectCmd.Parameters.Add("p_description", MySqlDbType.VarChar).Value = description;
                objSelectCmd.Parameters.Add("p_amount", MySqlDbType.Int32).Value = amount;
                objSelectCmd.Parameters.Add("p_price", MySqlDbType.Decimal).Value = price;
                objSelectCmd.Parameters.Add("p_fkprovider", MySqlDbType.Int32).Value = fkProvider;
                objSelectCmd.Parameters.Add("p_fkcategory", MySqlDbType.Int32).Value = fkCategory;

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

        // Metodo para actualizar un producto
        public bool updateProduct(int id, string code, string description, int amount, decimal price, int fkProvider, int fkCategory)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spUpdateProduct", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = id;
                objSelectCmd.Parameters.Add("p_code", MySqlDbType.VarChar).Value = code;
                objSelectCmd.Parameters.Add("p_description", MySqlDbType.VarChar).Value = description;
                objSelectCmd.Parameters.Add("p_amount", MySqlDbType.Int32).Value = amount;
                objSelectCmd.Parameters.Add("p_price", MySqlDbType.Decimal).Value = price;
                objSelectCmd.Parameters.Add("p_fkprovider", MySqlDbType.Int32).Value = fkProvider;
                objSelectCmd.Parameters.Add("p_fkcategory", MySqlDbType.Int32).Value = fkCategory;

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

        // Metodo para borrar un producto
        public bool deleteProduct(int id)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spDeleteProduct", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = id;

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
