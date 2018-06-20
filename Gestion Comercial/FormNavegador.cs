using System;
using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormNavegador : Gestion_Comercial.FormPadre
    {
        public FormNavegador()
        {
            InitializeComponent();
            posX = Width - TBUrl.Width;
        }

        int posX;
        private void WBNavegador_Load(object sender, EventArgs e) => WBNavegador.Navigate("https://www.google.com.do");

        #region Button Cerrar
        protected override void BCerrar_Click(object sender, EventArgs e) => CompStandar.CerrarForm(this);
        protected override void BCerrar_MouseHover(object sender, EventArgs e) => base.BCerrar_MouseHover(sender, e);
        protected override void BCerrar_MouseLeave(object sender, EventArgs e) => base.BCerrar_MouseLeave(sender, e);
        #endregion       

        // Button Black
        private void BBlack_Click(object sender, EventArgs e) => WBNavegador.GoBack();
        private void BBlack_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BBlack, 2);
        private void BBlack_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BBlack);

        // Button Maximizar
        private void BMzar_Click(object sender, EventArgs e)
        {
            if(!EstadoForm.StateWindows(this)) {
                CompStandar.Maximizar(this);
                BMzar.Text = "m";
                TBUrl.Width = Width - posX;
            }
            else {
                Size = new System.Drawing.Size(1184, 591);
                BMzar.Text = "M";
                TBUrl.Width = Width - posX;
            }
        }
        private void BMzar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BMzar, 2);
        private void BMzar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BMzar);

        // Button Minimizar
        private void BMinim_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        private void BMinim_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BMinim, 2);
        private void BMinim_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BMinim);
        
        // Button Home
        private void BHome_Click(object sender, EventArgs e) => WBNavegador.Navigate("https://www.google.com.do");
        private void BHome_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BHome, 2);
        private void BHome_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BHome);

        protected override void PTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if(!EstadoForm.StateWindows(this)) {
                PTitulo.Cursor = Cursors.SizeAll;
                base.PTitulo_MouseMove(sender, e);
            }
            else PTitulo.Cursor = Cursors.Default;
        }

        private void FormNavegador_FormClosed(object sender, FormClosedEventArgs e) => Dispose();

        private void WBNavegador_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) => TBUrl.Text = WBNavegador.Url.ToString();
    }
}
