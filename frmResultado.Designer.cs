namespace ImcApp
{
    partial class frmResultado
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
            lblSeta = new Label();
            pictureBox1 = new PictureBox();
            lblResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSeta
            // 
            lblSeta.AutoSize = true;
            lblSeta.BackColor = Color.Transparent;
            lblSeta.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSeta.Location = new Point(416, 409);
            lblSeta.Name = "lblSeta";
            lblSeta.Size = new Size(32, 41);
            lblSeta.TabIndex = 8;
            lblSeta.Text = "↑";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imcoms;
            pictureBox1.Location = new Point(111, 192);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Black", 60F);
            lblResultado.Location = new Point(324, 32);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(139, 159);
            lblResultado.TabIndex = 9;
            lblResultado.Text = "0";
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmResultado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 598);
            Controls.Add(lblSeta);
            Controls.Add(pictureBox1);
            Controls.Add(lblResultado);
            Name = "frmResultado";
            Text = "frmResultado";
            Load += frmResultado_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeta;
        private PictureBox pictureBox1;
        private Label lblResultado;
    }
}