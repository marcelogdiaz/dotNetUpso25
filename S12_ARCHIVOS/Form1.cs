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

        private void buttonMostrarStores_Click(object sender, EventArgs e)
        {
            textBoxContenido.Text = "";

            IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories(Path.Combine(Directory.GetCurrentDirectory(),"stores"));

            foreach (string directory in listOfDirectories) { 
                textBoxContenido.Text += directory + Environment.NewLine;
            }
        }

        private void buttonArchivos_Click(object sender, EventArgs e)
        {
            //vaciamos el textbox
            textBoxArchivos.Text = "";

            IEnumerable<string> files;
            //detectamos que opcion esta tildada y hacemos el filtrado
            if (radioButtonTXT.Checked) {
                files = Directory.EnumerateFiles(Path.Combine(Directory.GetCurrentDirectory(), "stores"), "*.txt", SearchOption.AllDirectories);
            }
            else {
                files = Directory.EnumerateFiles(Path.Combine(Directory.GetCurrentDirectory(), "stores"),"*.json",SearchOption.AllDirectories);
            }

            //mostramos el contenido filtrado
            foreach (string f in files)
            {
                textBoxArchivos.Text += f + Environment.NewLine;
            }
        }

        private void buttonCrearDirectorio_Click(object sender, EventArgs e)
        {
            //obtenemos el directorio raiz del proyecto
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

            string path = "";
            if (textBoxNombreDirectorio.Text!="") {
                path = Path.Combine(projectFolder,textBoxNombreDirectorio.Text);//  .\<NOMBRE_DIRECTORIO>

                Directory.CreateDirectory(path);
                textBoxNombreDirectorio.Text = "";
            }
        }

        private void buttonCrearArchivo_Click(object sender, EventArgs e)
        {
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
            //vamos a crear el archivo en la carpeta raiz del proyecto
            string nombre = textBoxNombre.Text + "." + textBoxExtension.Text;
            string path = Path.Combine($"{projectFolder}", nombre);

            File.WriteAllText(path, textBoxContenidoArchivo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            textBoxContenidoStream.Text = "";
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString()).ToString();
            string pathFile = Path.Combine($"{projectFolder}{Path.DirectorySeparatorChar}{treeView1.SelectedNode.FullPath}");

            if (File.Exists(pathFile))
            {
                FileStream fstream = new FileStream(pathFile, FileMode.Open);
                Console.WriteLine(treeView1.SelectedNode.FullPath);

                using (StreamReader sr = new StreamReader(fstream))
                {

                    while (!sr.EndOfStream)
                    {
                        textBoxContenidoStream.Text += sr.ReadLine() + Environment.NewLine;
                    }
                    sr.Close();
                }
            }
            else
            {
                labelError.Text = "Debe seleccionar un ARCHIVO";
            }
        }


        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            foreach (var file in directoryInfo.GetFiles())
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            return directoryNode;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string projectFolder = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

            ListDirectory(treeView1, projectFolder);
        }
    }
}
