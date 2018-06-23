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
        
      // Button Iniciar

        private void Iniciar()
        {
            var Loggin = new Clases.Data.Login();
            if((TBUser.Text != string.Empty)&&(TBClave.Text != string.Empty))
            Loggin.CargarIdenty(TBUser.Text, TBClave.Text);
            
            if( Loggin.identy != null) {
                Close();
            }
            else {
                LUser.ForeColor = Color.Red;
                CompStandar.ReescribirText_Label(LTitulo, "Incorrecto", Color.Red);
                LClave.ForeColor = Color.Red;
                CompStandar.ReescribirText_Label(LTitulo, "Incorrecto", Color.Red);
            }
        } 
    

        private void BIniciar_Click(object sender, EventArgs e) => Iniciar();
        private void BIniciar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BIniciar);
        private async void BIniciar_MouseLeave(object sender, EventArgs e)
        {
            if(LUser.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this,LUser,Color.Black,700);
            if(LTitulo.Text != "Iniciar Sesion")
                CompStandar.ReescribirText_Label(LTitulo, "Iniciar Sesion", Color.Black);
            if(LClave.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this, LClave, Color.Black, 400);
            CompStandar.BorderMouseLeave(Button: BIniciar);
        }
        // Button Cancelar
        private void BCancelar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BCancelar);
        private void BCancelar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BCancelar);
        private void BCancelar_Click(object sender, EventArgs e) => Application.Exit();
    }
}
