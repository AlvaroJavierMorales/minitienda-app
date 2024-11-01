using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class ProviderDat
    {
        Persistence objPer = new Persistence();

        // Metodo para mostrar todos los proveedores
        public DataSet showProviders()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectProviders";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para mostrar solo el ID y nombre concatenado de los proveedores (DDL)
        public DataSet showProvidersDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectProvidersDDL";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para guardar un nuevo proveedor
        public bool saveProvider(string nit, string name)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spInsertProvider", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_nit", MySqlDbType.VarChar).Value = nit;
                objSelectCmd.Parameters.Add("p_name", MySqlDbType.VarChar).Value = name;

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

        // Metodo para actualizar un proveedor
        public bool updateProvider(int id, string nit, string name)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spUpdateProvider", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = id;
                objSelectCmd.Parameters.Add("p_nit", MySqlDbType.VarChar).Value = nit;
                objSelectCmd.Parameters.Add("p_name", MySqlDbType.VarChar).Value = name;

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

        // Método para borrar un proveedor
        public bool deleteProvider(int id)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spDeleteProvider", connection))
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