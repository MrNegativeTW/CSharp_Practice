using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    // 食物生成系統
    class FoodManager
    {
        private Random r = new Random();

        //確認還活著的食物
        private List<FoodPellet> m_FoodPellets = new List<FoodPellet>();

        //食物大小
        private const int m_CircleRadius = 20; // Determines food pellet size

        //以 Pixel 表示大小單位，確保不會超出畫
        private int m_GameWidth;
        private int m_GameHeight;

        // 物件生成
        public FoodManager(int GameWidth,int GameHeight)
        {
            //寬度和高度
            m_GameWidth = GameWidth;
            m_GameHeight = GameHeight;
        }

        // 畫圖時間
        public void Draw(Graphics Canvas) {
            // 跑一遍食物然後畫畫
            Brush SnakeColor = Brushes.BlueViolet;
            foreach (FoodPellet Pellet in m_FoodPellets)
            {
                Point PartPos = Pellet.GetPosition();
                Canvas.FillEllipse(SnakeColor, new Rectangle(PartPos.X+(m_CircleRadius / 4), PartPos.Y+ (m_CircleRadius / 4), m_CircleRadius/2, m_CircleRadius/2));
            }
        }

        // 將食物丟到畫面上
        public void AddRandomFood()
        {
            // 隨機位置
            int X = r.Next(m_GameWidth - m_CircleRadius); 
            int Y = r.Next(m_GameHeight - m_CircleRadius);

            int ix = (X / m_CircleRadius);
            int iy = Y / m_CircleRadius;

            // 定位
            X = ix * m_CircleRadius;
            Y = iy * m_CircleRadius;

            // 食物存回陣列
            m_FoodPellets.Add(new FoodPellet(X, Y));
        }

        //
        public void AddRandomFood(int Amount)
        {
            for(int i = 0; i < Amount; i++)
            {
                AddRandomFood();
            }
        }

        // 吃到食物偵測器
        public bool IsIntersectingRect(Rectangle rect, bool RemoveFood)
        {
            foreach (FoodPellet Pellet in m_FoodPellets) // 跑一遍食物陣列
            {
                Point PartPos = Pellet.GetPosition();

                // 檢查是否碰到食物
                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                {
                    if (RemoveFood)
                        m_FoodPellets.Remove(Pellet);
                    return true;
                }
            }
            return false;
        }
    }
}
