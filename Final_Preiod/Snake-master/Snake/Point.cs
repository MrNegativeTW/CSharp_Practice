using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    // 座標處理系統
    class Point
    {
        public int X {
            get;
            set;
        }

        public int Y {
            get;
            set;
        }

        // 物件生成
        public Point(int X,int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
