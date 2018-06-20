namespace Gestion_Comercial
{
    partial class FormSalir
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
            this.LPregunta = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BAbandonar = new System.Windows.Forms.Button();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.Enabled = false;
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(450, 0);
            this.BCerrar.Size = new System.Drawing.Size(45, 47);
            this.BCerrar.TabIndex = 0;
            this.BCerrar.Visible = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(4, 5);
            this.PTitulo.Size = new System.Drawing.Size(503, 53);
            this.PTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PTitulo_MouseMove);
            // 
            // LPregunta
            // 
            this.LPregunta.AutoSize = true;
            this.LPregunta.Location = new System.Drawing.Point(143, 94);
            this.LPregunta.Name = "LPregunta";
            this.LPregunta.Size = new System.Drawing.Size(220, 28);
            this.LPregunta.TabIndex = 56;
            this.LPregunta.Text = "Salir de la Aplicacion?";
            // 
            // BCancelar
            // 
            this.BCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.BCancelar.FlatAppearance.BorderSize = 0;
            this.BCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCancelar.Location = new System.Drawing.Point(285, 166);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(120, 43);
            this.BCancelar.TabIndex = 1;
            this.BCancelar.Tag = "";
            this.BCancelar.Text = "No";
            this.BCancelar.UseVisualStyleBackColor = false;
            this.BCancelar.Enter += new System.EventHandler(this.BCancelar_MouseHover);
            this.BCancelar.Leave += new System.EventHandler(this.BCancelar_MouseLeave);
            this.BCancelar.MouseLeave += new System.EventHandler(this.BCancelar_MouseLeave);
            this.BCancelar.MouseHover += new System.EventHandler(this.BCancelar_MouseHover);
            // 
            // BAbandonar
            // 
            this.BAbandonar.BackColor = System.Drawing.Color.Transparent;
            this.BAbandonar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAbandonar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BAbandonar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BAbandonar.FlatAppearance.BorderSize = 0;
            this.BAbandonar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BAbandonar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BAbandonar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BAbandonar.Location = new System.Drawing.Point(81, 166);
            this.BAbandonar.Name = "BAbandonar";
            this.BAbandonar.Size = new System.Drawing.Size(131, 43);
            this.BAbandonar.TabIndex = 2;
            this.BAbandonar.Tag = "";
            this.BAbandonar.Text = "Abandonar";
            this.BAbandonar.UseVisualStyleBackColor = false;
            this.BAbandonar.Enter += new System.EventHandler(this.BAbandonar_MouseHover);
            this.BAbandonar.Leave += new System.EventHandler(this.BAbandonar_MouseLeave);
            this.BAbandonar.MouseLeave += new System.EventHandler(this.BAbandonar_MouseLeave);
            this.BAbandonar.MouseHover += new System.EventHandler(this.BAbandonar_MouseHover);
            // 
            // FormSalir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.BCancelar;
            this.ClientSize = new System.Drawing.Size(509, 232);
            this.Controls.Add(this.BAbandonar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.LPregunta);
            this.Name = "FormSalir";
            this.Text = "Salir?";
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.LPregunta, 0);
            this.Controls.SetChildIndex(this.BCancelar, 0);
            this.Controls.SetChildIndex(this.BAbandonar, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LPregunta;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BAbandonar;
    }
}
