namespace Gestion_Comercial.Clases
{
    public class Conexion
    {
        // recojer la cadena de Coneccion
               
        public static System.Data.SQLite.SQLiteConnection Connection =
            LIB.SQLiteDate.SQLiteConection
            (System.Configuration.ConfigurationManager.AppSettings["ConnectionString"]);

        //SqlDates.s3db
        public void CloseConnction() =>
            Connection.Close();

        ~Conexion()
        {
            if(Conexion.Connection.State != System.Data.ConnectionState.Closed)
                Conexion.Connection.Close();
        }
    }
}
