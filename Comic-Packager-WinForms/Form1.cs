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
using System.IO.Compression;

namespace Comic_Packager_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textbox_label.Text = fbd.SelectedPath;
            }
        }

        private void button_compress_Click(object sender, EventArgs e)
        {

            string input, output;


            input = textbox_label.Text;
            output = input + ".cbz"; // Mismo directorio que el argumento, pero con la extensión CBZ

                // Comprueba que el directorio de entrada existe
                if (Directory.Exists(input))
                {
                    try
                    {
                        ZipFile.CreateFromDirectory(input, output);
                        label_errors.Text = ("El fichero " + output + " ha sido creado con éxito.");
                    }
                    catch (IOException ioex)
                    {
                        label_errors.Text=(output + " ya existe en el contexto actual y no va a ser sobrescrito.");
                        // Console.WriteLine("Error: " + ioex);
                    }
                
            }

        }
    }
}
