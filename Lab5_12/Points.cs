using System;
using System.Windows.Forms;

namespace Graphics3DLab
{
    public class Points
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        
        public Points() { }
        public Points(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
}