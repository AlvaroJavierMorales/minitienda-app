using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class UserDat
    {
        Persistence objPer = new Persistence();

        // Metodo para mostrar todos los usuarios
        public DataSet showUsers()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectUsers";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Metodo para mostrar un usuario por su correo
        public DataTable showUserByMail(string email)
        {
            DataTable objData = new DataTable();

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spSelectUsersMail", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_mail", MySqlDbType.VarChar).Value = email;

                using (MySqlDataAdapter objAdapter = new MySqlDataAdapter(objSelectCmd))
                {
                    objAdapter.Fill(objData);
                }
            }
            return objData;
        }

        // Metodo para guardar un nuevo usuario
        public bool saveUser(string email, string password, string salt, string state)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spInsertUsers", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_mail", MySqlDbType.VarChar).Value = email;
                objSelectCmd.Parameters.Add("p_password", MySqlDbType.Text).Value = password;
                objSelectCmd.Parameters.Add("p_salt", MySqlDbType.Text).Value = salt;
                objSelectCmd.Parameters.Add("p_state", MySqlDbType.VarChar).Value = state;

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
        // Método para actualizar un usuario
        public bool updateUser(int id, string email, string password, string salt, string state)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spUpdateUsers", connection))
            {
                objSelectCmd.CommandType = CommandType.StoredProcedure;
                objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = id;
                objSelectCmd.Parameters.Add("p_mail", MySqlDbType.VarChar).Value = email;
                objSelectCmd.Parameters.Add("p_password", MySqlDbType.Text).Value = password;
                objSelectCmd.Parameters.Add("p_salt", MySqlDbType.Text).Value = salt;
                objSelectCmd.Parameters.Add("p_state", MySqlDbType.VarChar).Value = state;

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

        // Método para borrar un usuario
        public bool deleteUser(int id)
        {
            bool executed = false;

            using (var connection = objPer.openConnection())
            using (MySqlCommand objSelectCmd = new MySqlCommand("spDeleteUsers", connection))
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
