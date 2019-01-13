using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 大括號怎麼都是在新行zzzzz -w
namespace Snake
{
    // 遊戲圖像核心
    class GamePart
    {
        private Point Position;

        // 取得和回傳座標
        public Point GetPosition() {
            return Position;
        }

        // 座標
        public void AddPosition(Point point) {
   
            Position.X += point.X;
            Position.Y += point.Y;
        }

        // 設定座標
        public void SetPosition(Point point) {
    
            Position = point;
        }

        // 物件生成
        public GamePart(int X,int Y) {
            Position = new Point(X,Y);
        }
    }
}
