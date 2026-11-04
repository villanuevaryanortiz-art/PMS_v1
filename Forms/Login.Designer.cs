namespace PMS_v1.Forms
{
    partial class Login
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
            pnlBackground = new Krypton.Toolkit.KryptonPanel();
            pnlLogin = new Panel();
            pnlLoginhere = new Panel();
            panel6 = new Panel();
            lnklblSignUp = new LinkLabel();
            label2 = new Label();
            panel5 = new Panel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            panel4 = new Panel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            btnShowHidePass = new Krypton.Toolkit.ButtonSpecAny();
            panel3 = new Panel();
            lblPassword = new Krypton.Toolkit.KryptonLabel();
            panel2 = new Panel();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            panel1 = new Panel();
            lblUsername = new Krypton.Toolkit.KryptonLabel();
            label1 = new Label();
            pnlLogo = new Panel();
            ((System.ComponentModel.ISupportInitialize)pnlBackground).BeginInit();
            pnlLogin.SuspendLayout();
            pnlLoginhere.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.Dock = DockStyle.Fill;
            pnlBackground.Location = new Point(0, 0);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new Size(1422, 977);
            pnlBackground.StateCommon.Color1 = Color.SteelBlue;
            pnlBackground.StateCommon.Color2 = Color.PaleTurquoise;
            pnlBackground.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Linear50;
            pnlBackground.StateCommon.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.HighQuality;
            pnlBackground.StateCommon.Image = Resources.Resources.BG;
            pnlBackground.StateCommon.ImageStyle = Krypton.Toolkit.PaletteImageStyle.TileFlipY;
            pnlBackground.TabIndex = 0;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(pnlLoginhere);
            pnlLogin.Controls.Add(pnlLogo);
            pnlLogin.Dock = DockStyle.Right;
            pnlLogin.Location = new Point(784, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(638, 977);
            pnlLogin.TabIndex = 1;
            // 
            // pnlLoginhere
            // 
            pnlLoginhere.Controls.Add(panel6);
            pnlLoginhere.Controls.Add(panel5);
            pnlLoginhere.Controls.Add(panel4);
            pnlLoginhere.Controls.Add(panel3);
            pnlLoginhere.Controls.Add(panel2);
            pnlLoginhere.Controls.Add(panel1);
            pnlLoginhere.Dock = DockStyle.Fill;
            pnlLoginhere.Location = new Point(0, 205);
            pnlLoginhere.Name = "pnlLoginhere";
            pnlLoginhere.Size = new Size(638, 772);
            pnlLoginhere.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(lnklblSignUp);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 496);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(60, 0, 0, 0);
            panel6.Size = new Size(638, 164);
            panel6.TabIndex = 7;
            // 
            // lnklblSignUp
            // 
            lnklblSignUp.AutoSize = true;
            lnklblSignUp.Dock = DockStyle.Left;
            lnklblSignUp.Font = new Font("Century Gothic", 10.2F);
            lnklblSignUp.ForeColor = Color.Black;
            lnklblSignUp.Location = new Point(277, 0);
            lnklblSignUp.Name = "lnklblSignUp";
            lnklblSignUp.Size = new Size(116, 21);
            lnklblSignUp.TabIndex = 1;
            lnklblSignUp.TabStop = true;
            lnklblSignUp.Text = "Sign up here.";
            lnklblSignUp.LinkClicked += lnklblSignUp_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Century Gothic", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 0);
            label2.Name = "label2";
            label2.Size = new Size(217, 21);
            label2.TabIndex = 0;
            label2.Text = "Don't have an account?";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogin);
            panel5.Dock = DockStyle.Top;
            panel5.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel5.Location = new Point(0, 346);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(65, 50, 50, 20);
            panel5.Size = new Size(638, 150);
            panel5.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Location = new Point(65, 50);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(523, 80);
            btnLogin.StateCommon.Back.Color1 = Color.Transparent;
            btnLogin.StateCommon.Back.Color2 = Color.Transparent;
            btnLogin.StateCommon.Back.Image = Resources.Resources.ButtonBlue;
            btnLogin.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnLogin.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnLogin.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            btnLogin.StateCommon.Border.Rounding = 60F;
            btnLogin.StateCommon.Content.Image.ImageColorMap = Color.Silver;
            btnLogin.StateCommon.Content.Image.ImageColorTo = Color.Silver;
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.White;
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.TabIndex = 0;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Login\r\n";
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtPassword);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 254);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(65, 5, 50, 20);
            panel4.Size = new Size(638, 92);
            panel4.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.ButtonSpecs.Add(btnShowHidePass);
            txtPassword.CueHint.Color1 = Color.DarkGray;
            txtPassword.CueHint.CueHintText = "Enter Password";
            txtPassword.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(65, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(523, 79);
            txtPassword.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Rounding = 3F;
            txtPassword.StateCommon.Border.Width = 20;
            txtPassword.StateCommon.Content.Color1 = Color.Black;
            txtPassword.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtPassword.TabIndex = 2;
            // 
            // btnShowHidePass
            // 
            btnShowHidePass.ColorMap = Color.White;
            btnShowHidePass.Edge = Krypton.Toolkit.PaletteRelativeEdgeAlign.Far;
            btnShowHidePass.Image = Resources.Resources.EyeClose;
            btnShowHidePass.ImageTransparentColor = Color.Transparent;
            btnShowHidePass.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            btnShowHidePass.ToolTipShadow = false;
            btnShowHidePass.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Open;
            btnShowHidePass.UniqueName = "172cf345460948dc8c54dfb80c1c8a81";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPassword);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 206);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(52, 20, 20, 20);
            panel3.Size = new Size(638, 48);
            panel3.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Dock = DockStyle.Top;
            lblPassword.Location = new Point(52, 20);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(566, 34);
            lblPassword.StateCommon.LongText.Color1 = Color.Red;
            lblPassword.StateCommon.Padding = new Padding(-1, -1, 462, 10);
            lblPassword.StateCommon.ShortText.Color1 = Color.DimGray;
            lblPassword.StateCommon.ShortText.Color2 = Color.Red;
            lblPassword.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.TabIndex = 1;
            lblPassword.Values.ExtraText = "*";
            lblPassword.Values.Text = "Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtUsername);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 114);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(65, 5, 50, 20);
            panel2.Size = new Size(638, 92);
            panel2.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.CueHint.Color1 = Color.DarkGray;
            txtUsername.CueHint.CueHintText = "Enter Username";
            txtUsername.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(65, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(523, 79);
            txtUsername.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Rounding = 3F;
            txtUsername.StateCommon.Border.Width = 20;
            txtUsername.StateCommon.Content.Color1 = Color.Black;
            txtUsername.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtUsername.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50, 20, 20, 20);
            panel1.Size = new Size(638, 114);
            panel1.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.Dock = DockStyle.Top;
            lblUsername.Location = new Point(50, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(568, 63);
            lblUsername.StateCommon.LongText.Color1 = Color.Red;
            lblUsername.StateCommon.Padding = new Padding(-1, 30, 460, 10);
            lblUsername.StateCommon.ShortText.Color1 = Color.DimGray;
            lblUsername.StateCommon.ShortText.Color2 = Color.Red;
            lblUsername.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.TabIndex = 1;
            lblUsername.Values.ExtraText = "*";
            lblUsername.Values.Text = "Username ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 20);
            label1.Name = "label1";
            label1.Size = new Size(104, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = Resources.Resources.HeaderBlack;
            pnlLogo.BackgroundImageLayout = ImageLayout.Center;
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(638, 205);
            pnlLogo.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(pnlLogin);
            Controls.Add(pnlBackground);
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pnlBackground).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLoginhere.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlBackground;
        private Panel pnlLogin;
        private Panel pnlLogo;
        private Panel pnlLoginhere;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Krypton.Toolkit.KryptonLabel lblPassword;
        private Panel panel4;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Krypton.Toolkit.ButtonSpecAny btnShowHidePass;
        private Panel panel5;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Panel panel6;
        private LinkLabel lnklblSignUp;
        private Label label2;
    }
}