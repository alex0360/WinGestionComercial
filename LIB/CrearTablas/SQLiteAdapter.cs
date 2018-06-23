using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB.SQLite
{
    public class SQLiteAdapter
    {
        private System.Data.SQLite.Linq.SQLiteProviderFactory sqlQuery;
        private System.Data.SQLite.SQLiteConnection connection;

        public SQLiteAdapter
            (System.Data.SQLite.Linq.SQLiteProviderFactory pSqlQuery, System.Data.SQLite.SQLiteConnection pConnection)
        {
            sqlQuery = pSqlQuery;
            connection = pConnection;
        }

        public System.Data.SQLite.SQLiteDataAdapter Adapter()
        {
            System.Data.SQLite.SQLiteDataAdapter sQ =
                new System.Data.SQLite.SQLiteDataAdapter(sqlQuery.ToString(),connection);
            return sQ;
        }
    }
}
