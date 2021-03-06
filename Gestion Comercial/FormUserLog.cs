﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormUserLog :Gestion_Comercial.FormPadre
    {
        public FormUserLog()
        {
            InitializeComponent();
        }
        // Connection


        #region Base de Datos
        //Muestra los Datos en el DataGridView
        //private Task MostrarDatosAsync() => Task.Run(() => {
        //    DataTable dataTable = new DataTable();
        //    string sql = "select * from TUsuario";

        //    System.Data.SQLite.SQLiteDataAdapter sQ =
        //    new System.Data.SQLite.SQLiteDataAdapter(sql, Clases.Conexion.Connection);

        //    sQ.Fill(dataTable);
        //    DGVUsuario.DataSource = dataTable;
        //    Clases.Conexion.Connection.Close();

        //    return true;
        //});
        private void MostrarDatosAsync() {

            DataTable dataTable = new DataTable();
            string sql = "select * from TUsuario";

            System.Data.SQLite.SQLiteDataAdapter sQ =
            new System.Data.SQLite.SQLiteDataAdapter(sql, Clases.Conexion.Connection);

            sQ.Fill(dataTable);
            DGVUsuario.DataSource = dataTable;
            Clases.Conexion.Connection.Close();
        }
        

        #endregion

        private void FormUserLog_Load(object sender, EventArgs e)
        {
            if(Clases.Conexion.Connection == null) {
                MessageBox.Show("Conexion fallida");
            }
            else {
                MostrarDatosAsync();
            }
        }

        // Button Cerrar
        protected override void BCerrar_Click(object sender, EventArgs e)
        {
            base.BCerrar_Click(sender,e);
        }
        // Button Guardar
        private async void BGuardar_Click(object sender, EventArgs e)
        {
            
            if(!claveConf) {
                ConfirmarClave();    
            }
            else {
                await Clases.DataBase.Insert.InsertAsync(TBUsuario.Text, TBClave.Text);
                MostrarDatosAsync();
                BCancelar_Click(sender, e);
            }
        }
        private void BGuardar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BGuardar);

        bool claveConf = false;
        private void ConfirmarClave() {

            if(PClaveConf.Visible == false) {
                PClaveConf.Location = new Point(12, 149);
                PClaveConf.Visible = true;
                PClaveConf.Enabled = true;
                BGuardar.Enabled = false;
            }
            else 
            if(PClaveConf.Visible == true) {
                PClaveConf.Visible = false;
                PClaveConf.Enabled = false;
                PClaveConf.Location = new Point(2, 1);
                BGuardar.Enabled = true;
            }
        }

        //Button Cancelar
        private void BCancelar_Click(object sender, EventArgs e)
        {
            TBUsuario.Text = "";
            TBClave.Text = "";
            if(LClave.ForeColor != Color.Black)
                CompStandar.ReescribirText_Label(LClave, "Clave:", Color.Black);

            PClaveConf.Visible = true;
            ConfirmarClave();

            TBClave.PasswordChar = '\0';
            BPass_Click(sender, e);
        }

        // Button Pass
        private void BPass_Click(object sender, EventArgs e)
        {
            if(TBClave.PasswordChar == '\0') {
                TBClave.PasswordChar = '*';
                this.BPass.Image = global::Gestion_Comercial.Properties.Resources.ver32;
            }
            else {
                TBClave.PasswordChar = '\0';
                this.BPass.Image = global::Gestion_Comercial.Properties.Resources.ocultar32;
            }
        }

        private void BBien_Click(object sender, EventArgs e)
        {
            ConfirmarClave();
            if(TBClave.Text == TBClaveConf.Text) {
                claveConf = true;
                CompStandar.ReescribirText_Label
                    (LClave, "Clave:", Color.Green);
            }
            else {
                claveConf = false;
                CompStandar.ReescribirText_Label
                    (LClave, "Clave:", Color.Red);
            }
            TBClaveConf.Text = "";
        }
    }
}
