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
            Graphics g = this.CreateGraphics();
            g.FillRectangle(Brushes.Black, 100, 100, 200, 200);
        }
        
    }
}
