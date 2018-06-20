namespace Gestion_Comercial
{
    partial class FormNavegador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNavegador));
            this.WBNavegador = new System.Windows.Forms.WebBrowser();
            this.BBlack = new System.Windows.Forms.Button();
            this.BMzar = new System.Windows.Forms.Button();
            this.BMinim = new System.Windows.Forms.Button();
            this.BHome = new System.Windows.Forms.Button();
            this.TBUrl = new System.Windows.Forms.TextBox();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.BCerrar, "BCerrar");
            this.BCerrar.TabStop = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            this.BCerrar.MouseLeave += new System.EventHandler(this.BCerrar_MouseLeave);
            this.BCerrar.MouseHover += new System.EventHandler(this.BCerrar_MouseHover);
            // 
            // PTitulo
            // 
            this.PTitulo.Controls.Add(this.TBUrl);
            this.PTitulo.Controls.Add(this.BMinim);
            this.PTitulo.Controls.Add(this.BMzar);
            this.PTitulo.Controls.Add(this.BHome);
            this.PTitulo.Controls.Add(this.BBlack);
            resources.ApplyResources(this.PTitulo, "PTitulo");
            this.PTitulo.DoubleClick += new System.EventHandler(this.BMzar_Click);
            this.PTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PTitulo_MouseMove);
            this.PTitulo.Controls.SetChildIndex(this.BCerrar, 0);
            this.PTitulo.Controls.SetChildIndex(this.LTitulo, 0);
            this.PTitulo.Controls.SetChildIndex(this.BBlack, 0);
            this.PTitulo.Controls.SetChildIndex(this.BHome, 0);
            this.PTitulo.Controls.SetChildIndex(this.BMzar, 0);
            this.PTitulo.Controls.SetChildIndex(this.BMinim, 0);
            this.PTitulo.Controls.SetChildIndex(this.TBUrl, 0);
            // 
            // LTitulo
            // 
            resources.ApplyResources(this.LTitulo, "LTitulo");
            // 
            // WBNavegador
            // 
            resources.ApplyResources(this.WBNavegador, "WBNavegador");
            this.WBNavegador.Name = "WBNavegador";
            this.WBNavegador.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WBNavegador_DocumentCompleted);
            // 
            // BBlack
            // 
            this.BBlack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBlack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BBlack.FlatAppearance.BorderSize = 0;
            this.BBlack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BBlack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.BBlack, "BBlack");
            this.BBlack.Name = "BBlack";
            this.BBlack.UseVisualStyleBackColor = true;
            this.BBlack.Click += new System.EventHandler(this.BBlack_Click);
            this.BBlack.MouseLeave += new System.EventHandler(this.BBlack_MouseLeave);
            this.BBlack.MouseHover += new System.EventHandler(this.BBlack_MouseHover);
            // 
            // BMzar
            // 
            resources.ApplyResources(this.BMzar, "BMzar");
            this.BMzar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMzar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BMzar.FlatAppearance.BorderSize = 0;
            this.BMzar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.BMzar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BMzar.Name = "BMzar";
            this.BMzar.TabStop = false;
            this.BMzar.UseVisualStyleBackColor = true;
            this.BMzar.Click += new System.EventHandler(this.BMzar_Click);
            this.BMzar.MouseLeave += new System.EventHandler(this.BMzar_MouseLeave);
            this.BMzar.MouseHover += new System.EventHandler(this.BMzar_MouseHover);
            // 
            // BMinim
            // 
            resources.ApplyResources(this.BMinim, "BMinim");
            this.BMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMinim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BMinim.FlatAppearance.BorderSize = 0;
            this.BMinim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BMinim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BMinim.Name = "BMinim";
            this.BMinim.TabStop = false;
            this.BMinim.UseVisualStyleBackColor = true;
            this.BMinim.Click += new System.EventHandler(this.BMinim_Click);
            this.BMinim.MouseLeave += new System.EventHandler(this.BMinim_MouseLeave);
            this.BMinim.MouseHover += new System.EventHandler(this.BMinim_MouseHover);
            // 
            // BHome
            // 
            this.BHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BHome.FlatAppearance.BorderSize = 0;
            this.BHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.BHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.BHome, "BHome");
            this.BHome.Name = "BHome";
            this.BHome.UseVisualStyleBackColor = true;
            this.BHome.Click += new System.EventHandler(this.BHome_Click);
            this.BHome.MouseLeave += new System.EventHandler(this.BHome_MouseLeave);
            this.BHome.MouseHover += new System.EventHandler(this.BHome_MouseHover);
            // 
            // TBUrl
            // 
            resources.ApplyResources(this.TBUrl, "TBUrl");
            this.TBUrl.Name = "TBUrl";
            // 
            // FormNavegador
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.WBNavegador);
            this.Name = "FormNavegador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNavegador_FormClosed);
            this.Load += new System.EventHandler(this.WBNavegador_Load);
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.WBNavegador, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser WBNavegador;
        private System.Windows.Forms.Button BBlack;
        private System.Windows.Forms.Button BMzar;
        private System.Windows.Forms.Button BMinim;
        private System.Windows.Forms.Button BHome;
        private System.Windows.Forms.TextBox TBUrl;
    }
}
