using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Gestion_Comercial
{
    public partial class FormLogin : Gestion_Comercial.FormPadre
    {
        public FormLogin()
        {
            InitializeComponent();
            base.LTitulo_Cambiar("Iniciar Sesion");
        }

        System.Data.SQLite.SQLiteConnection Connection;
        public System.Data.SQLite.SQLiteConnection OpenConnection() =>
        Connection = LIB.SQLiteDate.SQLiteConection("SqlDates.s3db", 3);

        Boolean hayRows = false;
        private bool HayRows()
        {
            OpenConnection();
            DataTable dataTable = new DataTable();
            string sql = "select * from TUsuario";

            SQLiteDataAdapter dataAdapter =
                new SQLiteDataAdapter(sql, Connection);

            dataAdapter.Fill(dataTable);
            MessageBox.Show("dataadap: " + dataAdapter +" datatable: "+ dataTable);
            if(dataTable.Rows.Count > 0) {
                Connection.Close(); MessageBox.Show("Inicial" + hayRows); return hayRows= true;
            }
            else {
                Connection.Close(); MessageBox.Show("Inicial" + hayRows); return hayRows = false;
            }
            
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            HayRows();
        }
        
        // Button Iniciar
        bool user = false;
        bool clave = false;
        private void Iniciar() {
            string us;
            string cl;
            
            if(hayRows) {
                DataTable dataTable = new DataTable();
                string sql
                    = "select * from TUsuario where Usuario = ? and Clave = ?";
                OpenConnection();
                SQLiteCommand command =
                    new SQLiteCommand(sql, Connection);
                command.Parameters.Add(new SQLiteParameter("Usuario", TBUser.Text));
                command.Parameters.Add(new SQLiteParameter("Clave", TBUser.Text));

                SQLiteDataAdapter dataAdapter =
                    new SQLiteDataAdapter(command);

                dataAdapter.Fill(dataTable);

                Connection.Close();
                if(TBUser.Text == "admin")
                    user = true;
                else {
                    user = false;
                    LUser.ForeColor = Color.Red;
                    CompStandar.ReescribirText_Label(LTitulo, "Incorrecto", Color.Red);
                }

                if(TBClave.Text == "admin")
                    clave = true;
                else {
                    clave = false;
                    LClave.ForeColor = Color.Red;
                    CompStandar.ReescribirText_Label(LTitulo, "Incorrecto", Color.Red);
                }

                if(user & clave) 
                    Close();
            }
        }

        private void BIniciar_Click(object sender, EventArgs e) => Iniciar();
        private void BIniciar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BIniciar);
        private async void BIniciar_MouseLeave(object sender, EventArgs e)
        {
            if(LUser.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this,LUser,Color.Black,700);
            if(LClave.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this, LClave, Color.Black, 700);
            if(LTitulo.Text != "Iniciar Sesion")
                CompStandar.ReescribirText_Label(LTitulo, "Iniciar Sesion", Color.Black);
            CompStandar.BorderMouseLeave(Button: BIniciar);
        }
        // Button Cancelar
        private void BCancelar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BCancelar);
        private void BCancelar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BCancelar);
        private void BCancelar_Click(object sender, EventArgs e) => Application.Exit();

    }
}
