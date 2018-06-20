using System;
using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormSalir : Gestion_Comercial.FormPadre
    {
        public FormSalir()
        {
            InitializeComponent();
            base.LTitulo_Cambiar("");
        }
        #region Button Abandonar
        private void BAbandonar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BAbandonar,1);
        private void BAbandonar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BAbandonar,0);
        #endregion

        #region Button No Abandonar
        private void BCancelar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BCancelar,2);
        private void BCancelar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BCancelar);
        #endregion
        protected override void PTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            base.PTitulo_MouseMove(sender, e);
        }

        protected override void BCerrar_Click(object sender, EventArgs e)
        {
                base.BCerrar_Click(sender, e);
        }

    }
}
