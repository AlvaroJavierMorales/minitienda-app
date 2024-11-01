using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data;
using System.Data;

namespace Logic
{
    public class UserLog
    {
        UserDat objUser = new UserDat();

        // Método para mostrar todos los usuarios
        public DataSet showUsers()
        {
            return objUser.showUsers();
        }

        // Método para mostrar un usuario por su correo
        public DataTable showUserByMail(string email)
        {
            return objUser.showUserByMail(email);
        }

        // Método para guardar un nuevo usuario
        public bool saveUser(string email, string password, string salt, string state)
        {
            return objUser.saveUser(email, password, salt, state);
        }

        // Método para actualizar un usuario
        public bool updateUser(int id, string email, string password, string salt, string state)
        {
            return objUser.updateUser(id, email, password, salt, state);
        }

        // Método para borrar un usuario
        public bool deleteUser(int id)
        {
            return objUser.deleteUser(id);
        }
    }
}
