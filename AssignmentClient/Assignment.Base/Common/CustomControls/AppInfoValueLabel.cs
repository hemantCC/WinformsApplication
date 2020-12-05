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
    public partial class AppInfoValueLabel : Label
    {
        public AppInfoValueLabel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Font = new Font("Microsoft Sans Serif", 9);
            base.OnPaint(pe);
        }
    }
}
