using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class MatrixxxSymbooooooooooooooooools
    {
        public PointF pf;

        public char val;
        public Color c;
        public int FSize;
        int FSpeed;
        int ChangeRate;
        

        public MatrixxxSymbooooooooooooooooools(PointF start, int size, int speed, Random r)
        {
            pf = start;
            FSize = size;
            FSpeed = speed;

            ChangeRate = r.Next(15, 75);
            val = (char)0x30A0;
            c = Color.Gray;
        }
        public void ResetHeight()
        {
            pf.Y = -FSize;
        }

        public bool CheckBordeer(float h)
        {
            return pf.Y > h + FSize;
        }

        public void Move()
        {
            pf.Y += FSpeed;
        }
        public void Change(int CurrrentFrame)
        {
            Random r = new Random();
            switch (r.Next(1, 7))
            {
                case 1:
                    if (c.G < 240)
                        c = Color.FromArgb(c.R, c.G + 10, c.B);
                    break;
                case 2:
                    if (c.B < 240)
                        c = Color.FromArgb(c.R, c.G, c.B + 10);
                    break;
                case 3:
                    if (c.R < 240)
                        c = Color.FromArgb(c.R + 10, c.G, c.B);
                    break;
                case 4:
                    if (c.G > 10)
                        c = Color.FromArgb(c.R, c.G - 10, c.B);
                    break;
                case 5:
                    if (c.B > 10)
                        c = Color.FromArgb(c.R, c.G, c.B - 10);
                    break;
                case 6:
                    if (c.R > 10)
                        c = Color.FromArgb(c.R - 10, c.G, c.B);
                    break;
            }
            if (CurrrentFrame % ChangeRate == 0)
            {
                val = (char)r.Next(0x30A9, 0x30F0);
            }
        }
    }
}












