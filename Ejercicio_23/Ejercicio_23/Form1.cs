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

namespace Ejercicio_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dolar d = new Dolar(Convert.ToDouble(textBox2.Text));
            textBox6.Text = d.GetCantidad().ToString();
            Euro e1;
            e1 = (Euro)d;
            textBox5.Text = e1.GetCantidad().ToString();
            Pesos p = (Pesos)d;
            textBox10.Text = p.GetCantidad().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Euro e1 = new Euro(Convert.ToDouble(textBox1.Text));
            textBox4.Text = e1.GetCantidad().ToString();
            Dolar d;
            d = (Dolar)e1;
            textBox7.Text = d.GetCantidad().ToString();
            Pesos p = (Pesos)e1;
            textBox8.Text = p.GetCantidad().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pesos p = new Pesos(Convert.ToDouble(textBox3.Text));
            textBox11.Text = p.GetCantidad().ToString();
            Dolar d;
            d = (Dolar)p;
            textBox12.Text = d.GetCantidad().ToString();
            Euro e1 = (Euro)p;
            textBox9.Text = e1.GetCantidad().ToString();
        }
    }
}
