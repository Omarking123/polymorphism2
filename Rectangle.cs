using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass03
{
    #region -2
    internal class Rectangle
    {

        public int width { get; set; }
        public int height { get; set; }

        public Rectangle()
        {
            this.width = 0;
            this.height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int size)
        {
            this.width = size;
            this.height = size;
        }
    } 
    #endregion
}
