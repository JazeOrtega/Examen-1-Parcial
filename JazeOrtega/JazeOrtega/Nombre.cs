using System;
using System.Windows.Forms;

namespace JazeOrtega
{
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }

        private void MostarButton1_Click(object sender, EventArgs e)
        {
            string nombre = NombreTextBox1.Text;
            string apellido = ApellidoTextBox2.Text;
            for (int i = 1; i < 101; i++)
            {
                string impresion = "Numero " + i;
                if (i % 3 == 0)
                {
                    impresion = "Numero " + i + " " + nombre;
                }
                if (i % 5 == 0)
                {
                    impresion = "Numero " + i + " " + apellido;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    impresion = "Numero " + i + " " + nombre + " " + apellido;
                }
                listBox1.Items.Add(impresion);
            }
        }
    }
}
