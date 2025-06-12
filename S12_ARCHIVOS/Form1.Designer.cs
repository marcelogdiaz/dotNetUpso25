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
            this.labelPathCombinado = new System.Windows.Forms.Label();
            this.labelPathEscritorioRelativo = new System.Windows.Forms.Label();
            this.labelPathEscritorio = new System.Windows.Forms.Label();
            this.buttonPathEscritorio = new System.Windows.Forms.Button();
            this.labelPathActual = new System.Windows.Forms.Label();
            this.buttonPathActual = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonCrearDirectorio = new System.Windows.Forms.Button();
            this.textBoxNombreDirectorio = new System.Windows.Forms.TextBox();
            this.labelDirectorio = new System.Windows.Forms.Label();
            this.radioButtonJSON = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.textBoxArchivos = new System.Windows.Forms.TextBox();
            this.buttonArchivos = new System.Windows.Forms.Button();
            this.textBoxContenido = new System.Windows.Forms.TextBox();
            this.buttonMostrarStores = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxArchivos = new System.Windows.Forms.GroupBox();
            this.buttonCrearArchivo = new System.Windows.Forms.Button();
            this.textBoxContenidoArchivo = new System.Windows.Forms.TextBox();
            this.labelContenido = new System.Windows.Forms.Label();
            this.textBoxExtension = new System.Windows.Forms.TextBox();
            this.labelExtension = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombreArchivo = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxContenidoStream = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.labelError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxArchivos.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 218);
            this.panel1.TabIndex = 0;
            // 
            // labelPathCombinado
            // 
            this.labelPathCombinado.AutoSize = true;
            this.labelPathCombinado.Location = new System.Drawing.Point(180, 184);
            this.labelPathCombinado.Name = "labelPathCombinado";
            this.labelPathCombinado.Size = new System.Drawing.Size(104, 16);
            this.labelPathCombinado.TabIndex = 5;
            this.labelPathCombinado.Text = "path combinado";
            // 
            // labelPathEscritorioRelativo
            // 
            this.labelPathEscritorioRelativo.AutoSize = true;
            this.labelPathEscritorioRelativo.Location = new System.Drawing.Point(180, 148);
            this.labelPathEscritorioRelativo.Name = "labelPathEscritorioRelativo";
            this.labelPathEscritorioRelativo.Size = new System.Drawing.Size(138, 16);
            this.labelPathEscritorioRelativo.TabIndex = 4;
            this.labelPathEscritorioRelativo.Text = "path relativo escritorio";
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
            // labelPathActual
            // 
            this.labelPathActual.AutoSize = true;
            this.labelPathActual.Location = new System.Drawing.Point(180, 57);
            this.labelPathActual.Name = "labelPathActual";
            this.labelPathActual.Size = new System.Drawing.Size(72, 16);
            this.labelPathActual.TabIndex = 1;
            this.labelPathActual.Text = "path actual";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonCrearDirectorio);
            this.panel2.Controls.Add(this.textBoxNombreDirectorio);
            this.panel2.Controls.Add(this.labelDirectorio);
            this.panel2.Controls.Add(this.radioButtonJSON);
            this.panel2.Controls.Add(this.radioButtonTXT);
            this.panel2.Controls.Add(this.textBoxArchivos);
            this.panel2.Controls.Add(this.buttonArchivos);
            this.panel2.Controls.Add(this.textBoxContenido);
            this.panel2.Controls.Add(this.buttonMostrarStores);
            this.panel2.Location = new System.Drawing.Point(6, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 335);
            this.panel2.TabIndex = 1;
            // 
            // buttonCrearDirectorio
            // 
            this.buttonCrearDirectorio.Location = new System.Drawing.Point(436, 275);
            this.buttonCrearDirectorio.Name = "buttonCrearDirectorio";
            this.buttonCrearDirectorio.Size = new System.Drawing.Size(124, 37);
            this.buttonCrearDirectorio.TabIndex = 8;
            this.buttonCrearDirectorio.Text = "Crear Directorio";
            this.buttonCrearDirectorio.UseVisualStyleBackColor = true;
            this.buttonCrearDirectorio.Click += new System.EventHandler(this.buttonCrearDirectorio_Click);
            // 
            // textBoxNombreDirectorio
            // 
            this.textBoxNombreDirectorio.Location = new System.Drawing.Point(218, 282);
            this.textBoxNombreDirectorio.Name = "textBoxNombreDirectorio";
            this.textBoxNombreDirectorio.Size = new System.Drawing.Size(164, 22);
            this.textBoxNombreDirectorio.TabIndex = 7;
            // 
            // labelDirectorio
            // 
            this.labelDirectorio.AutoSize = true;
            this.labelDirectorio.Location = new System.Drawing.Point(44, 282);
            this.labelDirectorio.Name = "labelDirectorio";
            this.labelDirectorio.Size = new System.Drawing.Size(142, 16);
            this.labelDirectorio.TabIndex = 6;
            this.labelDirectorio.Text = "Nombre del Directorio:";
            // 
            // radioButtonJSON
            // 
            this.radioButtonJSON.AutoSize = true;
            this.radioButtonJSON.Location = new System.Drawing.Point(37, 240);
            this.radioButtonJSON.Name = "radioButtonJSON";
            this.radioButtonJSON.Size = new System.Drawing.Size(64, 20);
            this.radioButtonJSON.TabIndex = 5;
            this.radioButtonJSON.Text = "JSON";
            this.radioButtonJSON.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Checked = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(37, 214);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(54, 20);
            this.radioButtonTXT.TabIndex = 4;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "TXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // textBoxArchivos
            // 
            this.textBoxArchivos.Location = new System.Drawing.Point(198, 117);
            this.textBoxArchivos.Multiline = true;
            this.textBoxArchivos.Name = "textBoxArchivos";
            this.textBoxArchivos.Size = new System.Drawing.Size(522, 122);
            this.textBoxArchivos.TabIndex = 3;
            // 
            // buttonArchivos
            // 
            this.buttonArchivos.Location = new System.Drawing.Point(37, 117);
            this.buttonArchivos.Name = "buttonArchivos";
            this.buttonArchivos.Size = new System.Drawing.Size(125, 80);
            this.buttonArchivos.TabIndex = 2;
            this.buttonArchivos.Text = "Mostrar Archivos STORES";
            this.buttonArchivos.UseVisualStyleBackColor = true;
            this.buttonArchivos.Click += new System.EventHandler(this.buttonArchivos_Click);
            // 
            // textBoxContenido
            // 
            this.textBoxContenido.Location = new System.Drawing.Point(198, 10);
            this.textBoxContenido.Multiline = true;
            this.textBoxContenido.Name = "textBoxContenido";
            this.textBoxContenido.Size = new System.Drawing.Size(522, 80);
            this.textBoxContenido.TabIndex = 1;
            // 
            // buttonMostrarStores
            // 
            this.buttonMostrarStores.Location = new System.Drawing.Point(37, 10);
            this.buttonMostrarStores.Name = "buttonMostrarStores";
            this.buttonMostrarStores.Size = new System.Drawing.Size(125, 80);
            this.buttonMostrarStores.TabIndex = 0;
            this.buttonMostrarStores.Text = "Mostrar Subdiretorios STORES";
            this.buttonMostrarStores.UseVisualStyleBackColor = true;
            this.buttonMostrarStores.Click += new System.EventHandler(this.buttonMostrarStores_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 573);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(760, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Directorios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxArchivos);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archivos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxArchivos
            // 
            this.groupBoxArchivos.Controls.Add(this.buttonCrearArchivo);
            this.groupBoxArchivos.Controls.Add(this.textBoxContenidoArchivo);
            this.groupBoxArchivos.Controls.Add(this.labelContenido);
            this.groupBoxArchivos.Controls.Add(this.textBoxExtension);
            this.groupBoxArchivos.Controls.Add(this.labelExtension);
            this.groupBoxArchivos.Controls.Add(this.textBoxNombre);
            this.groupBoxArchivos.Controls.Add(this.labelNombreArchivo);
            this.groupBoxArchivos.Location = new System.Drawing.Point(6, 377);
            this.groupBoxArchivos.Name = "groupBoxArchivos";
            this.groupBoxArchivos.Size = new System.Drawing.Size(735, 161);
            this.groupBoxArchivos.TabIndex = 2;
            this.groupBoxArchivos.TabStop = false;
            this.groupBoxArchivos.Text = "ARCHIVOS";
            // 
            // buttonCrearArchivo
            // 
            this.buttonCrearArchivo.Location = new System.Drawing.Point(436, 53);
            this.buttonCrearArchivo.Name = "buttonCrearArchivo";
            this.buttonCrearArchivo.Size = new System.Drawing.Size(181, 44);
            this.buttonCrearArchivo.TabIndex = 6;
            this.buttonCrearArchivo.Text = "Crear Archivo";
            this.buttonCrearArchivo.UseVisualStyleBackColor = true;
            this.buttonCrearArchivo.Click += new System.EventHandler(this.buttonCrearArchivo_Click);
            // 
            // textBoxContenidoArchivo
            // 
            this.textBoxContenidoArchivo.Location = new System.Drawing.Point(158, 105);
            this.textBoxContenidoArchivo.Name = "textBoxContenidoArchivo";
            this.textBoxContenidoArchivo.Size = new System.Drawing.Size(182, 22);
            this.textBoxContenidoArchivo.TabIndex = 5;
            // 
            // labelContenido
            // 
            this.labelContenido.AutoSize = true;
            this.labelContenido.Location = new System.Drawing.Point(33, 107);
            this.labelContenido.Name = "labelContenido";
            this.labelContenido.Size = new System.Drawing.Size(119, 16);
            this.labelContenido.TabIndex = 4;
            this.labelContenido.Text = "Contenido Archivo:";
            // 
            // textBoxExtension
            // 
            this.textBoxExtension.Location = new System.Drawing.Point(158, 64);
            this.textBoxExtension.Name = "textBoxExtension";
            this.textBoxExtension.Size = new System.Drawing.Size(182, 22);
            this.textBoxExtension.TabIndex = 3;
            // 
            // labelExtension
            // 
            this.labelExtension.AutoSize = true;
            this.labelExtension.Location = new System.Drawing.Point(33, 66);
            this.labelExtension.Name = "labelExtension";
            this.labelExtension.Size = new System.Drawing.Size(116, 16);
            this.labelExtension.TabIndex = 2;
            this.labelExtension.Text = "Extension Archivo:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(158, 29);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(182, 22);
            this.textBoxNombre.TabIndex = 1;
            // 
            // labelNombreArchivo
            // 
            this.labelNombreArchivo.AutoSize = true;
            this.labelNombreArchivo.Location = new System.Drawing.Point(33, 31);
            this.labelNombreArchivo.Name = "labelNombreArchivo";
            this.labelNombreArchivo.Size = new System.Drawing.Size(107, 16);
            this.labelNombreArchivo.TabIndex = 0;
            this.labelNombreArchivo.Text = "Nombre Archivo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelError);
            this.tabPage3.Controls.Add(this.treeView1);
            this.tabPage3.Controls.Add(this.textBoxContenidoStream);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(760, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stream";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Leer Stream Selecionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxContenidoStream
            // 
            this.textBoxContenidoStream.Location = new System.Drawing.Point(48, 230);
            this.textBoxContenidoStream.Multiline = true;
            this.textBoxContenidoStream.Name = "textBoxContenidoStream";
            this.textBoxContenidoStream.Size = new System.Drawing.Size(574, 296);
            this.textBoxContenidoStream.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(48, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(285, 200);
            this.treeView1.TabIndex = 3;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(475, 28);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 16);
            this.labelError.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 672);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Directorios y Archivos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxArchivos.ResumeLayout(false);
            this.groupBoxArchivos.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxContenido;
        private System.Windows.Forms.Button buttonMostrarStores;
        private System.Windows.Forms.TextBox textBoxArchivos;
        private System.Windows.Forms.Button buttonArchivos;
        private System.Windows.Forms.RadioButton radioButtonJSON;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Button buttonCrearDirectorio;
        private System.Windows.Forms.TextBox textBoxNombreDirectorio;
        private System.Windows.Forms.Label labelDirectorio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxArchivos;
        private System.Windows.Forms.Button buttonCrearArchivo;
        private System.Windows.Forms.TextBox textBoxContenidoArchivo;
        private System.Windows.Forms.Label labelContenido;
        private System.Windows.Forms.TextBox textBoxExtension;
        private System.Windows.Forms.Label labelExtension;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombreArchivo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxContenidoStream;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label labelError;
    }
}

