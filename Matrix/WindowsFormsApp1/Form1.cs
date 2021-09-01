using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SoundPlayer sp;
        Matrixxx m;
        bool b;

        public Form1()
        {
            InitializeComponent();
            m = new Matrixxx(pictureBox1);
            sp = new SoundPlayer();
            sp.Stream = Properties.Resources.chlen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b)
            {
                pictureBox1.Image = m.Show();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.M:
                    b = !b;
                    sp.Play();
                    break;
                case (char)Keys.A:
                    m.Twist_Matrix(-10,0);
                    break;
                case (char)Keys.D:
                    m.Twist_Matrix(+10,0);
                    break;
                case (char)Keys.W:
                    m.Twist_Matrix(0,+10);
                    break;
                case (char)Keys.S:
                    m.Twist_Matrix(0,-10);
                    break;
                case (char)Keys.N:
                    b = !b;
                    sp.Play();
                    break;
            }
        }
    }
}