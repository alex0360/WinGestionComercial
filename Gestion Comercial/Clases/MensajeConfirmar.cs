namespace Gestion_Comercial.Clases
{
    public class MensajeConfirmar
    {
        public  bool MensajeCierre(string text="Abandonar", 
            string pregunta= "Salir de la Aplicacion?")
        {
            FormSalir FormSalir = new FormSalir();

            ((System.Windows.Forms.Button)FormSalir.Controls["BAbandonar"]).Text = text;
            ((System.Windows.Forms.Label)FormSalir.Controls["LPregunta"]).Text = pregunta;

            System.Windows.Forms.DialogResult result = FormSalir.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.Cancel)
                return true;
            else return false;

        }
    }
}
