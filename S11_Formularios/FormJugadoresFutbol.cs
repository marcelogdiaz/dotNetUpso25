using S8_CLASES.Entidades;
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
    public partial class FormJugadoresFutbol : Form
    {

        int cantidadClicks = 1;
        List<JugadorFutbol> deportistasCenard = new List<JugadorFutbol>();

        public FormJugadoresFutbol()
        {
            InitializeComponent();
        }

        private void buttonTitulo_Click(object sender, EventArgs e)
        {
            //creamos el jugador
            JugadorFutbol j = new JugadorFutbol(textBoxApellido.Text, textBoxNombre.Text,
                Int32.Parse( textBoxEdad.Text), textBoxPosicion.Text);

            //lo agregamos a nuestra lista en memoria
            deportistasCenard.Add(j);

            //inicializamos los controles en vacio
            textBoxApellido.Text = "";
            textBoxNombre.Text = "";
            textBoxEdad.Text = "";
            textBoxPosicion.Text = "";
            //---------------------------

            labelMensaje.Visible = true;
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ocultamos el cartel de mensaje
            labelMensaje.Visible=false;

            //vaciamos la lista
            listBox1.Items.Clear();

            //cargamos la lista con los deportistas
            foreach (var item in deportistasCenard)
            {
                listBox1.Items.Add(item.Apellido + " " + item.Nombre + ": " + item.Posicion);
            }


            //como List<> no implementa IBindingList, que es necesaria para qua la grilla actualice los items,
            //es necesario crear un BINDINGLIST
            var milistabindeada = new BindingList<JugadorFutbol>(deportistasCenard);

            dataGridView1.DataSource = milistabindeada;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            labelMensaje.Visible = false;
        }
    }
}
