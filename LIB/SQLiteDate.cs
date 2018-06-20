using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB
{
    public class SQLiteDate
    {
        public static System.Data.SQLite.SQLiteConnection SQLiteConection(String Archivo, Int16 Version = 3)
        {
            System.Data.SQLite.SQLiteConnection Connection;
            System.String ConnectionString = "Data Source=";
            System.String VersionString = ";Version=";

            Connection =
                 new System.Data.SQLite.SQLiteConnection
             (ConnectionString + Archivo + VersionString + Version.ToString() + ";"); 

                try {
                // Conection abierta y Conectada
                    Connection.Open();
                    return Connection;
                } catch{
                    
                    return null;
                }    
        }
    }
}
