using System;

namespace MyLib
{
    public class RadiusVector
    {
        ///Coordinates
        private double x, y;

        //Cos from scalar product
        public double Cos { get
            {
                return Math.Abs(x) / Math.Sqrt(x * x + y * y);
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x">X coord</param>
        /// <param name="y">Y coord</param>
        public RadiusVector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
