namespace S11_Formularios
{
    partial class FormPrincipal
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
            if (disposing && (components != null))
            {
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
            this.buttonTitulo = new System.Windows.Forms.Button();
            this.buttonResetTitulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTitulo
            // 
            this.buttonTitulo.Location = new System.Drawing.Point(122, 123);
            this.buttonTitulo.Name = "buttonTitulo";
            this.buttonTitulo.Size = new System.Drawing.Size(228, 52);
            this.buttonTitulo.TabIndex = 0;
            this.buttonTitulo.Text = "Cambiar titulo";
            this.buttonTitulo.UseVisualStyleBackColor = true;
            this.buttonTitulo.Click += new System.EventHandler(this.buttonTitulo_Click);
            // 
            // buttonResetTitulo
            // 
            this.buttonResetTitulo.Location = new System.Drawing.Point(373, 123);
            this.buttonResetTitulo.Name = "buttonResetTitulo";
            this.buttonResetTitulo.Size = new System.Drawing.Size(237, 52);
            this.buttonResetTitulo.TabIndex = 1;
            this.buttonResetTitulo.Text = "Resetar titulo";
            this.buttonResetTitulo.UseVisualStyleBackColor = true;
            this.buttonResetTitulo.Click += new System.EventHandler(this.buttonResetTitulo_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(781, 324);
            this.Controls.Add(this.buttonResetTitulo);
            this.Controls.Add(this.buttonTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormPrincipal";
            this.Text = "Mi Primer Formulario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTitulo;
        private System.Windows.Forms.Button buttonResetTitulo;
    }
}

