using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace VistaForm
{
    public partial class Form1 : Form
    {
        Entidades.DirectorTecnico dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (dt == null)
                MessageBox.Show("no va");
            else
            {
                if (dt.ValidarAptitud())
                    MessageBox.Show("El Dt es apto");
                else
                    MessageBox.Show("El Dt NO es apto");
            }
        }
    }
}
