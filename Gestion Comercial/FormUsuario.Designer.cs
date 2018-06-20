namespace Gestion_Comercial
{
    partial class FormUsuario
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
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.LEdad = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.TbComentario = new System.Windows.Forms.TextBox();
            this.RbHombre = new System.Windows.Forms.RadioButton();
            this.LComentario = new System.Windows.Forms.Label();
            this.RbMujer = new System.Windows.Forms.RadioButton();
            this.CBExperiencia = new System.Windows.Forms.ComboBox();
            this.LExpComercial = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.DTPEdad = new System.Windows.Forms.DateTimePicker();
            this.PTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BCerrar
            // 
            this.BCerrar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BCerrar.FlatAppearance.BorderSize = 0;
            this.BCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BCerrar.Location = new System.Drawing.Point(215, 5);
            this.BCerrar.Size = new System.Drawing.Size(42, 31);
            this.BCerrar.Text = "x";
            this.BCerrar.Visible = false;
            this.BCerrar.Click += new System.EventHandler(this.BCerrar_Click);
            this.BCerrar.MouseLeave += new System.EventHandler(this.BCerrar_MouseLeave);
            this.BCerrar.MouseHover += new System.EventHandler(this.BCerrar_MouseHover);
            // 
            // PTitulo
            // 
            this.PTitulo.Location = new System.Drawing.Point(3, 2);
            this.PTitulo.Size = new System.Drawing.Size(261, 41);
            this.PTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PTitulo_MouseMove);
            // 
            // LTitulo
            // 
            this.LTitulo.Location = new System.Drawing.Point(9, 5);
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(112, 60);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(152, 34);
            this.TbNombre.TabIndex = 0;
            this.TbNombre.Tag = "Primer Nombre";
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(12, 63);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(94, 28);
            this.LNombre.TabIndex = 53;
            this.LNombre.Text = "Nombre:";
            // 
            // TbApellido
            // 
            this.TbApellido.Location = new System.Drawing.Point(112, 100);
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(152, 34);
            this.TbApellido.TabIndex = 1;
            this.TbApellido.Tag = "Primer Apellido";
            // 
            // LEdad
            // 
            this.LEdad.AutoSize = true;
            this.LEdad.Location = new System.Drawing.Point(12, 142);
            this.LEdad.Name = "LEdad";
            this.LEdad.Size = new System.Drawing.Size(63, 28);
            this.LEdad.TabIndex = 55;
            this.LEdad.Text = "Edad:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(12, 103);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(96, 28);
            this.LApellido.TabIndex = 56;
            this.LApellido.Text = "Apellido:";
            // 
            // TbComentario
            // 
            this.TbComentario.Location = new System.Drawing.Point(17, 246);
            this.TbComentario.Multiline = true;
            this.TbComentario.Name = "TbComentario";
            this.TbComentario.Size = new System.Drawing.Size(239, 109);
            this.TbComentario.TabIndex = 6;
            // 
            // RbHombre
            // 
            this.RbHombre.AutoSize = true;
            this.RbHombre.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RbHombre.Checked = true;
            this.RbHombre.Location = new System.Drawing.Point(17, 180);
            this.RbHombre.Name = "RbHombre";
            this.RbHombre.Size = new System.Drawing.Size(109, 32);
            this.RbHombre.TabIndex = 4;
            this.RbHombre.TabStop = true;
            this.RbHombre.Text = "Hombre";
            this.RbHombre.UseVisualStyleBackColor = true;
            // 
            // LComentario
            // 
            this.LComentario.AutoSize = true;
            this.LComentario.Location = new System.Drawing.Point(12, 215);
            this.LComentario.Name = "LComentario";
            this.LComentario.Size = new System.Drawing.Size(127, 28);
            this.LComentario.TabIndex = 61;
            this.LComentario.Text = "Comentario:";
            // 
            // RbMujer
            // 
            this.RbMujer.AutoSize = true;
            this.RbMujer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RbMujer.Location = new System.Drawing.Point(175, 180);
            this.RbMujer.Name = "RbMujer";
            this.RbMujer.Size = new System.Drawing.Size(89, 32);
            this.RbMujer.TabIndex = 5;
            this.RbMujer.TabStop = true;
            this.RbMujer.Text = "Mujer";
            this.RbMujer.UseVisualStyleBackColor = true;
            // 
            // CBExperiencia
            // 
            this.CBExperiencia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.CBExperiencia.FormattingEnabled = true;
            this.CBExperiencia.Items.AddRange(new object[] {
            "Menos de 6 meses",
            "Entre 6 meses y 1 Año",
            "Más de 1 Año",
            "Más de 2 Años",
            "Más de 3 Años"});
            this.CBExperiencia.Location = new System.Drawing.Point(17, 389);
            this.CBExperiencia.Name = "CBExperiencia";
            this.CBExperiencia.Size = new System.Drawing.Size(247, 33);
            this.CBExperiencia.TabIndex = 7;
            this.CBExperiencia.Text = "Seleccione un elemento";
            // 
            // LExpComercial
            // 
            this.LExpComercial.AutoSize = true;
            this.LExpComercial.Location = new System.Drawing.Point(12, 358);
            this.LExpComercial.Name = "LExpComercial";
            this.LExpComercial.Size = new System.Drawing.Size(221, 28);
            this.LExpComercial.TabIndex = 64;
            this.LExpComercial.Text = "Experiencia Comercial";
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
            this.BCancelar.Location = new System.Drawing.Point(151, 440);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(43, 40);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            this.BCancelar.MouseLeave += new System.EventHandler(this.BCerrar_MouseLeave);
            this.BCancelar.MouseHover += new System.EventHandler(this.BCerrar_MouseHover);
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
            this.BGuardar.Location = new System.Drawing.Point(217, 440);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(43, 40);
            this.BGuardar.TabIndex = 9;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            this.BGuardar.MouseLeave += new System.EventHandler(this.BGuardar_MouseLeave);
            this.BGuardar.MouseHover += new System.EventHandler(this.BCerrar_MouseHover);
            // 
            // DTPEdad
            // 
            this.DTPEdad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPEdad.Location = new System.Drawing.Point(112, 140);
            this.DTPEdad.MaxDate = new System.DateTime(2030, 1, 1, 0, 0, 0, 0);
            this.DTPEdad.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.DTPEdad.Name = "DTPEdad";
            this.DTPEdad.Size = new System.Drawing.Size(152, 34);
            this.DTPEdad.TabIndex = 3;
            this.DTPEdad.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(268, 492);
            this.Controls.Add(this.DTPEdad);
            this.Controls.Add(this.TbApellido);
            this.Controls.Add(this.RbHombre);
            this.Controls.Add(this.RbMujer);
            this.Controls.Add(this.TbComentario);
            this.Controls.Add(this.CBExperiencia);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LEdad);
            this.Controls.Add(this.LComentario);
            this.Controls.Add(this.LExpComercial);
            this.Name = "FormUsuario";
            this.Controls.SetChildIndex(this.LExpComercial, 0);
            this.Controls.SetChildIndex(this.LComentario, 0);
            this.Controls.SetChildIndex(this.LEdad, 0);
            this.Controls.SetChildIndex(this.LApellido, 0);
            this.Controls.SetChildIndex(this.TbNombre, 0);
            this.Controls.SetChildIndex(this.LNombre, 0);
            this.Controls.SetChildIndex(this.BCancelar, 0);
            this.Controls.SetChildIndex(this.PTitulo, 0);
            this.Controls.SetChildIndex(this.BGuardar, 0);
            this.Controls.SetChildIndex(this.CBExperiencia, 0);
            this.Controls.SetChildIndex(this.TbComentario, 0);
            this.Controls.SetChildIndex(this.RbMujer, 0);
            this.Controls.SetChildIndex(this.RbHombre, 0);
            this.Controls.SetChildIndex(this.TbApellido, 0);
            this.Controls.SetChildIndex(this.DTPEdad, 0);
            this.PTitulo.ResumeLayout(false);
            this.PTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LIB.Clases.Usuario Usuario = new LIB.Clases.Usuario();
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.Label LEdad;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TbComentario;
        private System.Windows.Forms.RadioButton RbMujer;
        private System.Windows.Forms.RadioButton RbHombre;
        private System.Windows.Forms.Label LComentario;
        private System.Windows.Forms.ComboBox CBExperiencia;
        private System.Windows.Forms.Label LExpComercial;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.DateTimePicker DTPEdad;
    }
}
