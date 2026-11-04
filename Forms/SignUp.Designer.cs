namespace PMS_v1.Forms
{
    partial class SignUp
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
            pnlLogo = new Panel();
            btnShowHidePass = new Krypton.Toolkit.ButtonSpecAny();
            pnlLogin = new Panel();
            pnlLoginhere = new Panel();
            panel12 = new Panel();
            lnklblLogin = new LinkLabel();
            label2 = new Label();
            panel11 = new Panel();
            btnSignUp = new Krypton.Toolkit.KryptonButton();
            panel9 = new Panel();
            txtRePassword = new Krypton.Toolkit.KryptonTextBox();
            btnShowHidePass2 = new Krypton.Toolkit.ButtonSpecAny();
            panel10 = new Panel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            panel7 = new Panel();
            txtPassword = new Krypton.Toolkit.KryptonTextBox();
            btnShowHidePass1 = new Krypton.Toolkit.ButtonSpecAny();
            panel8 = new Panel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            panel6 = new Panel();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            panel5 = new Panel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            panel4 = new Panel();
            txtLastName = new Krypton.Toolkit.KryptonTextBox();
            panel3 = new Panel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            panel2 = new Panel();
            txtEmployeeNumber = new Krypton.Toolkit.KryptonTextBox();
            panel1 = new Panel();
            lblUsername = new Krypton.Toolkit.KryptonLabel();
            label1 = new Label();
            pnlBackground = new Krypton.Toolkit.KryptonPanel();
            pnlLogin.SuspendLayout();
            pnlLoginhere.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlBackground).BeginInit();
            SuspendLayout();
            // 
            // pnlLogo
            // 
            pnlLogo.BackgroundImage = Resources.Resources.HeaderBlack;
            pnlLogo.BackgroundImageLayout = ImageLayout.Center;
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(638, 122);
            pnlLogo.TabIndex = 0;
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
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(pnlLoginhere);
            pnlLogin.Controls.Add(pnlLogo);
            pnlLogin.Dock = DockStyle.Right;
            pnlLogin.Location = new Point(784, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(638, 977);
            pnlLogin.TabIndex = 3;
            // 
            // pnlLoginhere
            // 
            pnlLoginhere.Controls.Add(panel12);
            pnlLoginhere.Controls.Add(panel11);
            pnlLoginhere.Controls.Add(panel9);
            pnlLoginhere.Controls.Add(panel10);
            pnlLoginhere.Controls.Add(panel7);
            pnlLoginhere.Controls.Add(panel8);
            pnlLoginhere.Controls.Add(panel6);
            pnlLoginhere.Controls.Add(panel5);
            pnlLoginhere.Controls.Add(panel4);
            pnlLoginhere.Controls.Add(panel3);
            pnlLoginhere.Controls.Add(panel2);
            pnlLoginhere.Controls.Add(panel1);
            pnlLoginhere.Dock = DockStyle.Fill;
            pnlLoginhere.Location = new Point(0, 122);
            pnlLoginhere.Name = "pnlLoginhere";
            pnlLoginhere.Size = new Size(638, 855);
            pnlLoginhere.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(lnklblLogin);
            panel12.Controls.Add(label2);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 795);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(60, 0, 0, 0);
            panel12.Size = new Size(638, 60);
            panel12.TabIndex = 15;
            // 
            // lnklblLogin
            // 
            lnklblLogin.AutoSize = true;
            lnklblLogin.Dock = DockStyle.Left;
            lnklblLogin.Font = new Font("Century Gothic", 10.2F);
            lnklblLogin.ForeColor = Color.Black;
            lnklblLogin.Location = new Point(297, 0);
            lnklblLogin.Name = "lnklblLogin";
            lnklblLogin.Size = new Size(100, 21);
            lnklblLogin.TabIndex = 1;
            lnklblLogin.TabStop = true;
            lnklblLogin.Text = "Login here.";
            lnklblLogin.LinkClicked += lnklblLogin_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Left;
            label2.Font = new Font("Century Gothic", 10.2F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(60, 0);
            label2.Name = "label2";
            label2.Size = new Size(237, 21);
            label2.TabIndex = 0;
            label2.Text = "Already have an account?";
            // 
            // panel11
            // 
            panel11.Controls.Add(btnSignUp);
            panel11.Dock = DockStyle.Top;
            panel11.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel11.Location = new Point(0, 685);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(65, 25, 50, 5);
            panel11.Size = new Size(638, 110);
            panel11.TabIndex = 14;
            // 
            // btnSignUp
            // 
            btnSignUp.Dock = DockStyle.Fill;
            btnSignUp.Location = new Point(65, 25);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(523, 80);
            btnSignUp.StateCommon.Back.Color1 = Color.Transparent;
            btnSignUp.StateCommon.Back.Color2 = Color.Transparent;
            btnSignUp.StateCommon.Back.Image = Resources.Resources.ButtonBlue;
            btnSignUp.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Stretch;
            btnSignUp.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            btnSignUp.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            btnSignUp.StateCommon.Border.Rounding = 60F;
            btnSignUp.StateCommon.Content.Image.ImageColorMap = Color.Silver;
            btnSignUp.StateCommon.Content.Image.ImageColorTo = Color.Silver;
            btnSignUp.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSignUp.StateCommon.Content.ShortText.Color2 = Color.Gainsboro;
            btnSignUp.StateCommon.Content.ShortText.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.TabIndex = 0;
            btnSignUp.Values.DropDownArrowColor = Color.Empty;
            btnSignUp.Values.Text = "Sign-Up";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtRePassword);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 606);
            panel9.Name = "panel9";
            panel9.Padding = new Padding(65, 5, 50, 30);
            panel9.Size = new Size(638, 79);
            panel9.TabIndex = 13;
            // 
            // txtRePassword
            // 
            txtRePassword.ButtonSpecs.Add(btnShowHidePass2);
            txtRePassword.CueHint.Color1 = Color.DarkGray;
            txtRePassword.CueHint.CueHintText = "Enter Password";
            txtRePassword.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRePassword.Dock = DockStyle.Fill;
            txtRePassword.Location = new Point(65, 5);
            txtRePassword.Name = "txtRePassword";
            txtRePassword.Size = new Size(523, 69);
            txtRePassword.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtRePassword.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtRePassword.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtRePassword.StateCommon.Border.Rounding = 3F;
            txtRePassword.StateCommon.Border.Width = 15;
            txtRePassword.StateCommon.Content.Color1 = Color.Black;
            txtRePassword.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRePassword.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtRePassword.TabIndex = 2;
            // 
            // btnShowHidePass2
            // 
            btnShowHidePass2.Image = Resources.Resources.EyeClose;
            btnShowHidePass2.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            btnShowHidePass2.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Open;
            btnShowHidePass2.UniqueName = "e25f25fd495f49d0ab0dfc2fca307470";
            // 
            // panel10
            // 
            panel10.Controls.Add(kryptonLabel4);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 561);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(50, 0, 20, 0);
            panel10.Size = new Size(638, 45);
            panel10.TabIndex = 12;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Dock = DockStyle.Top;
            kryptonLabel4.Location = new Point(50, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(568, 46);
            kryptonLabel4.StateCommon.LongText.Color1 = Color.Red;
            kryptonLabel4.StateCommon.Padding = new Padding(-1, 13, 394, 10);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.Red;
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.TabIndex = 3;
            kryptonLabel4.Values.ExtraText = "*";
            kryptonLabel4.Values.Text = "Re-Type Password";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtPassword);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 482);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(65, 5, 50, 30);
            panel7.Size = new Size(638, 79);
            panel7.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.ButtonSpecs.Add(btnShowHidePass1);
            txtPassword.CueHint.Color1 = Color.DarkGray;
            txtPassword.CueHint.CueHintText = "Enter Password";
            txtPassword.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(65, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(523, 69);
            txtPassword.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtPassword.StateCommon.Border.Rounding = 3F;
            txtPassword.StateCommon.Border.Width = 15;
            txtPassword.StateCommon.Content.Color1 = Color.Black;
            txtPassword.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtPassword.TabIndex = 2;
            // 
            // btnShowHidePass1
            // 
            btnShowHidePass1.Image = Resources.Resources.EyeClose;
            btnShowHidePass1.Style = Krypton.Toolkit.PaletteButtonStyle.ButtonSpec;
            btnShowHidePass1.Type = Krypton.Toolkit.PaletteButtonSpecStyle.Open;
            btnShowHidePass1.UniqueName = "a464c704ba654ef58c36e20eec395c30";
            // 
            // panel8
            // 
            panel8.Controls.Add(kryptonLabel3);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 437);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(50, 0, 20, 0);
            panel8.Size = new Size(638, 45);
            panel8.TabIndex = 10;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = DockStyle.Top;
            kryptonLabel3.Location = new Point(50, 0);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(568, 46);
            kryptonLabel3.StateCommon.LongText.Color1 = Color.Red;
            kryptonLabel3.StateCommon.Padding = new Padding(-1, 13, 464, 10);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.Red;
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.ExtraText = "*";
            kryptonLabel3.Values.Text = "Password";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtUsername);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 358);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(65, 5, 50, 30);
            panel6.Size = new Size(638, 79);
            panel6.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.CueHint.Color1 = Color.DarkGray;
            txtUsername.CueHint.CueHintText = "Enter Username";
            txtUsername.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(65, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(523, 69);
            txtUsername.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtUsername.StateCommon.Border.Rounding = 3F;
            txtUsername.StateCommon.Border.Width = 15;
            txtUsername.StateCommon.Content.Color1 = Color.Black;
            txtUsername.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtUsername.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(kryptonLabel2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 313);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(50, 0, 20, 0);
            panel5.Size = new Size(638, 45);
            panel5.TabIndex = 8;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(50, 0);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(568, 46);
            kryptonLabel2.StateCommon.LongText.Color1 = Color.Red;
            kryptonLabel2.StateCommon.Padding = new Padding(-1, 13, 460, 10);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.Red;
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 3;
            kryptonLabel2.Values.ExtraText = "*";
            kryptonLabel2.Values.Text = "Username";
            // 
            // panel4
            // 
            panel4.Controls.Add(txtLastName);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 234);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(65, 5, 50, 30);
            panel4.Size = new Size(638, 79);
            panel4.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.CueHint.Color1 = Color.DarkGray;
            txtLastName.CueHint.CueHintText = "Enter Last Name";
            txtLastName.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(65, 5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(523, 69);
            txtLastName.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtLastName.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtLastName.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtLastName.StateCommon.Border.Rounding = 3F;
            txtLastName.StateCommon.Border.Width = 15;
            txtLastName.StateCommon.Content.Color1 = Color.Black;
            txtLastName.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtLastName.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(kryptonLabel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 189);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(50, 0, 20, 0);
            panel3.Size = new Size(638, 45);
            panel3.TabIndex = 6;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(50, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(568, 46);
            kryptonLabel1.StateCommon.LongText.Color1 = Color.Red;
            kryptonLabel1.StateCommon.Padding = new Padding(-1, 13, 450, 10);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.DimGray;
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.Red;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.ExtraText = "*";
            kryptonLabel1.Values.Text = "Last Name";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtEmployeeNumber);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 110);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(65, 5, 50, 30);
            panel2.Size = new Size(638, 79);
            panel2.TabIndex = 5;
            // 
            // txtEmployeeNumber
            // 
            txtEmployeeNumber.CueHint.Color1 = Color.DarkGray;
            txtEmployeeNumber.CueHint.CueHintText = "20##-#####";
            txtEmployeeNumber.CueHint.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeNumber.Dock = DockStyle.Fill;
            txtEmployeeNumber.Location = new Point(65, 5);
            txtEmployeeNumber.Name = "txtEmployeeNumber";
            txtEmployeeNumber.Size = new Size(523, 69);
            txtEmployeeNumber.StateCommon.Back.Color1 = SystemColors.ControlLight;
            txtEmployeeNumber.StateCommon.Border.Color1 = SystemColors.ControlLight;
            txtEmployeeNumber.StateCommon.Border.Color2 = SystemColors.ControlLight;
            txtEmployeeNumber.StateCommon.Border.Rounding = 3F;
            txtEmployeeNumber.StateCommon.Border.Width = 15;
            txtEmployeeNumber.StateCommon.Content.Color1 = Color.Black;
            txtEmployeeNumber.StateCommon.Content.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmployeeNumber.StateCommon.Content.Padding = new Padding(6, -1, -1, -1);
            txtEmployeeNumber.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(50, 5, 20, 20);
            panel1.Size = new Size(638, 110);
            panel1.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.Dock = DockStyle.Top;
            lblUsername.Location = new Point(50, 45);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(568, 63);
            lblUsername.StateCommon.LongText.Color1 = Color.Red;
            lblUsername.StateCommon.Padding = new Padding(-1, 30, 388, 10);
            lblUsername.StateCommon.ShortText.Color1 = Color.DimGray;
            lblUsername.StateCommon.ShortText.Color2 = Color.Red;
            lblUsername.StateCommon.ShortText.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.TabIndex = 2;
            lblUsername.Values.ExtraText = "*";
            lblUsername.Values.Text = "Employee Number ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 5);
            label1.Name = "label1";
            label1.Size = new Size(143, 40);
            label1.TabIndex = 0;
            label1.Text = "Sign-Up";
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
            pnlBackground.TabIndex = 2;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(pnlLogin);
            Controls.Add(pnlBackground);
            Name = "SignUp";
            Text = "SignUp";
            WindowState = FormWindowState.Maximized;
            pnlLogin.ResumeLayout(false);
            pnlLoginhere.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLogo;
        private Krypton.Toolkit.ButtonSpecAny btnShowHidePass;
        private Panel pnlLogin;
        private Krypton.Toolkit.KryptonPanel pnlBackground;
        private Panel pnlLoginhere;
        private Panel panel2;
        private Krypton.Toolkit.KryptonTextBox txtEmployeeNumber;
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel lblUsername;
        private Label label1;
        private Panel panel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Panel panel7;
        private Krypton.Toolkit.KryptonTextBox txtPassword;
        private Panel panel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Panel panel6;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Panel panel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Panel panel4;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Panel panel9;
        private Krypton.Toolkit.KryptonTextBox txtRePassword;
        private Panel panel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Panel panel11;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Panel panel12;
        private LinkLabel lnklblLogin;
        private Label label2;
        private Krypton.Toolkit.ButtonSpecAny btnShowHidePass2;
        private Krypton.Toolkit.ButtonSpecAny btnShowHidePass1;
    }
}