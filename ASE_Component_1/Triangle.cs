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
    public class Triangle:Shape
    {
        /// <summary>
        /// 
        /// </summary>
        public int x,y, CircleBase, CirclePer;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
            public void SavedValues(int a,int b, int c, int d)
        {
            x = a;
            y = b;
            CircleBase = c;
            CirclePer = d;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public override void ShapeDraw(Graphics g)
        {
            Pen triangleNew = new Pen(Color.Black, 3);
            PointF A = new PointF(x, y);
            PointF B = new PointF(x + CirclePer, y);
            PointF C = new PointF(B.X, B.Y + CirclePer);
            PointF[] bro = { A, B, C };
            g.DrawPolygon(triangleNew, bro);
        }
    }
}