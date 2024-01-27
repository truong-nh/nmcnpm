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
    public class SPanel : Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            //setFillColor(Color.AliceBlue);
            Graphics g = e.Graphics;
            //Console.WriteLine(e.Graphics.GetType());
            g.SmoothingMode = SmoothingMode.AntiAlias;
            /*g.FillRoundedRectangle(new SolidBrush(Color.Black), 0, 0, this.Width, this.Height , 10);
            SolidBrush brush = new SolidBrush(
                Color.White
                );
            
             g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.White, 0.00f)), 12, 12, this.Width - 44, this.Height - 64, 10);
             */
             /*g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 64, 10);

             g.FillRoundedRectangle(new SolidBrush(Color.White), 12, 12 + ((this.Height - 64) / 2), this.Width - 44, (this.Height - 64) / 2, 10);
            */
        }
        public void setFillColor(Color color)
        {
            //Console.WriteLine("11" + color);
            Graphics g = this.CreateGraphics();
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(color), 0, 0, this.Width, this.Height, 15);
        }
    }
}
