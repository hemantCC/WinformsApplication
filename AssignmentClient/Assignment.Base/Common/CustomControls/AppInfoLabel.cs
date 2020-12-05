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
    public partial class AppInfoLabel : Label
    {
        public AppInfoLabel()
        {
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.Font = new Font("Microsoft Sans Serif", 10);
            base.OnPaint(pe);
        }
    }
}
