namespace LIB
{
    public class SQLiteDate
    {
        public static System.Data.SQLite.SQLiteConnection SQLiteConection
            (System.String Archivo, System.Int16 Version = 3)
        {
            // Data Source = SqlDates.s3db; Version = 3;
            System.String ConnectionString = "Data Source=";
            System.String VersionString = ";Version=";

            var  Connection =
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
