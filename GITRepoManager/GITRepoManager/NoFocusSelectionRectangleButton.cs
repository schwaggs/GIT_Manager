﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITRepoManager
{
    class NoFocusSelectionRectangleButton : Button
    {
        public NoFocusSelectionRectangleButton()
        {

        }

        public override void NotifyDefault(bool value)
        {
            base.NotifyDefault(false);
        }
    }
}
