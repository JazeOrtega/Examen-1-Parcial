using System;
using System.Windows.Forms;

namespace JazeOrtega
{
    public partial class Pantalla : Form
    {
        public Pantalla()
        {
            InitializeComponent();
        }


        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculoInteres descuentoForm = new CalculoInteres();
            this.Hide();
            descuentoForm.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Descuento desc = new Descuento();
            this.Hide();
            desc.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nombre numeros = new Nombre();
            this.Hide();
            numeros.Show();
        }
    }
}
