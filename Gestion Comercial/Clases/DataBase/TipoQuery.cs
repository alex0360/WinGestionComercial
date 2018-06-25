using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Comercial.Clases.DataBase
{
    public class TipoQuery
    {

        public TipoQuery
            (System.String query, System.Data.SQLite.SQLiteConnection connection, TipoComando tipo) {

            if(tipo == TipoComando.Credenciales) {
               Credenciales = Convert.ToInt32(_Credenciales());
            }
            if(tipo == TipoComando.Insert) {
                
            }
            if(tipo == TipoComando.Update) {

            }
            if(tipo == TipoComando.Delete) {

            }
            if(tipo == TipoComando.UpdateEstado) {

            }
        }

        public int Credenciales;
        private System.String _Credenciales()
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
            login.Dispose();

            return Data.Login.identy;
        }

    }
}
