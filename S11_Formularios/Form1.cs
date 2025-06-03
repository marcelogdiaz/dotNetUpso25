using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S11_Formularios
{
    public partial class FormPrincipal : Form
    {

        int cantidadClicks = 1;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonTitulo_Click(object sender, EventArgs e)
        {
            this.Text = Text + " - "+ cantidadClicks.ToString();
            cantidadClicks++;
        }


        /// <summary>
        /// Handler del evento CLICK del boton Reset Titulo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonResetTitulo_Click(object sender, EventArgs e)
        {
            this.Text = "Mi Primer Formulario";
            cantidadClicks=1;
        }
    }
}
