using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormUsuario : FormPadre
    {

        public FormUsuario()
        {
            InitializeComponent();
            base.LTitulo_Cambiar("Crear Usuario");
        }
        #region Button Cerrar
        protected override void BCerrar_Click(object sender, EventArgs e) => CompStandar.CerrarForm(this);
        protected override void BCerrar_MouseHover(object sender, EventArgs e) => base.BCerrar_MouseHover(sender, e);
        protected override void BCerrar_MouseLeave(object sender, EventArgs e) => base.BCerrar_MouseLeave(sender, e);
        #endregion Todos los metodos del boton

        protected override void PTitulo_MouseMove(object sender, MouseEventArgs e) => base.PTitulo_MouseMove(sender, e);
        
        #region Button Cancelar
        protected virtual void BCancelar_Click(object sender, EventArgs e)
        {
            if(TbNombre.Text != string.Empty | TbApellido.Text != string.Empty) {
                if(!Mensaje.MensajeCierre("Si", "No a guardar, Salir?"))
                    Close();
            }
            else Close();
        }
        protected virtual void BCancelar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BCancelar);
        protected virtual void BCancelar_MouseLeave(object sender, EventArgs e) => CompStandar.BorderMouseLeave(BCancelar);
        #endregion

        #region Button Guardar
        protected virtual void BGuardar_Click(object sender, EventArgs e)
        {
            if(TbNombre.Text == string.Empty) {
                LNombre.ForeColor = Color.Red;
                CompStandar.Focus_TextBox(TbNombre);
                return;
            };
            if(TbApellido.Text == string.Empty) {
                LApellido.ForeColor = Color.Red;
                CompStandar.Focus_TextBox(TbApellido);
                return;
            };
            if(CBExperiencia.SelectedItem == null) {
                LExpComercial.ForeColor = Color.Red;
                CompStandar.Focus_ComboBox(CBExperiencia);
                return;
            };
            Enviar(Usuario);
            MessageBox.Show(Usuario.Cargar());
        }
        protected virtual void Enviar(LIB.Clases.Usuario us)
        {
            us.Nombre = TbNombre.Text;
            us.Apellido = TbApellido.Text;
            us.Edad = DTPEdad.Value;

            if(RbHombre.Checked == true)
                us.Genero = true;
            else us.Genero = false;

            if(TbComentario.Lines != null)
                us.Comentario = TbComentario.Lines;

            if(CBExperiencia.SelectedIndex > -1 & CBExperiencia.SelectedItem != null)
                us.Experiencia = CBExperiencia.SelectedItem.ToString();
            Usuario.Guardar();
            CompStandar.ReescribirText_Label(LTitulo, "Guardado",Color.Black);
        }
        protected virtual void BGardar_MouseHover(object sender, EventArgs e) => CompStandar.BorderMouseHover(BGuardar);
        protected async virtual void BGuardar_MouseLeave(object sender, EventArgs e)
        {
            #region Restaura Valores de color
            if(LNombre.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this, LNombre, Color.Black);

            if(LApellido.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this, LApellido, Color.Black);

            if(LExpComercial.ForeColor == Color.Red)
                await CompStandar.ColorLabelAsync(this, LExpComercial, Color.Black);
            #endregion

            CompStandar.BorderMouseLeave(BGuardar);
        }
        #endregion Button Guardar
    }
}
