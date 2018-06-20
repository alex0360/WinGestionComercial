using System;
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
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        #region Button Cerrar
        protected virtual void BCerrar_MouseHover
            (object sender, System.EventArgs e) =>
            CompStandar.BorderMouseHover(BCerrar);
        protected virtual void BCerrar_MouseLeave
            (object sender, System.EventArgs e) =>
            CompStandar.BorderMouseLeave(BCerrar);
        protected virtual void BCerrar_Click
            (object sender, System.EventArgs e) =>
            CompStandar.CerrarForm(this);
        #endregion
        protected  virtual void PTitulo_MouseMove
            (object sender, MouseEventArgs e) =>
            CompStandar.PanelMouseMove(e, this);

        protected virtual void LTitulo_Cambiar(string Titulo="")
        {
            LTitulo.Text = Titulo;
        }
    }
}
