using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RectangleService
{
    public class RectangleService
    {
        public Point getRectangleLocation(double centerX, double centerY, double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                return new Point((int)centerX, (int)centerY);
            }

            return new Point((int)Math.Floor(centerX - width / 2), (int)Math.Floor(centerY - height / 2));
        }
    }
}
