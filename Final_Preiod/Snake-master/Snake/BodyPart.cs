using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    // 從 GamePart 拉過來
    class BodyPart : GamePart {

        public Direction m_Dir {
            get;
            set;
        }

        // 物件生成
        public BodyPart(int X,int Y,Direction Dir) : base(X,Y) {
            m_Dir = Dir;
        }
        
        // 初始化物件
        public BodyPart(int X, int Y):base(X,Y) {
            m_Dir = Direction.none;
        }
    }
}
