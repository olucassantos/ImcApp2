namespace ImcApp
{
    partial class frmCalculaImc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numPeso = new NumericUpDown();
            numAltura = new NumericUpDown();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            lblResultado = new Label();
            panel2 = new Panel();
            lblSeta = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // numPeso
            // 
            numPeso.DecimalPlaces = 2;
            numPeso.Location = new Point(57, 230);
            numPeso.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(247, 31);
            numPeso.TabIndex = 0;
            numPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // numAltura
            // 
            numAltura.DecimalPlaces = 2;
            numAltura.Location = new Point(57, 299);
            numAltura.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(247, 31);
            numAltura.TabIndex = 1;
            numAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(192, 357);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 202);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 3;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 271);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 3;
            label2.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 153);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 4;
            label3.Text = "Calculo IMC";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnCalcular);
            panel1.Controls.Add(numAltura);
            panel1.Controls.Add(numPeso);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 544);
            panel1.TabIndex = 5;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Black", 60F);
            lblResultado.Location = new Point(3, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(139, 159);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "0";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblSeta);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblResultado);
            panel2.Location = new Point(366, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(588, 544);
            panel2.TabIndex = 7;
            // 
            // lblSeta
            // 
            lblSeta.AutoSize = true;
            lblSeta.BackColor = Color.Transparent;
            lblSeta.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSeta.Location = new Point(544, 493);
            lblSeta.Name = "lblSeta";
            lblSeta.Size = new Size(32, 41);
            lblSeta.TabIndex = 5;
            lblSeta.Text = "↑";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imcoms;
            pictureBox1.Location = new Point(3, 280);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmCalculaImc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 543);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmCalculaImc";
            Text = "Calculo IMC";
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown numPeso;
        private NumericUpDown numAltura;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label lblResultado;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblSeta;
    }
}
