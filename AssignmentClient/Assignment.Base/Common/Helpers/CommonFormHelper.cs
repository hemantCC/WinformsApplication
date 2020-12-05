using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment.Base.Common.Helpers
{
    public class CommonFormHelper
    {
        /// <summary>
        /// Gets all form instances.
        /// </summary>
        /// <value>
        /// All form instances.
        /// </value>
        public static Dictionary<Type, Form> AllFormInstances { get; private set; } = new Dictionary<Type, Form>();

        /// <summary>
        /// Gets the form instance.
        /// </summary>
        /// <param name="formType">Type of the form.</param>
        /// <param name="mdiParent">The MDI parent.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        public static Form GetFormInstance(Type formType, Form mdiParent = null, params object[] parameters)
        {
            Form returnForm = null;
            if (AllFormInstances.ContainsKey(formType) && formType.Name != "VehicleAdd")
            {
                returnForm = AllFormInstances[formType];
                returnForm.Activate();
            }
            else if(AllFormInstances.ContainsKey(formType) && formType.Name == "VehicleAdd")
            {
               AllFormInstances[formType].Close();
                returnForm = CreateNewForm(formType, mdiParent, parameters);
            }
            else
            {
                returnForm = CreateNewForm(formType,mdiParent,parameters);
            }
            return returnForm;
        }

        /// <summary>
        /// Handles the form closing.
        /// </summary>
        /// <param name="formType">Type of the form.</param>
        public static void HandleFormClosing(Type formType)
        {
            if (AllFormInstances.ContainsKey(formType))
            {
                AllFormInstances.Remove(formType);
            }
        }

        /// <summary>
        /// Creates the new form.
        /// </summary>
        /// <param name="formType">Type of the form.</param>
        /// <param name="mdiParent">The MDI parent.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        private static Form CreateNewForm(Type formType, Form mdiParent, params object[] parameters)
        {
            AllFormInstances[formType] = Activator.CreateInstance(formType, parameters) as Form;
            if (mdiParent != null)
            {
                AllFormInstances[formType].MdiParent = mdiParent;
            }
            return AllFormInstances[formType];
        }
    }
}
