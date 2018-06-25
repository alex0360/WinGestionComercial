using System.Windows.Forms;

namespace Gestion_Comercial
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            Text = "Gestor Comercial " + System.DateTime.Now.ToShortDateString();
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void FormInicio_Load(object sender, System.EventArgs e) => LIdenty.Text = Clases.Data.Login.identy;

        #region Button AcercaDe
        private void AcercaDe()
        {
            FormInfo form =
                new FormInfo();
            form.ShowDialog();
            form.Dispose();
        }
        private void BAcercaDe_Click(object sender, System.EventArgs e) => AcercaDe();
        private void BAcercaDe_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BAcercaDe,1);
        private void BAcercaDe_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BAcercaDe);
        #endregion

        #region Button Cerrar
        private void BMouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BCerrar);
        private void BMouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BCerrar);
        private void BClick(object sender, System.EventArgs e)
        {
            if(!Mensaje.MensajeCierre())
            CompStandar.CerrarApp();
        }
        #endregion

        #region Button Web
        public FormNavegador Web = null;
        private void BWeb_Click(object sender, System.EventArgs e)
        {
            if(!EstadoForm.Disponible(Web)) {
                Web = new FormNavegador();
                Web.Show();
            }
            else {
                if(!EstadoForm.Disponible(Web)) {
                    Web = new FormNavegador();
                }
                else Web.Activate();
            }
        }
        private void BWeb_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BWeb);
        private void BWeb_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BWeb);
        #endregion

        
        private void PTitulo_MouseMove(object sender, MouseEventArgs e) => CompStandar.PanelMouseMove(e,this);

        #region Panel Usuario
        // Button Desabilitar el panel 
        private void BCerrarPanel_Click(object sender, System.EventArgs e) {
            PUsuario.Enabled = false;
            PUsuario.Visible = false;
            SContenedor.Panel1.Enabled = true;
        }
        private void BCerrarPanel_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BCerrarPanel);
        private void BCerrarPanel_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BCerrarPanel);

        // Button habilitar el panel
        private void BCargarUsuario_Click(object sender, System.EventArgs e)
        {
            PUsuario.Enabled = true;
            PUsuario.Visible = true;
            SContenedor.Panel1.Enabled = false;
        }
        private void BCargarUsuario_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BCargarUsuario);
        private void BCargarUsuario_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BCargarUsuario);
        
        #region Button Usuario
        private void BUsuario_Click(object sender, System.EventArgs e)
        {
            FormCliente formUser = new FormCliente();
            formUser.ShowDialog();
            formUser.Dispose();
        }
        private void BUsuario_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BUsuario);
        private void BUsuario_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BUsuario);
        #endregion
        // Button Crear nuevas Cuentas
        private void BNuevoLogin_Click(object sender, System.EventArgs e)
        {
            FormUserLog formUserLog = 
                new FormUserLog();
            formUserLog.ShowDialog();
            formUserLog.Dispose();
        }
        private void BNuevoLogin_MouseHover(object sender, System.EventArgs e) => CompStandar.BorderMouseHover(BNuevoLogin);
        private void BNuevoLogin_MouseLeave(object sender, System.EventArgs e) => CompStandar.BorderMouseLeave(BNuevoLogin);
        #endregion

        
    }
}