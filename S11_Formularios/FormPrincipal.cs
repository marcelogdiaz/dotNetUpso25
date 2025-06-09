using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S11_Formularios
{
    public partial class FormPrincipal : Form
    {

        //este formulario va a tener un menu para gestionar los deportistas
        FormJugadoresFutbol fjf;
        FormAcercaDe fad;

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

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = Text + " - " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void jugadoresDeFutbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fjf = new FormJugadoresFutbol();    
            fjf.ShowDialog();   
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fad = new FormAcercaDe();
            fad.ShowDialog();
        }
    }
}
