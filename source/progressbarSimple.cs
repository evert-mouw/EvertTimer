using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// inspired by:
// http://www.daveandrews.org/programeasy/index.php?m=4

namespace EvertTimer
{
    public partial class progressbarSimple : UserControl
    {
        public progressbarSimple()
        {
            InitializeComponent();
        }

        protected Color barcolor = SystemColors.Highlight;

        public override Color ForeColor
        {
            get
            {
                return barcolor;
            }
            set
            {
                barcolor = value;
                this.Invalidate();
            }
        }

        protected float percent = 0;

        public int Percentage
        {
            get
            {
                return (int)percent;
            }
            set
            {
                // constrain value to between
                // 0 and 100
                if (value < 0) value = 0;
                if (value > 100) value = 100;
                percent = value;
                this.Invalidate();
            }
        }

        protected int max = 100;

        public int Maximum
        {
            get
            {
                return max;
            }
            set
            {
                max = value;
                percent = curvalue / value * 100;
                this.Invalidate();
            }
        }

        protected int curvalue = 0;

        public int Value
        {
            get
            {
                return curvalue;
            }
            set
            {
                if (value < 0) value = 0;
                if (value > max) value = max;
                curvalue = value;
                percent = (float)(((float)curvalue / (float)max) * 100);
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Brush b = new SolidBrush(barcolor);

            // calculate width of progress bar filler in pixels
            int width = (int)(((percent / 100) * this.Width));

            // draw the progress bar
            e.Graphics.FillRectangle(b, this.Width-width, 0, width, this.Height);

            b.Dispose();
        }
    }


}
