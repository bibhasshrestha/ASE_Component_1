using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstComponent
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// 
        /// </summary>
       
        public int x, y, z, h;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public void saved_values(int a, int b, int c, int d)
        {
            x = a;
            y = b;
            z = c;
            h = d;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public override void ShapeDraw(Graphics g)
        {
            Pen rectangleNew = new Pen(Color.Black, 3);
            g.DrawRectangle(rectangleNew, x, y, z, h);
        }
    }
}
