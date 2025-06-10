using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace S12_ARCHIVOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPathActual_Click(object sender, EventArgs e)
        {
            //mostramos en el label el PATH del directorio actual
            labelPathActual.Text = Directory.GetCurrentDirectory(); 
        }

        private void buttonPathEscritorio_Click(object sender, EventArgs e)
        {
            //mostramos el en label el PATH del escritorio  de Windows
            labelPathEscritorio.Text =Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            labelPathEscritorioRelativo.Text = $"{Path.DirectorySeparatorChar}" + Environment.SpecialFolder.Desktop;
            labelPathCombinado.Text = Path.Combine("stores","201"); //stores\201
        }
    }
}
