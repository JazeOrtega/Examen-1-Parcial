namespace JazeOrtega
{
    partial class Descuento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoTextBox1 = new System.Windows.Forms.TextBox();
            this.PrecioTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calcularbutton1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.CantTextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el producto";
            // 
            // ProductoTextBox1
            // 
            this.ProductoTextBox1.Location = new System.Drawing.Point(175, 62);
            this.ProductoTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.ProductoTextBox1.Name = "ProductoTextBox1";
            this.ProductoTextBox1.Size = new System.Drawing.Size(132, 22);
            this.ProductoTextBox1.TabIndex = 1;
            // 
            // PrecioTextBox2
            // 
            this.PrecioTextBox2.Location = new System.Drawing.Point(175, 108);
            this.PrecioTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioTextBox2.Name = "PrecioTextBox2";
            this.PrecioTextBox2.Size = new System.Drawing.Size(132, 22);
            this.PrecioTextBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el precio";
            // 
            // Calcularbutton1
            // 
            this.Calcularbutton1.Location = new System.Drawing.Point(218, 177);
            this.Calcularbutton1.Name = "Calcularbutton1";
            this.Calcularbutton1.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton1.TabIndex = 4;
            this.Calcularbutton1.Text = "Calcular";
            this.Calcularbutton1.UseVisualStyleBackColor = true;
            this.Calcularbutton1.Click += new System.EventHandler(this.Calcularbutton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(331, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 148);
            this.listBox1.TabIndex = 5;
            // 
            // CantTextBox1
            // 
            this.CantTextBox1.Location = new System.Drawing.Point(235, 28);
            this.CantTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.CantTextBox1.Name = "CantTextBox1";
            this.CantTextBox1.Size = new System.Drawing.Size(72, 22);
            this.CantTextBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de productos a ingresar";
            // 
            // AgregarButton1
            // 
            this.AgregarButton1.Location = new System.Drawing.Point(118, 177);
            this.AgregarButton1.Name = "AgregarButton1";
            this.AgregarButton1.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton1.TabIndex = 9;
            this.AgregarButton1.Text = "Agregar";
            this.AgregarButton1.UseVisualStyleBackColor = true;
            this.AgregarButton1.Click += new System.EventHandler(this.AgregarButton1_Click);
            // 
            // Descuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 264);
            this.Controls.Add(this.AgregarButton1);
            this.Controls.Add(this.CantTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Calcularbutton1);
            this.Controls.Add(this.PrecioTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductoTextBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Descuento";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductoTextBox1;
        private System.Windows.Forms.TextBox PrecioTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcularbutton1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox CantTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarButton1;
    }
}