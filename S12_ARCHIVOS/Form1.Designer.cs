namespace S12_ARCHIVOS
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPathActual = new System.Windows.Forms.Button();
            this.labelPathActual = new System.Windows.Forms.Label();
            this.labelPathEscritorio = new System.Windows.Forms.Label();
            this.buttonPathEscritorio = new System.Windows.Forms.Button();
            this.labelPathEscritorioRelativo = new System.Windows.Forms.Label();
            this.labelPathCombinado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPathCombinado);
            this.panel1.Controls.Add(this.labelPathEscritorioRelativo);
            this.panel1.Controls.Add(this.labelPathEscritorio);
            this.panel1.Controls.Add(this.buttonPathEscritorio);
            this.panel1.Controls.Add(this.labelPathActual);
            this.panel1.Controls.Add(this.buttonPathActual);
            this.panel1.Location = new System.Drawing.Point(33, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 322);
            this.panel1.TabIndex = 0;
            // 
            // buttonPathActual
            // 
            this.buttonPathActual.Location = new System.Drawing.Point(15, 43);
            this.buttonPathActual.Name = "buttonPathActual";
            this.buttonPathActual.Size = new System.Drawing.Size(147, 44);
            this.buttonPathActual.TabIndex = 0;
            this.buttonPathActual.Text = "Mostrar Directorio Actual";
            this.buttonPathActual.UseVisualStyleBackColor = true;
            this.buttonPathActual.Click += new System.EventHandler(this.buttonPathActual_Click);
            // 
            // labelPathActual
            // 
            this.labelPathActual.AutoSize = true;
            this.labelPathActual.Location = new System.Drawing.Point(180, 57);
            this.labelPathActual.Name = "labelPathActual";
            this.labelPathActual.Size = new System.Drawing.Size(72, 16);
            this.labelPathActual.TabIndex = 1;
            this.labelPathActual.Text = "path actual";
            // 
            // labelPathEscritorio
            // 
            this.labelPathEscritorio.AutoSize = true;
            this.labelPathEscritorio.Location = new System.Drawing.Point(180, 120);
            this.labelPathEscritorio.Name = "labelPathEscritorio";
            this.labelPathEscritorio.Size = new System.Drawing.Size(91, 16);
            this.labelPathEscritorio.TabIndex = 3;
            this.labelPathEscritorio.Text = "path escritorio";
            // 
            // buttonPathEscritorio
            // 
            this.buttonPathEscritorio.Location = new System.Drawing.Point(15, 120);
            this.buttonPathEscritorio.Name = "buttonPathEscritorio";
            this.buttonPathEscritorio.Size = new System.Drawing.Size(147, 44);
            this.buttonPathEscritorio.TabIndex = 2;
            this.buttonPathEscritorio.Text = "Mostrar Path Escritorio";
            this.buttonPathEscritorio.UseVisualStyleBackColor = true;
            this.buttonPathEscritorio.Click += new System.EventHandler(this.buttonPathEscritorio_Click);
            // 
            // labelPathEscritorioRelativo
            // 
            this.labelPathEscritorioRelativo.AutoSize = true;
            this.labelPathEscritorioRelativo.Location = new System.Drawing.Point(180, 148);
            this.labelPathEscritorioRelativo.Name = "labelPathEscritorioRelativo";
            this.labelPathEscritorioRelativo.Size = new System.Drawing.Size(173, 20);
            this.labelPathEscritorioRelativo.TabIndex = 4;
            this.labelPathEscritorioRelativo.Text = "path relativo escritorio";
            // 
            // labelPathCombinado
            // 
            this.labelPathCombinado.AutoSize = true;
            this.labelPathCombinado.Location = new System.Drawing.Point(180, 184);
            this.labelPathCombinado.Name = "labelPathCombinado";
            this.labelPathCombinado.Size = new System.Drawing.Size(130, 20);
            this.labelPathCombinado.TabIndex = 5;
            this.labelPathCombinado.Text = "path combinado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 380);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPathEscritorio;
        private System.Windows.Forms.Button buttonPathEscritorio;
        private System.Windows.Forms.Label labelPathActual;
        private System.Windows.Forms.Button buttonPathActual;
        private System.Windows.Forms.Label labelPathEscritorioRelativo;
        private System.Windows.Forms.Label labelPathCombinado;
    }
}

