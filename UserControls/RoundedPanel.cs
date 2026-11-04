using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace PMS_v1
{
    public class RoundedPanel : Panel
    {
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public int CornerRadius { get; set; } = 12;
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color BorderColor { get; set; } = Color.FromArgb(230, 230, 230);
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public int BorderThickness { get; set; } = 1;
        [Category("Appearance")][DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] public Color FillColor { get; set; } = Color.White;

        public RoundedPanel()
        {
            SetStyle(ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;   // shows the parent's color in the corners
            Padding = new Padding(10);       // keeps children away from the curved corners
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundRect(rect, CornerRadius))
            using (var fill = new SolidBrush(FillColor))
            using (var pen = new Pen(BorderColor, BorderThickness))
            {
                e.Graphics.FillPath(fill, path);
                if (BorderThickness > 0) e.Graphics.DrawPath(pen, path);
            }
            base.OnPaint(e);
        }

        private static GraphicsPath RoundRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

}