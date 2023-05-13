using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPMS.Classes
{
    public class NavigationEventArgs : EventArgs
    {
        public Form NavigatingForm { get; set; }
        public Form CallerForm { get; set; }
        public NavigationEventArgs(Form navigatingForm, Form callerForm)
        {
            NavigatingForm = navigatingForm;
            CallerForm = callerForm;
        }

    }
}
