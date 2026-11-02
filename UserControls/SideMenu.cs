using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace pms_UI.User_Controls
{
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();

            // Normal color, hover color
            StyleButtons(this, Color.White, Color.FromArgb(215, 215, 215));   // greyish white
            // Different hover color for specific buttons
            StyleButton(btnLogout, Color.White, Color.FromArgb(235, 80, 90)); // red
        }

        // Styles every plain Button inside `root`
        private void StyleButtons(Control root, Color normal, Color hover)
        {
            foreach (Control c in root.Controls)
            {
                if (c is Button b) StyleButton(b, normal, hover);
                if (c.HasChildren) StyleButtons(c, normal, hover);
            }
        }

        private void StyleButton(Button b, Color normal, Color hover)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = Color.Transparent;
            b.BackColor = Color.Transparent;
            b.UseVisualStyleBackColor = false;
            b.Cursor = Cursors.Hand;
            b.ForeColor = normal;

            Image? src = b.Image;
            Image? normalImg = src != null ? Tint(src, normal) : null;
            Image? hoverImg = src != null ? Tint(src, hover) : null;
            if (normalImg != null) b.Image = normalImg;

            b.MouseEnter += (s, e) => { b.ForeColor = hover; if (hoverImg != null) b.Image = hoverImg; };
            b.MouseLeave += (s, e) => { b.ForeColor = normal; if (normalImg != null) b.Image = normalImg; };
        }

        // Recolors an image to one color, keeping its transparency
        private static Image Tint(Image src, Color color)
        {
            var bmp = new Bitmap(src.Width, src.Height);
            using (var g = Graphics.FromImage(bmp))
            using (var attrs = new ImageAttributes())
            {
                attrs.SetColorMatrix(new ColorMatrix(new float[][]
                {
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 0, 0 },
                new float[] { 0, 0, 0, 1, 0 },
                new float[] { color.R / 255f, color.G / 255f, color.B / 255f, 0, 1 }
                }));
                g.DrawImage(src, new Rectangle(0, 0, src.Width, src.Height),
                            0, 0, src.Width, src.Height, GraphicsUnit.Pixel, attrs);
            }
            return bmp;
        }
    }
}
