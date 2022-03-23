using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuget_GUI.Controls
{
    public class EditButton:Button
    {
        public bool Edit { get; private set; }


        public void ToEditMode()
        {
            if (!Edit)
            {
                //tbServer.Enabled = true;
                Text = "Edit";
                Edit = true;
            }

        }
        public void ToSaveMode()
        {
            if (Edit)
            {
                Text = "Save";
                Edit = false;
            }
        }
    }
}
