using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISASTER_PREPAREDNESS
{
    public class RoundShadowView : Panel
    {

        public RoundShadowView()
        {
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a rounded rectangle path
            GraphicsPath path = new GraphicsPath();
            int radius = 15; // Adjust the radius to control the roundness
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            // Draw the rounded rectangle
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Add drop shadow
            int shadowDepth = 5; // Adjust the shadow depth
            Rectangle shadowRect = new Rectangle(this.Location.X + shadowDepth, this.Location.Y + shadowDepth, this.Width, this.Height);
            ControlPaint.DrawBorder(e.Graphics, shadowRect, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
