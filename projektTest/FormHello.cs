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
    public partial class FormHello : Form
    {
        
        public FormHello()
        {
            InitializeComponent();
        }

        private void buttonStartGame_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormMain form = new FormMain();
            form.Closed += (s, args) => this.Close();
            form.Show();

        }
    }
}
