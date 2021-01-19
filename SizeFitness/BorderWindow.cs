using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SizeFitness
{
    public partial class BorderWindow : Form
    {
        private Pen pen = new(Brushes.Red, 3);

        public BorderWindow()
        {
            InitializeComponent();          
        }

        private void BorderWindow_Paint(object sender, PaintEventArgs e)
        {
            var rect = ClientRectangle;
            e.Graphics.DrawRectangle(pen, new Rectangle(rect.X, rect.Y, rect.Width - 1, rect.Height - 1));
        }

        private void BorderWindow_Resize(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
