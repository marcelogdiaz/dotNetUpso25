namespace S11_Formularios
{
    partial class FormJugadoresFutbol
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
            this.components = new System.ComponentModel.Container();
            this.buttonNuevoJugador = new System.Windows.Forms.Button();
            this.buttonResetTitulo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infraccionesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jugadorFutbolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.groupBoxInfoPersonal = new System.Windows.Forms.GroupBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEdad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPosicion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jugadorHockeyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorFutbolBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxInfoPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorHockeyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevoJugador
            // 
            this.buttonNuevoJugador.Location = new System.Drawing.Point(121, 260);
            this.buttonNuevoJugador.Name = "buttonNuevoJugador";
            this.buttonNuevoJugador.Size = new System.Drawing.Size(228, 52);
            this.buttonNuevoJugador.TabIndex = 7;
            this.buttonNuevoJugador.Text = "Agregar Jugador";
            this.buttonNuevoJugador.UseVisualStyleBackColor = true;
            this.buttonNuevoJugador.Click += new System.EventHandler(this.buttonTitulo_Click);
            // 
            // buttonResetTitulo
            // 
            this.buttonResetTitulo.Location = new System.Drawing.Point(386, 389);
            this.buttonResetTitulo.Name = "buttonResetTitulo";
            this.buttonResetTitulo.Size = new System.Drawing.Size(237, 52);
            this.buttonResetTitulo.TabIndex = 1;
            this.buttonResetTitulo.Text = "Resetar titulo";
            this.buttonResetTitulo.UseVisualStyleBackColor = true;
            this.buttonResetTitulo.Click += new System.EventHandler(this.buttonResetTitulo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(720, 371);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(712, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 281);
            this.panel2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(29, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(431, 84);
            this.listBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.posicionDataGridViewTextBoxColumn,
            this.infraccionesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jugadorFutbolBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // posicionDataGridViewTextBoxColumn
            // 
            this.posicionDataGridViewTextBoxColumn.DataPropertyName = "Posicion";
            this.posicionDataGridViewTextBoxColumn.HeaderText = "Posicion";
            this.posicionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.posicionDataGridViewTextBoxColumn.Name = "posicionDataGridViewTextBoxColumn";
            this.posicionDataGridViewTextBoxColumn.ReadOnly = true;
            this.posicionDataGridViewTextBoxColumn.Width = 125;
            // 
            // infraccionesDataGridViewTextBoxColumn
            // 
            this.infraccionesDataGridViewTextBoxColumn.DataPropertyName = "Infracciones";
            this.infraccionesDataGridViewTextBoxColumn.HeaderText = "Infracciones";
            this.infraccionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.infraccionesDataGridViewTextBoxColumn.Name = "infraccionesDataGridViewTextBoxColumn";
            this.infraccionesDataGridViewTextBoxColumn.ReadOnly = true;
            this.infraccionesDataGridViewTextBoxColumn.Visible = false;
            this.infraccionesDataGridViewTextBoxColumn.Width = 125;
            // 
            // jugadorFutbolBindingSource
            // 
            this.jugadorFutbolBindingSource.DataSource = typeof(S8_CLASES.Entidades.JugadorFutbol);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(712, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar Jugador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.groupBoxInfoPersonal);
            this.panel1.Controls.Add(this.textBoxPosicion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonNuevoJugador);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 340);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.Location = new System.Drawing.Point(57, 22);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(329, 26);
            this.labelMensaje.TabIndex = 9;
            this.labelMensaje.Text = "El jugador se creo exitosamente!";
            this.labelMensaje.Visible = false;
            // 
            // groupBoxInfoPersonal
            // 
            this.groupBoxInfoPersonal.Controls.Add(this.textBoxApellido);
            this.groupBoxInfoPersonal.Controls.Add(this.label1);
            this.groupBoxInfoPersonal.Controls.Add(this.label2);
            this.groupBoxInfoPersonal.Controls.Add(this.textBoxNombre);
            this.groupBoxInfoPersonal.Controls.Add(this.textBoxEdad);
            this.groupBoxInfoPersonal.Controls.Add(this.label3);
            this.groupBoxInfoPersonal.Location = new System.Drawing.Point(110, 58);
            this.groupBoxInfoPersonal.Name = "groupBoxInfoPersonal";
            this.groupBoxInfoPersonal.Size = new System.Drawing.Size(239, 162);
            this.groupBoxInfoPersonal.TabIndex = 8;
            this.groupBoxInfoPersonal.TabStop = false;
            this.groupBoxInfoPersonal.Text = "Info Personal";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(99, 35);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 22);
            this.textBoxApellido.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(99, 75);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 3;
            // 
            // textBoxEdad
            // 
            this.textBoxEdad.Location = new System.Drawing.Point(99, 116);
            this.textBoxEdad.Name = "textBoxEdad";
            this.textBoxEdad.Size = new System.Drawing.Size(100, 22);
            this.textBoxEdad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // textBoxPosicion
            // 
            this.textBoxPosicion.Location = new System.Drawing.Point(215, 226);
            this.textBoxPosicion.Name = "textBoxPosicion";
            this.textBoxPosicion.Size = new System.Drawing.Size(100, 22);
            this.textBoxPosicion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Posicion";
            // 
            // FormJugadoresFutbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(744, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonResetTitulo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormJugadoresFutbol";
            this.Text = "ABM Jugadores de Futbol";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorFutbolBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInfoPersonal.ResumeLayout(false);
            this.groupBoxInfoPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jugadorHockeyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevoJugador;
        private System.Windows.Forms.Button buttonResetTitulo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPosicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBoxInfoPersonal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource jugadorFutbolBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.BindingSource jugadorHockeyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infraccionesDataGridViewTextBoxColumn;
    }
}

