namespace pms_UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            sideMenu1 = new pms_UI.User_Controls.SideMenuFull();
            sideMenuCompact1 = new PMS_v1.UserControls.SideMenuCompact();
            pnlRight = new Panel();
            pnlContent = new Panel();
            header1 = new PMS_v1.UserControls.Header();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenu1
            // 
            sideMenu1.BackgroundImage = (Image)resources.GetObject("sideMenu1.BackgroundImage");
            sideMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            sideMenu1.Dock = DockStyle.Left;
            sideMenu1.Location = new Point(0, 0);
            sideMenu1.Name = "sideMenu1";
            sideMenu1.Size = new Size(290, 977);
            sideMenu1.TabIndex = 0;
            // 
            // sideMenuCompact1
            // 
            sideMenuCompact1.Dock = DockStyle.Left;
            sideMenuCompact1.Location = new Point(290, 0);
            sideMenuCompact1.Name = "sideMenuCompact1";
            sideMenuCompact1.Size = new Size(89, 977);
            sideMenuCompact1.TabIndex = 2;
            sideMenuCompact1.Visible = false;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(pnlContent);
            pnlRight.Controls.Add(header1);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(379, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1043, 977);
            pnlRight.TabIndex = 3;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 75);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1043, 902);
            pnlContent.TabIndex = 1;
            // 
            // header1
            // 
            header1.Dock = DockStyle.Top;
            header1.Location = new Point(0, 0);
            header1.Name = "header1";
            header1.Size = new Size(1043, 75);
            header1.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(pnlRight);
            Controls.Add(sideMenuCompact1);
            Controls.Add(sideMenu1);
            Name = "Main";
            Text = "BaktuTenant";
            WindowState = FormWindowState.Maximized;
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.SideMenuFull sideMenu1;
        private PMS_v1.UserControls.SideMenuCompact sideMenuCompact1;
        private Panel pnlRight;
        private Panel pnlContent;
        private PMS_v1.UserControls.Header header1;
    }
}
