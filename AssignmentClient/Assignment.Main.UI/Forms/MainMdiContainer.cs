using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Main.UI.Forms
{
    public partial class MainMdiContainer : Form
    {
        public MainMdiContainer()
        {
            InitializeComponent();
            ShowLoginForm();
        }

        private void ShowLoginForm()
        {
            Login login = new Login(this);
            login.MdiParent = this;
            login.Dock = DockStyle.Fill;
            login.Show();
        }
    }
}
