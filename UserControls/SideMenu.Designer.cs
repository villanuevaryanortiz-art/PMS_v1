namespace pms_UI.User_Controls
{
    partial class SideMenu
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
            pnlHead = new Panel();
            pnlDivider = new Panel();
            pnlFoot = new Panel();
            btnLogout = new Button();
            btnSettings = new Button();
            panel1 = new Panel();
            btnReports = new Button();
            btnMaintenance = new Button();
            btnPayment = new Button();
            btnBilling = new Button();
            btnLeasing = new Button();
            btnProperty = new Button();
            btnDashboard = new Button();
            pnlFoot.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHead
            // 
            pnlHead.BackColor = Color.Transparent;
            pnlHead.BackgroundImage = PMS_v1.Resources.Resources.Header_Logo;
            pnlHead.BackgroundImageLayout = ImageLayout.Center;
            pnlHead.Dock = DockStyle.Top;
            pnlHead.Location = new Point(0, 0);
            pnlHead.Name = "pnlHead";
            pnlHead.Size = new Size(290, 109);
            pnlHead.TabIndex = 0;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.Transparent;
            pnlDivider.BackgroundImage = PMS_v1.Resources.Resources.Divider;
            pnlDivider.BackgroundImageLayout = ImageLayout.Center;
            pnlDivider.Dock = DockStyle.Top;
            pnlDivider.Location = new Point(0, 109);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(290, 40);
            pnlDivider.TabIndex = 1;
            // 
            // pnlFoot
            // 
            pnlFoot.BackColor = Color.Transparent;
            pnlFoot.Controls.Add(btnLogout);
            pnlFoot.Controls.Add(btnSettings);
            pnlFoot.Dock = DockStyle.Bottom;
            pnlFoot.Location = new Point(0, 839);
            pnlFoot.Name = "pnlFoot";
            pnlFoot.Size = new Size(290, 186);
            pnlFoot.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = PMS_v1.Resources.Resources.Logout;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(0, 80);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(52, 0, 0, 0);
            btnLogout.Size = new Size(290, 80);
            btnLogout.TabIndex = 8;
            btnLogout.Text = " Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = PMS_v1.Resources.Resources.Settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(50, 0, 0, 0);
            btnSettings.Size = new Size(290, 80);
            btnSettings.TabIndex = 7;
            btnSettings.Text = "  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnReports);
            panel1.Controls.Add(btnMaintenance);
            panel1.Controls.Add(btnPayment);
            panel1.Controls.Add(btnBilling);
            panel1.Controls.Add(btnLeasing);
            panel1.Controls.Add(btnProperty);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 149);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 20, 0, 0);
            panel1.Size = new Size(290, 690);
            panel1.TabIndex = 3;
            // 
            // btnReports
            // 
            btnReports.Dock = DockStyle.Top;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.White;
            btnReports.Image = PMS_v1.Resources.Resources.Reports;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(0, 500);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(50, 0, 0, 0);
            btnReports.Size = new Size(290, 80);
            btnReports.TabIndex = 6;
            btnReports.Text = " Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnMaintenance
            // 
            btnMaintenance.Dock = DockStyle.Top;
            btnMaintenance.FlatAppearance.BorderSize = 0;
            btnMaintenance.FlatStyle = FlatStyle.Flat;
            btnMaintenance.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMaintenance.ForeColor = Color.White;
            btnMaintenance.Image = PMS_v1.Resources.Resources.Maintenance1;
            btnMaintenance.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.Location = new Point(0, 420);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Padding = new Padding(50, 0, 0, 0);
            btnMaintenance.Size = new Size(290, 80);
            btnMaintenance.TabIndex = 5;
            btnMaintenance.Text = " Maintenance";
            btnMaintenance.TextAlign = ContentAlignment.MiddleLeft;
            btnMaintenance.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Dock = DockStyle.Top;
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.ForeColor = Color.White;
            btnPayment.Image = PMS_v1.Resources.Resources.Payment1;
            btnPayment.ImageAlign = ContentAlignment.MiddleLeft;
            btnPayment.Location = new Point(0, 340);
            btnPayment.Name = "btnPayment";
            btnPayment.Padding = new Padding(51, 0, 0, 0);
            btnPayment.Size = new Size(290, 80);
            btnPayment.TabIndex = 4;
            btnPayment.Text = "  Payment";
            btnPayment.TextAlign = ContentAlignment.MiddleLeft;
            btnPayment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnBilling
            // 
            btnBilling.Dock = DockStyle.Top;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.White;
            btnBilling.Image = PMS_v1.Resources.Resources.bill1;
            btnBilling.ImageAlign = ContentAlignment.MiddleLeft;
            btnBilling.Location = new Point(0, 260);
            btnBilling.Name = "btnBilling";
            btnBilling.Padding = new Padding(52, 0, 0, 0);
            btnBilling.Size = new Size(290, 80);
            btnBilling.TabIndex = 3;
            btnBilling.Text = "  Billing";
            btnBilling.TextAlign = ContentAlignment.MiddleLeft;
            btnBilling.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBilling.UseVisualStyleBackColor = true;
            // 
            // btnLeasing
            // 
            btnLeasing.Dock = DockStyle.Top;
            btnLeasing.FlatAppearance.BorderSize = 0;
            btnLeasing.FlatStyle = FlatStyle.Flat;
            btnLeasing.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLeasing.ForeColor = Color.White;
            btnLeasing.Image = PMS_v1.Resources.Resources.Lease;
            btnLeasing.ImageAlign = ContentAlignment.MiddleLeft;
            btnLeasing.Location = new Point(0, 180);
            btnLeasing.Name = "btnLeasing";
            btnLeasing.Padding = new Padding(51, 0, 0, 0);
            btnLeasing.Size = new Size(290, 80);
            btnLeasing.TabIndex = 2;
            btnLeasing.Text = " Leasing";
            btnLeasing.TextAlign = ContentAlignment.MiddleLeft;
            btnLeasing.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLeasing.UseVisualStyleBackColor = true;
            // 
            // btnProperty
            // 
            btnProperty.Dock = DockStyle.Top;
            btnProperty.FlatAppearance.BorderSize = 0;
            btnProperty.FlatStyle = FlatStyle.Flat;
            btnProperty.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProperty.ForeColor = Color.White;
            btnProperty.Image = PMS_v1.Resources.Resources.Property;
            btnProperty.ImageAlign = ContentAlignment.MiddleLeft;
            btnProperty.Location = new Point(0, 100);
            btnProperty.Name = "btnProperty";
            btnProperty.Padding = new Padding(50, 0, 0, 0);
            btnProperty.Size = new Size(290, 80);
            btnProperty.TabIndex = 1;
            btnProperty.Text = " Properties";
            btnProperty.TextAlign = ContentAlignment.MiddleLeft;
            btnProperty.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProperty.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = PMS_v1.Resources.Resources.Icon;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 20);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(50, 0, 0, 0);
            btnDashboard.Size = new Size(290, 80);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = " Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // SideMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = PMS_v1.Resources.Resources.SideMenu;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(pnlFoot);
            Controls.Add(pnlDivider);
            Controls.Add(pnlHead);
            DoubleBuffered = true;
            Name = "SideMenu";
            Size = new Size(290, 1025);
            pnlFoot.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHead;
        private Panel pnlDivider;
        private Panel pnlFoot;
        private Panel panel1;
        private Button btnProperty;
        private Button btnDashboard;
        private Button btnBilling;
        private Button btnLeasing;
        private Button btnReports;
        private Button btnMaintenance;
        private Button btnPayment;
        private Button btnLogout;
        private Button btnSettings;
    }
}
