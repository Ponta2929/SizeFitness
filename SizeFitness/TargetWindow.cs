using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeFitness
{
    class TargetWindow : LayeredWindow
    {
        public TargetWindow()
        {
            this.Cursor = Cursors.NoMove2D;

            // アイコン設定
            SetLayeredWindow(Properties.Resources.target);
        }
    }
}
