using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JazeOrtega
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }

        private async void Calcularbutton1_Click(object sender, EventArgs e)
        {
            int precio = Convert.ToInt32(PrecioTextBox2.Text);
            string producto = ProductoTextBox1.Text;
            int num = Convert.ToInt32(CantTextBox1.Text);
            decimal descuento = await DescuentoAsync(precio, producto, num);


        }

        private async Task<decimal> DescuentoAsync(int valor, string objeto, int num)
        {
            decimal suma = await Task.Run(() =>
            {
                int[] vector = new int[num];
                decimal tasa = 0.15M, desc = 0, total = 0;
                for (int i = 1; i < vector.Length; i++)
                {
                    desc = valor * tasa;
                    total = valor + desc;

                }
                decimal totalAcum = total++;
                listBox1.Items.Add("Total " + totalAcum);
                return totalAcum;

            });
            return suma;
        }

        private void AgregarButton1_Click(object sender, EventArgs e)
        {
            ProductoTextBox1.Clear();
            PrecioTextBox2.Clear();
            ProductoTextBox1.Focus();
            int precio = Convert.ToInt32(PrecioTextBox2.Text);
            string producto = ProductoTextBox1.Text;
            listBox1.Items.Add("Producto " + producto + "  precio " + precio);


        }
    }
}
