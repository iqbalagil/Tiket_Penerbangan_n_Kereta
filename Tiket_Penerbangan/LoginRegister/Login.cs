using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiket_Penerbangan.LoginRegister
{
    public partial class Login : Form
    {

        float animationStep, totalStep = 20;
        Color startColor, endColor;
        public Login()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            OnEnterLeave(guna2TextBox1, true);
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            OnEnterLeave(guna2TextBox1, false);
        }

        private void OnEnterLeave(object placeholder, bool isEntering)
        {
            animationStep = 0;
            timer1.Interval = 50;

            if(placeholder is Guna2TextBox tb)
            { 
                  startColor = tb.BorderColor;
                  endColor = isEntering ? Color.DodgerBlue : Color.FromArgb(213, 218, 223) ;
                  timer1.Start();
            }

            timer1.Tick += Timer1_Tick;
        }

        void Timer1_Tick(object placeholder, EventArgs e)
        {
            float ratio = (float)animationStep / totalStep;
            int r = (int)(startColor.R + ratio * (endColor.R - startColor.R));
            int g = (int)(startColor.G + ratio * (endColor.G - startColor.G));
            int b = (int)(startColor.B + ratio * (endColor.B - startColor.B));

            if(placeholder is Guna2TextBox gn)
            {
                gn.BorderColor = Color.FromArgb(r, g, b);
            }
            animationStep++;

            if (animationStep > totalStep) timer1.Stop();
        }
    }
}
