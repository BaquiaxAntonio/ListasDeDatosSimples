using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasDeDatosSimples
{
    public partial class Form1 : Form
    {
        List<int> listaEnteros = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 0;
            bool seConvirtio = int.TryParse(textBoxNoIngresado.Text, out numero);
            if (seConvirtio)
            {
                listaEnteros.Add(numero);
                textBoxNoIngresado.Text = "";
                Mostrar();
            }
            else
            {
                MessageBox.Show("debe ingresar un numero");
                textBoxNoIngresado.Text = "";
                textBoxNoIngresado.Select();
            }

            //textBoxNoIngresado.Text = "";
        }

        private void Mostrar()
        {
            //for (int i = 0; i < listaEnteros.Count; i++)
            //{
            //    listBox1.Items.Add(listaEnteros[i]);
            //}

            //opcion 2:
            //funciona con: combobox,listBox,dategridview
            listBox1.DataSource = null;
            listBox1.DataSource = listaEnteros;
            listBox1.Refresh();
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            Mostrar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int numero = 0;
            bool seConvirtio = int.TryParse(textBoxNoIngresado.Text, out numero);
            if (seConvirtio)
            {
                listaEnteros.Remove(numero);
                Mostrar();
            }
            else
            {
                MessageBox.Show("debe ingresar un numero");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaEnteros.Sort();
            listaEnteros.Reverse();
            Mostrar();
        }
    }
}
