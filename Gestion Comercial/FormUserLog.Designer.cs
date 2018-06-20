namespace Gestion_Comercial
{
    partial class FormUserLog
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
            this.TBUsuario = new System.Windows.Forms.TextBox();
            this.TBClave = new System.Windows.Forms.TextBox();
            this.LUser = new System.Windows.Forms.Label();
            this.LClave = new System.Windows.Forms.Label();
            this.DGVUsuario = new System.Windows.Forms.DataGridView();
            this.PClaveConf = new System.Windows.Forms.Panel();
            this.LClaveConf = new System.Windows.Forms.Label();
            this.TBClaveConf = new System.Windows.Forms.TextBox();
            this.BBien = new System.Windows.Forms.Button();
            this.BPass = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.PTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).BeginInit();
            this.PClaveConf.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(364, 5);
            this.BCerrar.Size = new System.Drawing.Size(49, 37);
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(2, 2);
            this.PTitulo.Size = new System.Drawing.Size(417, 47);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(3, 9);
            // 
            // TBUsuario
            // 
            this.TBUsuario.Location = new System.Drawing.Point(128, 83);
            this.TBUsuario.Name = "TBUsuario";
            this.TBUsuario.Size = new System.Drawing.Size(170, 34);
            this.TBUsuario.TabIndex = 0;
            // 
            // TBClave
            // 
            this.TBClave.Location = new System.Drawing.Point(128, 149);
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(170, 34);
            this.TBClave.TabIndex = 1;
            // 
            // LUser
            // 
            this.LUser.AutoSize = true;
            this.LUser.Location = new System.Drawing.Point(27, 83);
            this.LUser.Name = "LUser";
            this.LUser.Size = new System.Drawing.Size(89, 28);
            this.LUser.TabIndex = 57;
            this.LUser.Text = "Usuario:";
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Location = new System.Drawing.Point(32, 149);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(68, 28);
            this.LClave.TabIndex = 58;
            this.LClave.Text = "Clave:";
            // 
            // DGVUsuario
            // 
            this.DGVUsuario.AllowUserToDeleteRows = false;
            this.DGVUsuario.AllowUserToOrderColumns = true;
            this.DGVUsuario.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGVUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsuario.Location = new System.Drawing.Point(12, 271);
            this.DGVUsuario.Name = "DGVUsuario";
            this.DGVUsuario.RowTemplate.Height = 24;
            this.DGVUsuario.Size = new System.Drawing.Size(401, 224);
            this.DGVUsuario.TabIndex = 6;
            // 
            // PClaveConf
            // 
            this.PClaveConf.Controls.Add(this.LClaveConf);
            this.PClaveConf.Controls.Add(this.TBClaveConf);
            this.PClaveConf.Controls.Add(this.BBien);
            this.PClaveConf.Enabled = false;
            this.PClaveConf.Location = new System.Drawing.Point(5, 1);
            this.PClaveConf.Name = "PClaveConf";
            this.PClaveConf.Size = new System.Drawing.Size(414, 48);
            this.PClaveConf.TabIndex = 59;
            this.PClaveConf.Visible = false;
            // 
            // LClaveConf
            // 
            this.LClaveConf.AutoSize = true;
            this.LClaveConf.Location = new System.Drawing.Point(3, 9);
            this.LClaveConf.Name = "LClaveConf";
            this.LClaveConf.Size = new System.Drawing.Size(184, 28);
            this.LClaveConf.TabIndex = 58;
            this.LClaveConf.Text = "Confirme la Clave:";
            // 
            // TBClaveConf
            // 
            this.TBClaveConf.Location = new System.Drawing.Point(193, 7);
            this.TBClaveConf.Name = "TBClaveConf";
            this.TBClaveConf.PasswordChar = '*';
            this.TBClaveConf.Size = new System.Drawing.Size(170, 34);
            this.TBClaveConf.TabIndex = 1;
            // 
            // BBien
            // 
            this.BBien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BBien.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BBien.FlatAppearance.BorderSize = 0;
            this.BBien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BBien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BBien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BBien.Image = global::Gestion_Comercial.Properties.Resources.like32;
            this.BBien.Location = new System.Drawing.Point(369, 6);
            this.BBien.Name = "BBien";
            this.BBien.Size = new System.Drawing.Size(38, 34);
            this.BBien.TabIndex = 3;
            this.BBien.UseVisualStyleBackColor = true;
            this.BBien.Click += new System.EventHandler(this.BBien_Click);
            // 
            // BPass
            // 
            this.BPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BPass.FlatAppearance.BorderSize = 0;
            this.BPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BPass.Image = global::Gestion_Comercial.Properties.Resources.ver32;
            this.BPass.Location = new System.Drawing.Point(332, 149);
            this.BPass.Name = "BPass";
            this.BPass.Size = new System.Drawing.Size(38, 34);
            this.BPass.TabIndex = 3;
            this.BPass.UseVisualStyleBackColor = true;
            this.BPass.Click += new System.EventHandler(this.BPass_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BGuardar.FlatAppearance.BorderSize = 0;
            this.BGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.BGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGuardar.Image = global::Gestion_Comercial.Properties.Resources.Guardar;
            this.BGuardar.Location = new System.Drawing.Point(319, 189);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(68, 53);
            this.BGuardar.TabIndex = 5;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Image = global::Gestion_Comercial.Properties.Resources.cerrar;
            this.BCancelar.Location = new System.Drawing.Point(200, 189);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(57, 53);
            this.BCancelar.TabIndex = 4;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // FormUserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(425, 522);
            this.Controls.Add(this.PClaveConf);
            this.Controls.Add(this.DGVUsuario);
            this.Controls.Add(this.BPass);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.LUser);
            this.Controls.Add(this.TBClave);
            this.Controls.Add(this.TBUsuario);
            this.Name = "FormUserLog";
            this.Text = "FormUserLog";
            this.Load += new System.EventHandler(this.FormUserLog_Load);
            this.Controls.SetChildIndex(this.TBUsuario, 0);
            this.Controls.SetChildIndex(this.TBClave, 0);
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.LUser, 0);
            this.Controls.SetChildIndex(this.LClave, 0);
            this.Controls.SetChildIndex(this.BCancelar, 0);
            this.Controls.SetChildIndex(this.BGuardar, 0);
            this.Controls.SetChildIndex(this.BPass, 0);
            this.Controls.SetChildIndex(this.DGVUsuario, 0);
            this.Controls.SetChildIndex(this.PClaveConf, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsuario)).EndInit();
            this.PClaveConf.ResumeLayout(false);
            this.PClaveConf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBUsuario;
        private System.Windows.Forms.TextBox TBClave;
        private System.Windows.Forms.Label LUser;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.DataGridView DGVUsuario;
        private System.Windows.Forms.Button BPass;
        private System.Windows.Forms.Panel PClaveConf;
        private System.Windows.Forms.Label LClaveConf;
        private System.Windows.Forms.TextBox TBClaveConf;
        private System.Windows.Forms.Button BBien;
    }
}