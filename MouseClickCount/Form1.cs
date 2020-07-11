using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClickCount
{
    public partial class Form1 : Form
    {
        int timer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer++;
            label1.Text = $"Mouse Click {timer} Time";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer = 0;
            label1.Text = $"Mouse Click {timer} Time";
        }
    }
}
