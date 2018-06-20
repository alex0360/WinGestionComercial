namespace Gestion_Comercial.Clases
{
    public class Conexion
    {
        public System.Data.SQLite.SQLiteConnection Connection;
        public System.Data.SQLite.SQLiteConnection OpenConnection() => 
            Connection = LIB.SQLiteDate.SQLiteConection("SqlDates.s3db", 3);

        public void CloseConnction() =>
            Connection.Close();
    }
}
