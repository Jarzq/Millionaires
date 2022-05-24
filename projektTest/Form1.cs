using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektTest
{
    public partial class FormMain : Form
    {
        Clock clock = new Clock();
        public float  tick=0;
        int k = 0;
  
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            clock.Draw(e.Graphics, tick, labelClock);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick+=0.4f;
            Refresh();
        }

       

        private void labelQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
