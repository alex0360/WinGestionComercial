namespace Gestion_Comercial
{
    partial class FormInfo
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
            this.BDetalles = new System.Windows.Forms.Button();
            this.LFechaCreado = new System.Windows.Forms.Label();
            this.LAutor = new System.Windows.Forms.Label();
            this.LApp = new System.Windows.Forms.Label();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(553, 0);
            this.BCerrar.Size = new System.Drawing.Size(49, 42);
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            this.BCerrar.MouseLeave += new System.EventHandler(this.BCerrar_MouseLeave);
            this.BCerrar.MouseHover += new System.EventHandler(this.BCerrar_MouseHover);
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(10, 3);
            this.PTitulo.Size = new System.Drawing.Size(606, 47);
            this.PTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PTitulo_MouseMove);
            // 
            // BDetalles
            // 
            this.BDetalles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BDetalles.FlatAppearance.BorderSize = 0;
            this.BDetalles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BDetalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.BDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDetalles.Location = new System.Drawing.Point(490, 63);
            this.BDetalles.Name = "BDetalles";
            this.BDetalles.Size = new System.Drawing.Size(122, 38);
            this.BDetalles.TabIndex = 53;
            this.BDetalles.Text = "Detalles>>";
            this.BDetalles.UseVisualStyleBackColor = true;
            this.BDetalles.Click += new System.EventHandler(this.BDetalles_Click);
            this.BDetalles.MouseLeave += new System.EventHandler(this.BDetalles_MouseLeave);
            this.BDetalles.MouseHover += new System.EventHandler(this.BDetalles_MouseHover);
            // 
            // LFechaCreado
            // 
            this.LFechaCreado.AutoSize = true;
            this.LFechaCreado.Location = new System.Drawing.Point(13, 181);
            this.LFechaCreado.Name = "LFechaCreado";
            this.LFechaCreado.Size = new System.Drawing.Size(290, 28);
            this.LFechaCreado.TabIndex = 56;
            this.LFechaCreado.Text = "Aplicacion Creada 30/4/2018";
            // 
            // LAutor
            // 
            this.LAutor.AutoSize = true;
            this.LAutor.Location = new System.Drawing.Point(13, 127);
            this.LAutor.Name = "LAutor";
            this.LAutor.Size = new System.Drawing.Size(322, 28);
            this.LAutor.TabIndex = 55;
            this.LAutor.Text = "Productor Realizado por Alex DS";
            // 
            // LApp
            // 
            this.LApp.AutoSize = true;
            this.LApp.Location = new System.Drawing.Point(13, 68);
            this.LApp.Name = "LApp";
            this.LApp.Size = new System.Drawing.Size(370, 28);
            this.LApp.TabIndex = 54;
            this.LApp.Text = "Aplicacion para la Gestion de Clientes";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(623, 229);
            this.Controls.Add(this.LFechaCreado);
            this.Controls.Add(this.LAutor);
            this.Controls.Add(this.LApp);
            this.Controls.Add(this.BDetalles);
            this.Name = "FormInfo";
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.BDetalles, 0);
            this.Controls.SetChildIndex(this.LApp, 0);
            this.Controls.SetChildIndex(this.LAutor, 0);
            this.Controls.SetChildIndex(this.LFechaCreado, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BDetalles;
        private System.Windows.Forms.Label LFechaCreado;
        private System.Windows.Forms.Label LAutor;
        private System.Windows.Forms.Label LApp;
    }
}
