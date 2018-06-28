using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Comercial.Clases.DataBase
{
    public class TipoQuery
    {
        public int Credenciales { get; } 
        private System.String _Credenciales()
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
            login.Dispose();

            return Data.Login.identy;
        }

        // Insertar Usuario
       
    }
    public class Insert {

        public static Task InsertAsync(string user, string clave) => Task.Run(() => {

            const string sql = "Insert into TUsuario (Usuario, Clave) values (?,?)";

            if(Conexion.Connection.State == System.Data.ConnectionState.Closed)
                Conexion.Connection.Open();

            System.Data.SQLite.SQLiteCommand command =
                new System.Data.SQLite.SQLiteCommand(sql, Clases.Conexion.Connection);
            command.Parameters.Add(new System.Data.SQLite.SQLiteParameter("Usuario", user));
            command.Parameters.Add(new System.Data.SQLite.SQLiteParameter("Clave", clave));
            command.ExecuteNonQuery();

            if(Conexion.Connection.State == System.Data.ConnectionState.Open)
                Conexion.Connection.Close();
            return true;
        });
    }
}
