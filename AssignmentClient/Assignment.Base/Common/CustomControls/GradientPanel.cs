using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Base.Common.CustomControls
{
    public partial class GradientPanel : Panel
    {
        public GradientPanel()
        {
            InitializeComponent();
            PaintGradient();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            // TODO: Add custom paint code here

            // Calling the base class OnPaint
            base.OnPaint(pe);
        }
        private void PaintGradient()
        {

            LinearGradientBrush gradBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(this.Width, this.Height),
                Color.MediumPurple,
                Color.Cyan);

            Bitmap bmp = new Bitmap(this.Width, this.Height);

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(gradBrush, new Rectangle(0, 0, this.Width, this.Height));
            this.BackgroundImage = bmp;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
