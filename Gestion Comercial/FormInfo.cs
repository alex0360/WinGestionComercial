using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormInfo : Gestion_Comercial.FormPadre
    {
        public FormInfo()
        {
            InitializeComponent();
            base.LTitulo_Cambiar("Acerca De...");
            SizeAll();
        }

        private void SizeAll(string text = "Detalles>>", int y = 63, int alto = 131)
        {
            Size = new Size(Size.Width, alto);
            BDetalles.Location = new Point(490, y);
            BDetalles.Text = text;
        }
       
        // Button Detalles
        private void BDetalles_Click(object sender, EventArgs e)
        {
            if(Size.Height == 131 |
                BDetalles.Location.Y == 63 |
                BDetalles.Text == "Detalles>>") {
                SizeAll("Ocultar<<", 170, 229);
                FlatOcultar();
            }
            else {
                SizeAll();
                FlatDetalles();
            }
        }
        private void BDetalles_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BDetalles, 2);
        private void BDetalles_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BDetalles);

        // ReConfig Flat del Button
        private void FlatDetalles()
        {
            BDetalles.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 64);
            BDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 0, 192);
            BDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 255);
        }
        private void FlatOcultar()
        {
            BDetalles.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 64);
            BDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            BDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
        }

        // Button Cerrar
        protected override void BCerrar_Click(object sender, EventArgs e) => CompStandar.CerrarForm(this);
        protected override void BCerrar_MouseHover(object sender, EventArgs e) => base.BCerrar_MouseHover(sender, e);
        protected override void BCerrar_MouseLeave(object sender, EventArgs e) => base.BCerrar_MouseLeave(sender, e);

        // Mover Panel
        protected override void PTitulo_MouseMove(object sender, MouseEventArgs e) => base.PTitulo_MouseMove(sender, e);
    }
}