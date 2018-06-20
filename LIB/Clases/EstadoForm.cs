namespace LIB.Clases
{
    /// <summary>
    /// Estado del Formulario
    /// </summary>
    public class EstadoForm
    {
        /// <summary>
        /// Disponibilidad del formulario
        /// </summary>
        /// <param name="Form">
        /// Requiere un Formulario
        /// </param>
        /// <returns>
        /// True sino es null, sino no fue eliminado
        /// Y false si es null, si fue eliminado
        /// </returns>
        public System.Boolean Disponible
            (System.Windows.Forms.Form Form) {

            if(Form != null) {
                if(!Form.IsDisposed) {
                    return true;
                }
                else return false;
            }else return false;
        }
        public System.Boolean StateWindows(System.Windows.Forms.Form Form) {
            if(Form.Size == System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size)
                return true;
            else return false;
        }
    }
}