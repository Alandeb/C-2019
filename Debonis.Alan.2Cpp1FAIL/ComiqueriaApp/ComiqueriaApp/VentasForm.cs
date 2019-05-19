using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        private Producto producto;
        private Comiqueria comiqueria;

        public VentasForm()
        {
            InitializeComponent();
        }

        public VentasForm (Producto product , Comiqueria comic) : this()
        {
            producto = product;
            comiqueria = comic;
            lblDescripcion.Text = product.Descripcion;
            lblPrecioFinal.Text = string.Format("Precio Final: ${0}", product.Precio);
        }

        private void numericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = string.Format("Precio Final: ${0}", (double)numericUpDownCantidad.Value *producto.Precio );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownCantidad.Value <= producto.Stock)
            {
                comiqueria.Vender(producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("La cantidad que desea comprar supera al stock disponible", "Error de Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
