using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace UCB
{
    public static class CustomPanel
    {
        public static void RoundBounds(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddLine(radius, 0, panel.Width - radius, 0);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddLine(panel.Width - radius, panel.Height, radius, panel.Height);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, panel.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            panel.Region = new Region(path);
        }
    }
}
