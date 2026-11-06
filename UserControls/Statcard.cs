using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PMS_v1.UserControls
{
    public partial class Statcard : UserControl
    {
        public Statcard()
        {
            InitializeComponent();
        }

        [Category("Custom Properties")]
        [Description("Sets the big counter number on the stat card.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CardNumber
        {
            get => lblValue.Text;
            set { lblValue.Text = value; lblValue.Invalidate(); }
        }

        [Category("Custom Properties")]
        [Description("Sets the bottom description text on the stat card.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string CardCaption
        {
            get => label1.Text;
            set { label1.Text = value; label1.Invalidate(); }
        }

        [Category("Custom Properties")]
        [Description("Sets the card icon graphic safely inside its designated left slot.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image CardIcon
        {
            get
            {
                // Return the image if pictureBox1 is initialized
                if (this.pictureBox1 != null) return this.pictureBox1.Image;
                return null;
            }
            set
            {
                // 1. Wipe out any accidental background bleeds from your parent panels
                if (this.roundedPanel1 != null) this.roundedPanel1.BackgroundImage = null;
                if (this.panel1 != null) this.panel1.BackgroundImage = null;
                this.BackgroundImage = null;

                // 2. Lock the image strictly inside your classmate's picture box
                if (this.pictureBox1 != null)
                {
                    this.pictureBox1.Image = value;

                    // 🎯 Clean alignment trick: Centers and scales the icon without clipping
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pictureBox1.Invalidate();
                }

                this.Invalidate();
            }
        }

    }
}
