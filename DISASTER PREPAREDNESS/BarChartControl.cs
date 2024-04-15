using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DISASTER_PREPAREDNESS
{
    public partial class BarChartControl : UserControl
    {

        public List<int> DataValues { get; set; }
        public List<string> Labels { get; set; }
        public Color BarColor { get; set; }

        // Constructor
     
        public BarChartControl()
        {
            InitializeComponent();
            this.Paint += BarChartControl_Paint;
            DataValues = new List<int>();
            Labels = new List<string>();
            BarColor = Color.Blue; // Default color
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (DataValues == null || DataValues.Count == 0)
                return;

            Graphics g = e.Graphics;
            g.Clear(BackColor);

            // Determine the dimensions of the chart area
            int chartWidth = ClientSize.Width;
            int chartHeight = ClientSize.Height;
            int barWidth = chartWidth / DataValues.Count;

            using (SolidBrush brush = new SolidBrush(BarColor))
            {
                // Draw each bar in the chart
                for (int i = 0; i < DataValues.Count; i++)
                {
                    int barHeight = (int)((float)DataValues[i] / DataValues.Max() * chartHeight);
                    int x = i * barWidth;
                    int y = chartHeight - barHeight;
                    Rectangle barRect = new Rectangle(x, y, barWidth, barHeight);
                    g.FillRectangle(brush, barRect);
                }
            }
        }



        private void BarChartControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
