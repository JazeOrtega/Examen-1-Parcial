namespace JazeOrtega
{
    partial class Nombre
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox1 = new System.Windows.Forms.TextBox();
            this.ApellidoTextBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MostarButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(381, 44);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 244);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre";
            // 
            // NombreTextBox1
            // 
            this.NombreTextBox1.Location = new System.Drawing.Point(200, 56);
            this.NombreTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NombreTextBox1.Name = "NombreTextBox1";
            this.NombreTextBox1.Size = new System.Drawing.Size(132, 22);
            this.NombreTextBox1.TabIndex = 2;
            // 
            // ApellidoTextBox2
            // 
            this.ApellidoTextBox2.Location = new System.Drawing.Point(200, 106);
            this.ApellidoTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ApellidoTextBox2.Name = "ApellidoTextBox2";
            this.ApellidoTextBox2.Size = new System.Drawing.Size(132, 22);
            this.ApellidoTextBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el apellido";
            // 
            // MostarButton1
            // 
            this.MostarButton1.Location = new System.Drawing.Point(71, 174);
            this.MostarButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MostarButton1.Name = "MostarButton1";
            this.MostarButton1.Size = new System.Drawing.Size(100, 28);
            this.MostarButton1.TabIndex = 5;
            this.MostarButton1.Text = "Mostar";
            this.MostarButton1.UseVisualStyleBackColor = true;
            this.MostarButton1.Click += new System.EventHandler(this.MostarButton1_Click);
            // 
            // Nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 315);
            this.Controls.Add(this.MostarButton1);
            this.Controls.Add(this.ApellidoTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Nombre";
            this.Text = "Nombre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox1;
        private System.Windows.Forms.TextBox ApellidoTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MostarButton1;
    }
}