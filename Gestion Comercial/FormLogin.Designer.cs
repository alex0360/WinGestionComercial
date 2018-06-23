namespace Gestion_Comercial
{
    partial class FormLogin
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
            this.BIniciar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.TBUser = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.LClave = new System.Windows.Forms.Label();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(384, 0);
            this.BCerrar.Size = new System.Drawing.Size(26, 31);
            this.BCerrar.Visible = false;
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(2, 2);
            this.PTitulo.Size = new System.Drawing.Size(414, 36);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(3, 5);
            // 
            // BIniciar
            // 
            this.BIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BIniciar.FlatAppearance.BorderSize = 0;
            this.BIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BIniciar.Location = new System.Drawing.Point(26, 204);
            this.BIniciar.Name = "BIniciar";
            this.BIniciar.Size = new System.Drawing.Size(115, 47);
            this.BIniciar.TabIndex = 1;
            this.BIniciar.Text = "Iniciar";
            this.BIniciar.UseVisualStyleBackColor = true;
            this.BIniciar.Click += new System.EventHandler(this.BIniciar_Click);
            this.BIniciar.Enter += new System.EventHandler(this.BIniciar_MouseHover);
            this.BIniciar.Leave += new System.EventHandler(this.BIniciar_MouseLeave);
            this.BIniciar.MouseLeave += new System.EventHandler(this.BIniciar_MouseLeave);
            this.BIniciar.MouseHover += new System.EventHandler(this.BIniciar_MouseHover);
            // 
            // BCancelar
            // 
            this.BCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Location = new System.Drawing.Point(265, 204);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(114, 47);
            this.BCancelar.TabIndex = 0;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            this.BCancelar.Enter += new System.EventHandler(this.BCancelar_MouseHover);
            this.BCancelar.Leave += new System.EventHandler(this.BCancelar_MouseLeave);
            this.BCancelar.MouseLeave += new System.EventHandler(this.BCancelar_MouseLeave);
            this.BCancelar.MouseHover += new System.EventHandler(this.BCancelar_MouseHover);
            // 
            // TBClave
            // 
            this.TBClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBClave.Location = new System.Drawing.Point(140, 132);
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(239, 34);
            this.TBClave.TabIndex = 3;
            // 
            // TBUser
            // 
            this.TBUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBUser.Location = new System.Drawing.Point(140, 56);
            this.TBUser.Name = "TBUser";
            this.TBUser.Size = new System.Drawing.Size(239, 34);
            this.TBUser.TabIndex = 2;
            // 
            // LUser
            // 
            this.LUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LUser.AutoSize = true;
            this.LUser.Location = new System.Drawing.Point(21, 59);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(89, 28);
            this.LUser.TabIndex = 57;
            this.LUser.Text = "Usuario:";
            // 
            // LClave
            // 
            this.LClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LClave.AutoSize = true;
            this.LClave.Location = new System.Drawing.Point(21, 132);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(68, 28);
            this.LClave.TabIndex = 58;
            this.LClave.Text = "Clave:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.ClientSize = new System.Drawing.Size(421, 303);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.TBUser);
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BIniciar);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.BIniciar, 0);
            this.Controls.SetChildIndex(this.BCancelar, 0);
            this.Controls.SetChildIndex(this.TBClave, 0);
            this.Controls.SetChildIndex(this.TBUser, 0);
            this.Controls.SetChildIndex(this.LUser, 0);
            this.Controls.SetChildIndex(this.LClave, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BIniciar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TBClave;
        private System.Windows.Forms.TextBox TBUser;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LClave;
    }
}
