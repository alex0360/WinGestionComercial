namespace Gestion_Comercial
{
    partial class FormPadre
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
            System.ComponentModel.ComponentResourceManager resources = 
                new System.ComponentModel.ComponentResourceManager(typeof(FormPadre));
            this.BCerrar = new System.Windows.Forms.Button();
            this.PTitulo = new System.Windows.Forms.Panel();
            this.LTitulo = new System.Windows.Forms.Label();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // PTitulo
            // 
            this.PTitulo.BackColor = System.Drawing.Color.Transparent;
            this.PTitulo.Controls.Add(this.LTitulo);
            this.PTitulo.Controls.Add(this.BCerrar);
            this.PTitulo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            resources.ApplyResources(this.PTitulo, "PTitulo");
            this.PTitulo.Name = "PTitulo";
            // 
            // LTitulo
            // 
            resources.ApplyResources(this.LTitulo, "LTitulo");
            this.LTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LTitulo.Name = "LTitulo";
            // 
            // FormPadre
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ControlBox = false;
            this.Controls.Add(this.PTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPadre";
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected Clases.MensajeConfirmar Mensaje = new Clases.MensajeConfirmar();
        protected LIB.Clases.ComportamientoStandar CompStandar = new LIB.Clases.ComportamientoStandar();
        protected LIB.Clases.EstadoForm EstadoForm = new LIB.Clases.EstadoForm();
        protected System.Windows.Forms.Button BCerrar;
        protected System.Windows.Forms.Panel PTitulo;
        protected System.Windows.Forms.Label LTitulo;
    }
}