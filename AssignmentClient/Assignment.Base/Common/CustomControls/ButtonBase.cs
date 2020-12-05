using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Base.Common.CustomControls
{
    public partial class ButtonBase : Button
    {

        private Color _gradientColor1 = Color.ForestGreen;   // first color
        private Color _gradientColor2 = Color.ForestGreen;   // second color
        private int _gradientTransparent1 = 64;              // transparency degree (applies to the 1st color)
        private int _gradientTransparent2 = 64;      // transparency degree  (applies to the 2nd color)
                                                     // (applies to the 2nd color)

        public ButtonBase()
        {
            InitializeComponent();
        }

        public Color GradientColor1
        {
            get { return _gradientColor1; }
            set { _gradientColor1 = value; Invalidate(); }
        }

        public Color GradientColor2
        {
            get { return _gradientColor2; }
            set { _gradientColor2 = value; Invalidate(); }
        }

        public int GradientTransparent1
        {
            get { return _gradientTransparent1; }
            set { _gradientTransparent1 = value; Invalidate(); }
        }

        public int GradientTransparent2
        {
            get { return _gradientTransparent2; }
            set { _gradientTransparent2 = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);                                                       // Calling the base class OnPaint
           
            Color c1 = Color.FromArgb(_gradientTransparent1, _gradientColor1);      // Create two semi-transparent colors
            Color c2 = Color.FromArgb(_gradientTransparent1, _gradientColor2);
            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, 10);
            pe.Graphics.FillRectangle(b, ClientRectangle);
            b.Dispose();
        }
    }
}
