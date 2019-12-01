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
    public class Circle: Shape
    {
        /// <summary>
        /// 
        /// </summary>
        public int r, x, y;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void ValueSaved(int a, int b, int c) {
            x = a;
            y = b;
            r = c;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public override void ShapeDraw(Graphics g)
        {
            Pen testCircle = new Pen(Color.Black,3);
            g.DrawEllipse(testCircle, x, y, r, r);
        }
    }
}
