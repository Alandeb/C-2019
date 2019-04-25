using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            int flag = 0;
            // VALIDACION EN EL TEXTO PARA BINARIO
            if (textBox1.Text.Length != 0 ) {
                
                for (int i = textBox1.Text.Length; i > 0; i--)
                {
                    if (!(textBox1.Text[i - 1].Equals('0') || textBox1.Text[i - 1].Equals('1')))
                    {
                        flag = 1;
                        break;
                    }
                }
            }
            else
            {
                flag = 1;
            }
            // MENSAJE DE ERROR
            if(flag == 1)
            {
                MessageBox.Show("Ingrese un número Binario!", "Error Detectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // SI TODO ESTA OK CREAMOS EL OBJETO Y EMPEZAMOS LA CONVERSIÖN
                NumeroBinario nroBinario = new NumeroBinario(textBox1.Text);
                txtResultadoDec.Text = ((double)nroBinario).ToString();
            }
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            bool validar = double.TryParse(textBox2.Text, out double nro);
            if (validar == true)
            {
                // SI TODO ESTA OK CREAMOS EL OBJETO Y EMPEZAMOS LA CONVERSION
                NumeroDecimal nroDecimal = new NumeroDecimal(nro);
                txtResultadoBin.Text = (string)nroDecimal;
            }
            else
            {
                // SI EL VALOR INGRESADO NO ES UN NRO GENERAMOS  UN ERROR
                MessageBox.Show("Ingrese un número!", "Error Detectado", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
