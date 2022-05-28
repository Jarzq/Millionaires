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
    public partial class FormGameOver : Form
    {
        private readonly int wonAmount;

        public FormGameOver(int wonAmount)
        {
            InitializeComponent();
            this.wonAmount = wonAmount;
        }

        private void buttonPlayAgain_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form formMain = new FormMain();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();
        }

        private void FormGameOver_Load(object sender, EventArgs e)
        {
            labelPrizeWon.Text = $"Gratulacje wygrales {wonAmount}$";
        }
    }
}
