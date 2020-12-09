using Assignment.Base.Common.Helpers;
using Assignment.Vehicle;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Assignment.Main.UI.Forms
{
    public partial class HomeMdiContainer : Form
    {
        /// <summary>
        /// The executing assembly instance
        /// </summary>
        private readonly Assembly _assembly = Assembly.GetExecutingAssembly();

        public HomeMdiContainer()
        {
            InitializeComponent();
            InitializeAllForms();
        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormHelper.GetFormInstance(typeof(Vehicles), this).Show();
        }

        /// <summary>
        /// Initializes all forms.
        /// </summary>
        private void InitializeAllForms()
        {
            AssemblyName[] allAssemblies = _assembly.GetReferencedAssemblies().Where(assembly => assembly.FullName.Contains("Assignment.")).ToArray();
            foreach (AssemblyName assembly in allAssemblies)
            {
                Type[] types = Assembly.Load(assembly).GetTypes();
                foreach (Type type in types)
                {
                    if (type.BaseType == typeof(Form))
                    {
                        CommonFormHelper.AllFormInstances[type] = Activator.CreateInstance(type) as Form;
                        if (type == typeof(Vehicles))
                        {
                            CommonFormHelper.AllFormInstances[type].MdiParent = this;
                        }
                    }
                }
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonFormHelper.GetFormInstance(typeof(ChangePassword), this).Show();
        }
    }
}
