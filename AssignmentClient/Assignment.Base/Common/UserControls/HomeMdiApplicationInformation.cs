using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Base.Common.UserControls
{
    public partial class HomeMdiApplicationInformation : UserControl
    {
        public HomeMdiApplicationInformation()
        {
            InitializeComponent();
            appInfoValueLabelVersion.Text = "V " + Versions.MajorVersion + "." + Versions.MinorVersion + "." + Versions.PatchVersion;
        }
    }
}
