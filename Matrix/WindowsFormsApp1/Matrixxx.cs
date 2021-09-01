using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    class Matrixxx
    {

        Font f;
        Graphics g;
        Bitmap b;
        float Height;
        float Width;
        int CurrentFrame;

        MatrixxxSymbooooooooooooooooools[,] msym;

        public Matrixxx(PictureBox p)
        {
            g = p.CreateGraphics();
            b = new Bitmap(p.Width, p.Height);
            g = Graphics.FromImage(b);
            Height = p.Height;
            Width = p.Width;

            int s = 28;

            f = new Font("Arial Unicode", s, FontStyle.Regular);
            CurrentFrame = 0;
            
            Random r = new Random();
            msym = new MatrixxxSymbooooooooooooooooools[(int)Width / s, (int)Height / s];
            for (int i = 0; i < (int)Width / s; i++)
            {
                int spd = r.Next(2, 6);
                for (int j = 0; j < (int)Height / s; j++)
                {
                    PointF startP = new PointF(i * s, j * s + 5);
                    msym[i, j] = new MatrixxxSymbooooooooooooooooools(startP, s, spd, r);
                }

            }

        }
        public void Twist_Matrix(int x, int y)
        {
            foreach(MatrixxxSymbooooooooooooooooools m in msym)
            {
                m.pf.X += x;
                m.pf.Y += y;
                //if (x == )

            }
        }
        



        private void Move()
        {
            foreach (MatrixxxSymbooooooooooooooooools m in msym)
            {
                m.Move();
                Random r = new Random();
                m.Change(CurrentFrame);
                if(m.CheckBordeer(Height))
                {
                    m.ResetHeight();
                }

            }
        }
        public Image Show()
        {
            CurrentFrame++;

            //g.Clear(Color.Black);
            g.FillRectangle(new SolidBrush(Color.FromArgb(60, 0, 0, 0)),0,0, b.Width, b.Height);
            foreach (MatrixxxSymbooooooooooooooooools m in msym)
            {
                SolidBrush sb = new SolidBrush(m.c);
                g.DrawString(m.val.ToString(), f, sb, m.pf);
                
            }
            Move();
            
            return b;
        }
        
    }
}
