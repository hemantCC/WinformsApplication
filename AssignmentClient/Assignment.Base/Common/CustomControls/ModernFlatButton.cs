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
    public partial class ModernFlatButton : Button
    {
        public ModernFlatButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.Width = 110;
            this.Height = 31;
            this.Font = new Font("Segoe UI", 10);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
