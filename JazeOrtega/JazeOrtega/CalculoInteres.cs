using System;
using System.Windows.Forms;

namespace JazeOrtega
{
    public partial class CalculoInteres : Form
    {
        public CalculoInteres()
        {
            InitializeComponent();
        }


        private void CalcularButton1_Click(object sender, EventArgs e)
        {
            int[] vector = new int[13];
            int capital = 200000, meses = 1;
            double tasa = 0.015, interes = 0;


            for (int i = 1; i < vector.Length; i++)
            {
                double total = capital + interes;
                interes = total * tasa * meses;
                listBox1.Items.Add("El interes del mes " + i + " es: " + interes);
                meses++;
            }
        }
    }
}
