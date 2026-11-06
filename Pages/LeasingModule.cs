using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace PMS_v1.Pages
{
    public partial class LeasingModule : UserControl
    {
        public LeasingModule()
        {
            // 1. Run the system designer file layout generator
            InitializeComponent();

            // 2. Wire the ambient 3D shadow directly onto the main module surface
            this.Paint += LeasingModule_Paint;

            // 3. Give the panel background transparency so the shadow shows through the gaps
            if (pnlCommandActionRow != null)
            {
                pnlCommandActionRow.BackColor = Color.Transparent;
            }
        }

        private void LeasingModule_Load(object sender, EventArgs e)
        {
            // Optional load actions go here
        }

        // 🎨 MASTER MODULE SURFACE SHADOW PAINTER
        private void LeasingModule_Paint(object sender, PaintEventArgs e)
        {
            if (pnlCommandActionRow == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Define the ambient shadow tones (Soft Alpha Gray fading to background color)
            Color shadowTop = Color.FromArgb(40, 0, 0, 0);         // slightly stronger 40% opacity shadow
            Color shadowBottom = Color.FromArgb(0, 244, 245, 247); // Fully transparent canvas edge

            // Calculate the exact bottom edge boundary line of your search container row
            int shadowYStart = pnlCommandActionRow.Bottom;
            int shadowHeight = 6;

            Rectangle shadowRect = new Rectangle(0, shadowYStart, this.Width, shadowHeight);

            // Render a seamless vertical gradient mask onto the background layer
            using (LinearGradientBrush brush = new LinearGradientBrush(
                shadowRect, shadowTop, shadowBottom, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, shadowRect);
            }
        }
    }
}
