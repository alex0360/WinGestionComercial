namespace LIB.Clases
{
    public class ComportamientoStandar
    {
        #region Control
        /// <summary>
        /// Da un size al Border cuando entramos al Boton
        /// </summary>
        /// <param name="Button">Nombre del Boton</param>
        /// <param name="value">Tamaño del border, defecto 1</param>
        public void BorderMouseHover(System.Windows.Forms.Button Button,
            System.UInt16 value = 1) =>
            Button.FlatAppearance.BorderSize = value;
        /// <summary>
        /// Da un size al Border cuando salimos al Boton
        /// </summary>
        /// <param name="Button">Nombre del Boton</param>
        /// <param name="value">Tamaño del border, defecto 0</param>
        public void BorderMouseLeave(System.Windows.Forms.Button Button,
            System.UInt16 value = 0) =>
            Button.FlatAppearance.BorderSize = value;
        /// <summary>
        /// Foco en el TextBox
        /// </summary>
        /// <param name="TextBox">Nombre del TextBox</param>
        public void Focus_TextBox(System.Windows.Forms.TextBox TextBox) =>
            TextBox.Focus();
        /// <summary>
        /// Foco en el ComboBox
        /// </summary>
        /// <param name="ComboBox">Nombre del ComboBox</param>
        public void Focus_ComboBox(System.Windows.Forms.ComboBox ComboBox) =>
            ComboBox.Focus();
        /// <summary>
        /// Reescribe un el Texto de un Label
        /// </summary>
        /// <param name="Label">Nombre del Label</param>
        /// <param name="text">Texto a mostrar</param>
        /// <param name="color">System.Drawing.Color.Nombre del Color</param>
        public void ReescribirText_Label
            (System.Windows.Forms.Label Label, string text, System.Drawing.Color color)
        {
            Label.Text = text;
            Label.ForeColor = color;
        }


        int PosX = 0, PosY = 0;
        /// <summary>
        /// Mueve el Formulario con un Panel
        /// </summary>
        /// <param name="e">Evento Mouse</param>
        /// <param name="Form">Formulario a Mover</param>
        public void PanelMouseMove
            (System.Windows.Forms.MouseEventArgs e, System.Windows.Forms.Form Form)
        {
            if(e.Button != System.Windows.Forms.MouseButtons.Left) {
                PosX = e.X;
                PosY = e.Y;
            }
            else {
                Form.Top = Form.Top + (e.Y - PosY);
                Form.Left = Form.Left + (e.X - PosX);
            }
        }
        #endregion

        #region Color Para los Label
        // Metodo 
        private System.Threading.Tasks.Task VitualHiloAsync
            (System.Windows.Forms.Label Label,
            System.Drawing.Color Color,
            System.UInt16 time) {

            return System.Threading.Tasks.Task.Run(() => {
                System.Threading.Thread.Sleep(time);
                Label.ForeColor = Color;
                return true;
            });
        }
        //Atributo
        /// <summary>
        /// Restablese un color para el label
        /// </summary>
        /// <param name="Form">Nombre del Formulario</param>
        /// <param name="Label">Nombre del Label</param>
        /// <param name="Color">System.Drawing.Color.Nombre del Color</param>
        /// <param name="time">Tiempo que se retraza</param>
        public System.Threading.Tasks.Task ColorLabelAsync
            (System.Windows.Forms.Form Form,
            System.Windows.Forms.Label Label,
            System.Drawing.Color Color,
            System.UInt16 time = 200) =>
            VitualHiloAsync(Label, Color, time);
        #endregion

        /// <summary>
        /// Maximiza una ventana
        /// </summary>
        /// <param name="Form">Nombre de la ventana</param>
        public void Maximizar(System.Windows.Forms.Form Form) {
            Form.Location = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Location;
            Form.Size = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
        }
        /// <summary>
        /// Cierra un Formulario
        /// </summary>
        /// <param name="Form">Nombre del Formulario</param>
        public void CerrarForm(System.Windows.Forms.Form Form) =>
            Form.Close();
        /// <summary>
        /// Cierra la Aplicacion
        /// </summary>
        public void CerrarApp() => 
            System.Windows.Forms.Application.Exit();
    }
}
