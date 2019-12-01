using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FirstComponent
{
    /// <summary>
    /// 
    /// </summary>
   public abstract class Shape
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        public abstract void ShapeDraw(Graphics g);
    }
}