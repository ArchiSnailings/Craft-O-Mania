using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craftings
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Refresh();
        }

        private void OnPaint(object sender, PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            g.FillRectangle(Brushes.Black, 0, 0, 100, 100);
        }
    }
}
