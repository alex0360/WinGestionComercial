namespace Gestion_Comercial.Clases.Data
{
    public class Login
    {
        public string identy = null;
        public string CargarIdenty(string usuario, string clave)
        {
            var Select = "Select Usuario, fkUsuarioXML from TUsuario Where Usuario = ? AND Clave = ?";

            try {
                //Conexion.Open();
                var cmd = new System.Data.SQLite.SQLiteCommand(Select, Conexion.Connection);

                cmd.Parameters.Add(new System.Data.SQLite.SQLiteParameter("Usuario", usuario));// Forma uno
                cmd.Parameters.AddWithValue("Clave", clave);// Forma dos

                System.Data.SQLite.SQLiteDataAdapter sQLiteDataAdapter =
                    new System.Data.SQLite.SQLiteDataAdapter(cmd);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                sQLiteDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count == 1)
                    return identy = dataTable.Rows[0][1].ToString();// Porque se guarda Usiario y FkUsuario en un arreglo // FKUsuario esta en la posicion 2
                else return null;

            } catch(System.Exception e) {
                System.Windows.Forms.MessageBox.Show(e.Message.ToString());
                return null;
            } finally {Conexion.Connection.Close();}
            
        }
    }

    public class TUsuario {
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int fkUsuarioXML { get; set; }     
    }
}
