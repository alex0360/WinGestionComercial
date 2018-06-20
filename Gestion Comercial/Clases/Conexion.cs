namespace Gestion_Comercial.Clases
{
    public class Conexion
    {
        public static System.Data.SQLite.SQLiteConnection Connection =
            LIB.SQLiteDate.SQLiteConection("SqlDates.s3db", 3);

        public void CloseConnction() =>
            Connection.Close();
    }
}
