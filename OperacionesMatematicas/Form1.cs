using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperacionesMatematicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtnumero1.Text = String.Empty;
            txtnumero2.Text = String.Empty;
            lblresultado.Text = "0";
            txtnumero1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double suma = 0;

            suma = numero1 + numero2;

            lblresultado.Text = Convert.ToString(suma);
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", suma));
        
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double resta = 0;

            resta = numero1 - numero2;

            lblresultado.Text = Convert.ToString(resta);
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", resta));
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double multiplicar = 0;

            multiplicar = numero1 * numero2;

            lblresultado.Text = Convert.ToString(multiplicar);
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", multiplicar));
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtnumero1.Text);
            double numero2 = double.Parse(txtnumero2.Text);
            double dividir = 0;

            dividir = numero1 / numero2;

            lblresultado.Text = Convert.ToString(dividir);
            lblresultado.Text = Convert.ToString(String.Format("{0:n0}", dividir));
        }
    }
}
