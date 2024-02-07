using System;
using System.Drawing;
using System.Windows.Forms;
using Graphics3DLab;

namespace Lab5_7
{
    public partial class Form1 : Form
    {
        private Bitmap image;
        public Form1()
        {
            InitializeComponent();
        }

        private void GrafikaForm_Load(object sender, EventArgs e)
        {
            image = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            pictureBox.Image = image;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Draw();
        }

        public Points Conversion(Points vector)
        {

            double x = vector.X, y = vector.Y, z = vector.Z;

            double deg = Math.PI / 180;

            //перемещение
            x = x + ofxTrackBar.Value;
            y = y + ofyTrackBar.Value;
            z = z + ofzTrackBar.Value;

            double x0, y0 = y, z0 = z;
            //поворот вокруг X
            y = y0 * Math.Cos(rxTrackBar.Value * deg) - z0 * Math.Sin(rxTrackBar.Value * deg);
            z = y0 * Math.Sin(rxTrackBar.Value * deg) + z0 * Math.Cos(rxTrackBar.Value * deg);

            x0 = x;
            z0 = z;
            //поворот вокруг Y
            x = x0 * Math.Cos(ryTrackBar.Value * deg) + z0 * Math.Sin(ryTrackBar.Value * deg);
            z = -x0 * Math.Sin(ryTrackBar.Value * deg) + z0 * Math.Cos(ryTrackBar.Value * deg);

            x0 = x;
            y0 = y;
            //поворот вокруг Z
            x = x0 * Math.Cos(rzTrackBar.Value * deg) - y0 * Math.Sin(rzTrackBar.Value * deg);
            y = x0 * Math.Sin(rzTrackBar.Value * deg) + y0 * Math.Cos(rzTrackBar.Value * deg);

            x0 = x;
            y0 = y;
            z0 = z;

            //проецирование (аксонометрическое)
            double angleB = -45 * deg;
            double angleA = -45 * deg;
            x = x0 * Math.Cos(angleA) + y0 * Math.Sin(angleA);
            y = -x0 * Math.Sin(angleA) * Math.Cos(angleB) + y0 * Math.Cos(angleA) * Math.Cos(angleB) + z0 * Math.Sin(angleB);
            z = x0 * Math.Sin(angleA) * Math.Sin(angleB) - y0 * Math.Cos(angleA) * Math.Sin(angleB) + z0 * Math.Cos(angleB);

            //масштабирование
            x = 4*x * sTrackBar.Value;
            y = 4*y * sTrackBar.Value;
            z = 4*z * sTrackBar.Value;

            //сдвиг
            x = x + pictureBox.ClientSize.Width / 2;
            y = y + pictureBox.ClientSize.Height / 2;


            return new Points(x, y, z);
        }

        private void Draw()
        {
            Graphics g = Graphics.FromImage(image); 
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black);

            Points[,] vertices = new Points[31, 31];


            for (int i = 0; i < 31; i++)
            {
                double r = 1;
                double H = 6;
                for (int j = 0; j < 31; j++)
                {

                    double a = j * 12 * (Math.PI / 180);
                    double k = Convert.ToDouble(Convert.ToDouble(1m / 2m) *
                        (-1) + (Convert.ToDouble(1m / 30m) * i));

                    double x = r * (1 + Math.Abs(Math.Sin(2 * k * Math.PI +
                        (Convert.ToDouble(1m / 2m) * a)))) * Math.Sin(a);
                    double y = r * (1 + Math.Abs(Math.Sin(2 * k * Math.PI +
                        (Convert.ToDouble(1m / 2m) * a)))) * Math.Cos(a);
                    double z = H * k;



                    vertices[i, j] = Conversion(new Points(x, y, z));

                }

            }

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    g.DrawLines(pen, new[]
                    {
                        new Point((int) vertices[i, j].X, (int) vertices[i, j].Y),
                        new Point((int) vertices[i, j + 1].X, (int) vertices[i, j + 1].Y),
                        new Point((int) vertices[i + 1, j + 1].X, (int) vertices[i + 1, j + 1].Y),
                        new Point((int) vertices[i + 1, j].X, (int) vertices[i + 1, j].Y)
                    });
                }
            }
            pictureBox.Refresh();
        }
    }
}
