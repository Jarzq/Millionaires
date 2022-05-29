using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektTest
{
    public delegate void Notify();  
    class Clock
    {
       
        public event Notify EndOfTime; 
        public void Draw(Graphics g, float tick, Label labelClock)
        {
            
            g.DrawEllipse(Pens.Black, 15, 15, 80, 80);
            g.TranslateTransform(55,55);
            g.RotateTransform(180);
            g.RotateTransform(tick);
            g.FillRectangle(Brushes.Red, 0 ,0 , 3, 40);
            
            labelClock.Text = (60-(int)(tick / 6)).ToString();

            if(tick/6 > 60)
                EndOfTime?.Invoke();

        }
    }
}
