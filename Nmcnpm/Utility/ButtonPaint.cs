using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom5.Utility
{
    public static class ButtonPaint
    {
        static GraphicsPath GetRoundRectangle(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        public static void customButton_Paint(object sender, PaintEventArgs e)
        {
            Button button = (Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle bounds = new Rectangle(0, 0, button.Width, button.Height);
            GraphicsPath path = GetRoundRectangle(bounds, 10); // 20 là bán kính của góc tròn
            Region region = new Region(path);
            button.Region = region;
        }

        public static void RoundedBtn_Load(Control sender)
        {
            if (sender is Button)
            {
                sender.Paint += customButton_Paint;
            }
            else if (sender.Controls.Count != 0)
                foreach (Control control in sender.Controls)
                {
                    RoundedBtn_Load(control);
                }

        }
    }
}
