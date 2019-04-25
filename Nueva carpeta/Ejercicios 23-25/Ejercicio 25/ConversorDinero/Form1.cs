using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Moneda;

namespace ConversorDinero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            bool validar = double.TryParse(txtEuro.Text, out double nro);
            if (txtEuro.Text.Length != 0 && (validar)){

                Euro euro = new Euro(nro, (float)1.16);
                Pesos pesos = new Pesos((double)2, (float)38.8);
                Dolar dolar = new Dolar((double)3, (float)1);
                // PESOS
                txtEuroAPesos.Text = ((Pesos)((Dolar)euro)).GetCantidad().ToString();
                // DOLAR
                txtEuroADolar.Text = (((Dolar)euro).GetCantidad()).ToString();
                // Euro
                txtEuroAEuro.Text = txtEuro.Text;
            }
            else
            {
                MessageBox.Show("Faltan valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            bool validar = double.TryParse(txtDolar.Text, out double nro);
            if (txtDolar.Text.Length != 0 && (validar))
            {

                Euro euro = new Euro((double)1, (float)1.16);
                Pesos pesos = new Pesos((double)2, (float)38.8);
                Dolar dolar = new Dolar(nro, (float)1);
                // PESOS
                txtDolarAPesos.Text = ((Pesos)dolar).GetCantidad().ToString();
                // DOLAR
                txtDolarADolar.Text = txtDolar.Text;
                // Euro
                txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Faltan valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertPesos_Click(object sender, EventArgs e)
        {
            bool validar = double.TryParse(txtPesos.Text, out double nro);
            if (txtPesos.Text.Length != 0 && (validar))
            {

                Euro euro = new Euro((double)1, (float)1.16);
                Pesos pesos = new Pesos(nro, (float)38.8);
                Dolar dolar = new Dolar((double)1, (float)1);
                // PESOS
                txtPesosAPesos.Text = txtPesos.Text;
                // DOLAR
                txtPesosADolar.Text = ((Dolar)pesos).GetCantidad().ToString();
                // Euro
                txtPesosAEuro.Text = ((Euro)((Dolar)pesos)).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Faltan valores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
