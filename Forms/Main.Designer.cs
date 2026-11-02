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
            sideMenu1 = new pms_UI.User_Controls.SideMenu();
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(sideMenu1);
            Name = "Main";
            Text = "BaktuTenant";
            ResumeLayout(false);
        }

        #endregion

        private User_Controls.SideMenu sideMenu1;
    }
}
