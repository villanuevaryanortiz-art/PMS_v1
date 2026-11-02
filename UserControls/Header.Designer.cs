namespace PMS_v1.UserControls
{
    partial class Header
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnHamburger = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnHamburger);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 90);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Location = new Point(1054, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 90);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnHamburger
            // 
            btnHamburger.BackColor = Color.Transparent;
            btnHamburger.Dock = DockStyle.Left;
            btnHamburger.FlatAppearance.BorderSize = 0;
            btnHamburger.FlatStyle = FlatStyle.Flat;
            btnHamburger.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHamburger.ForeColor = Color.SteelBlue;
            btnHamburger.Location = new Point(0, 0);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(88, 90);
            btnHamburger.TabIndex = 1;
            btnHamburger.Text = "☰";
            btnHamburger.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Header";
            Size = new Size(1150, 90);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHamburger;
        private PictureBox pictureBox1;
    }
}
