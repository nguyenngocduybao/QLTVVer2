using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.HelperUI
{
    class HelperGUI
    {
        #region Instance
        private static HelperGUI instance;

        internal static HelperGUI Instance
        {
            get
            {
                if (instance == null) instance = new HelperGUI(); return HelperUI.HelperGUI.instance;
            }

            private set
            {
                HelperUI.HelperGUI.instance = value;
            }
        }
        #endregion
    }
}
