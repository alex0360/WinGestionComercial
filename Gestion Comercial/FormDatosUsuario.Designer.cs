namespace Gestion_Comercial
{
    partial class FormDatosUsuario
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
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(430, 5);
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(13, 0);
            this.PTitulo.Size = new System.Drawing.Size(483, 57);
            // 
            // FormDatosUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.ClientSize = new System.Drawing.Size(509, 499);
            this.Name = "FormDatosUsuario";
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
