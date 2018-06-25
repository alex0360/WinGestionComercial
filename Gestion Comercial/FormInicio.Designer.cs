namespace Gestion_Comercial
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.SContenedor = new System.Windows.Forms.SplitContainer();
            this.BAcercaDe = new System.Windows.Forms.Button();
            this.BWeb = new System.Windows.Forms.Button();
            this.BCargarUsuario = new System.Windows.Forms.Button();
            this.PUsuario = new System.Windows.Forms.Panel();
            this.BCerrarPanel = new System.Windows.Forms.Button();
            this.BNuevoLogin = new System.Windows.Forms.Button();
            this.BUsuario = new System.Windows.Forms.Button();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.BCerrar = new System.Windows.Forms.Button();
            this.PBInicio = new System.Windows.Forms.PictureBox();
            this.LIdenty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SContenedor)).BeginInit();
            this.SContenedor.Panel1.SuspendLayout();
            this.SContenedor.Panel2.SuspendLayout();
            this.SContenedor.SuspendLayout();
            this.PUsuario.SuspendLayout();
            this.PTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // SContenedor
            // 
            this.SContenedor.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SContenedor, "SContenedor");
            this.SContenedor.Name = "SContenedor";
            // 
            // SContenedor.Panel1
            // 
            this.SContenedor.Panel1.Controls.Add(this.BAcercaDe);
            this.SContenedor.Panel1.Controls.Add(this.BWeb);
            this.SContenedor.Panel1.Controls.Add(this.BCargarUsuario);
            // 
            // SContenedor.Panel2
            // 
            this.SContenedor.Panel2.Controls.Add(this.LIdenty);
            this.SContenedor.Panel2.Controls.Add(this.PUsuario);
            this.SContenedor.Panel2.Controls.Add(this.PTitulo);
            this.SContenedor.Panel2.Controls.Add(this.PBInicio);
            // 
            // BAcercaDe
            // 
            resources.ApplyResources(this.BAcercaDe, "BAcercaDe");
            this.BAcercaDe.BackColor = System.Drawing.Color.Transparent;
            this.BAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.BAcercaDe.FlatAppearance.BorderSize = 0;
            this.BAcercaDe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.BAcercaDe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.BAcercaDe.Name = "BAcercaDe";
            this.BAcercaDe.UseVisualStyleBackColor = false;
            this.BAcercaDe.Click += new System.EventHandler(this.BAcercaDe_Click);
            this.BAcercaDe.MouseLeave += new System.EventHandler(this.BAcercaDe_MouseLeave);
            this.BAcercaDe.MouseHover += new System.EventHandler(this.BAcercaDe_MouseHover);
            // 
            // BWeb
            // 
            resources.ApplyResources(this.BWeb, "BWeb");
            this.BWeb.BackColor = System.Drawing.Color.Transparent;
            this.BWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BWeb.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.BWeb.FlatAppearance.BorderSize = 0;
            this.BWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BWeb.Image = global::Gestion_Comercial.Properties.Resources.busqueda;
            this.BWeb.Name = "BWeb";
            this.BWeb.UseVisualStyleBackColor = false;
            this.BWeb.Click += new System.EventHandler(this.BWeb_Click);
            this.BWeb.MouseLeave += new System.EventHandler(this.BWeb_MouseLeave);
            this.BWeb.MouseHover += new System.EventHandler(this.BWeb_MouseHover);
            // 
            // BCargarUsuario
            // 
            this.BCargarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BCargarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCargarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BCargarUsuario.FlatAppearance.BorderSize = 0;
            this.BCargarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BCargarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            resources.ApplyResources(this.BCargarUsuario, "BCargarUsuario");
            this.BCargarUsuario.Image = global::Gestion_Comercial.Properties.Resources.usuario11;
            this.BCargarUsuario.Name = "BCargarUsuario";
            this.BCargarUsuario.UseVisualStyleBackColor = false;
            this.BCargarUsuario.Click += new System.EventHandler(this.BCargarUsuario_Click);
            this.BCargarUsuario.MouseLeave += new System.EventHandler(this.BCargarUsuario_MouseLeave);
            this.BCargarUsuario.MouseHover += new System.EventHandler(this.BCargarUsuario_MouseHover);
            // 
            // PUsuario
            // 
            this.PUsuario.BackColor = System.Drawing.Color.Transparent;
            this.PUsuario.Controls.Add(this.BCerrarPanel);
            this.PUsuario.Controls.Add(this.BNuevoLogin);
            this.PUsuario.Controls.Add(this.BUsuario);
            resources.ApplyResources(this.PUsuario, "PUsuario");
            this.PUsuario.ForeColor = System.Drawing.Color.Black;
            this.PUsuario.Name = "PUsuario";
            // 
            // BCerrarPanel
            // 
            resources.ApplyResources(this.BCerrarPanel, "BCerrarPanel");
            this.BCerrarPanel.BackColor = System.Drawing.Color.Transparent;
            this.BCerrarPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCerrarPanel.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrarPanel.FlatAppearance.BorderSize = 0;
            this.BCerrarPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrarPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrarPanel.Name = "BCerrarPanel";
            this.BCerrarPanel.UseVisualStyleBackColor = false;
            this.BCerrarPanel.Click += new System.EventHandler(this.BCerrarPanel_Click);
            this.BCerrarPanel.MouseLeave += new System.EventHandler(this.BCerrarPanel_MouseLeave);
            this.BCerrarPanel.MouseHover += new System.EventHandler(this.BCerrarPanel_MouseHover);
            // 
            // BNuevoLogin
            // 
            resources.ApplyResources(this.BNuevoLogin, "BNuevoLogin");
            this.BNuevoLogin.BackColor = System.Drawing.Color.Transparent;
            this.BNuevoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BNuevoLogin.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BNuevoLogin.FlatAppearance.BorderSize = 0;
            this.BNuevoLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BNuevoLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.BNuevoLogin.Image = global::Gestion_Comercial.Properties.Resources.usuario11;
            this.BNuevoLogin.Name = "BNuevoLogin";
            this.BNuevoLogin.UseVisualStyleBackColor = false;
            this.BNuevoLogin.Click += new System.EventHandler(this.BNuevoLogin_Click);
            this.BNuevoLogin.MouseLeave += new System.EventHandler(this.BNuevoLogin_MouseLeave);
            this.BNuevoLogin.MouseHover += new System.EventHandler(this.BNuevoLogin_MouseHover);
            // 
            // BUsuario
            // 
            resources.ApplyResources(this.BUsuario, "BUsuario");
            this.BUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BUsuario.FlatAppearance.BorderSize = 0;
            this.BUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.BUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.BUsuario.Image = global::Gestion_Comercial.Properties.Resources.usuario11;
            this.BUsuario.Name = "BUsuario";
            this.BUsuario.UseVisualStyleBackColor = false;
            this.BUsuario.Click += new System.EventHandler(this.BUsuario_Click);
            this.BUsuario.MouseLeave += new System.EventHandler(this.BUsuario_MouseLeave);
            this.BUsuario.MouseHover += new System.EventHandler(this.BUsuario_MouseHover);
            // 
            // PTitulo
            // 
            resources.ApplyResources(this.PTitulo, "PTitulo");
            this.PTitulo.BackColor = System.Drawing.Color.Transparent;
            this.PTitulo.Controls.Add(this.BCerrar);
            this.PTitulo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.PTitulo.Name = "PTitulo";
            this.PTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PTitulo_MouseMove);
            // 
            // BCerrar
            // 
            resources.ApplyResources(this.BCerrar, "BCerrar");
            this.BCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Name = "BCerrar";
            this.BCerrar.UseVisualStyleBackColor = false;
            this.BCerrar.Click += new System.EventHandler(this.BClick);
            this.BCerrar.MouseLeave += new System.EventHandler(this.BMouseLeave);
            this.BCerrar.MouseHover += new System.EventHandler(this.BMouseHover);
            // 
            // PBInicio
            // 
            this.PBInicio.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.PBInicio, "PBInicio");
            this.PBInicio.Name = "PBInicio";
            this.PBInicio.TabStop = false;
            // 
            // LIdenty
            // 
            resources.ApplyResources(this.LIdenty, "LIdenty");
            this.LIdenty.Name = "LIdenty";
            // 
            // FormInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.SContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "FormInicio";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.SContenedor.Panel1.ResumeLayout(false);
            this.SContenedor.Panel2.ResumeLayout(false);
            this.SContenedor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SContenedor)).EndInit();
            this.SContenedor.ResumeLayout(false);
            this.PUsuario.ResumeLayout(false);
            this.PTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Clases.MensajeConfirmar Mensaje = new Clases.MensajeConfirmar();
        private LIB.Clases.ComportamientoStandar CompStandar = new LIB.Clases.ComportamientoStandar();
        private LIB.Clases.EstadoForm EstadoForm = new LIB.Clases.EstadoForm();
        private System.Windows.Forms.Button BAcercaDe;
        private System.Windows.Forms.Button BUsuario;
        private System.Windows.Forms.SplitContainer SContenedor;
        private System.Windows.Forms.PictureBox PBInicio;
        private System.Windows.Forms.Button BWeb;
        protected System.Windows.Forms.Button BCerrar;
        private System.Windows.Forms.Panel PTitulo;
        private System.Windows.Forms.Button BNuevoLogin;
        private System.Windows.Forms.Button BCargarUsuario;
        private System.Windows.Forms.Panel PUsuario;
        protected System.Windows.Forms.Button BCerrarPanel;
        private System.Windows.Forms.Label LIdenty;
    }
}