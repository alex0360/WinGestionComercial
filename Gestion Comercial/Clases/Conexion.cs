namespace Gestion_Comercial.Clases
{
    public class Conexion
    {
        // recojer la cadena de Coneccion
               
        public static System.Data.SQLite.SQLiteConnection Connection =
            LIB.SQLiteDate.SQLiteConection
            (System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);

        //SqlDates.s3db

        ~Conexion()
        {
            if(Connection.State != System.Data.ConnectionState.Closed)
               Connection.Close();
        }
    }
}
