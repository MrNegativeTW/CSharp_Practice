using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Snake
{
    // 方向系統
    public enum Direction
    {
        left,
        right,
        up,
        down,
        none
    }

    // 控制系統
    class SnakePlayer
    {
        private List<BodyPart> m_SnakeParts = new List<BodyPart>(); 
        private const int m_CircleRadius = 20; // 蛇身大小
        private Direction m_MoveDirection = Direction.none; // 蛇頭方向
        private int m_PendingSegments;
        private SnakeForm GameForm = null; 

        // 物件生成
        public SnakePlayer(SnakeForm Form)
        {
            // 蛇身初始化，3粒
            m_SnakeParts.Add(new BodyPart(100, 0, Direction.right));
            m_SnakeParts.Add(new BodyPart(80, 0, Direction.right));
            m_SnakeParts.Add(new BodyPart(60, 0, Direction.right));

            // 初始方向
            m_MoveDirection = Direction.right;

            // 無待生成蛇身
            m_PendingSegments = 0;
            GameForm = Form;
        }

        // 加入蛇身
        public void AddBodySegments(int Number) {
            m_PendingSegments += Number;
        }

        // 蛇蛇動起來
        public void MovePlayer()
        {
            if (m_PendingSegments > 0)
            {
                Point LastPos = m_SnakeParts.Last().GetPosition(); //蛇身加到尾巴去
                m_SnakeParts.Add(new BodyPart(LastPos.X,LastPos.Y));
                m_PendingSegments--;
            }
            
            m_SnakeParts[0].m_Dir = m_MoveDirection; //設定蛇頭方向

            // 移動蛇蛇的身體
            for (int i = m_SnakeParts.Count-1; i>=0 ;i--)
            {
                switch (m_SnakeParts[i].m_Dir)
                {
                    case Direction.left:
                        m_SnakeParts[i].AddPosition(new Point(-20, 0));
                        break;
                    case Direction.right:
                        m_SnakeParts[i].AddPosition(new Point(20, 0));
                        break;
                    case Direction.down:
                        m_SnakeParts[i].AddPosition(new Point(0, 20));
                        break;
                    case Direction.up:
                        m_SnakeParts[i].AddPosition(new Point(0, -20));
                        break;
                    default:
                        break;
                }

                // 設定下一蛇身轉彎方向
                if (i > 0)
                        m_SnakeParts[i].m_Dir = m_SnakeParts[i - 1].m_Dir;
            }
            if (IsSelfIntersecting()) // 偵測自撞
                OnHitSelf();
        }

        // 偵測自撞
        public bool IsSelfIntersecting() {
            // 檢查每一部位與其他部位是否香蕉
            for(int i=0;i < m_SnakeParts.Count;i++) {
                for (int j = 0;j < m_SnakeParts.Count; j++) {
                    if(i == j) 
                        continue;
                    BodyPart part1 = m_SnakeParts[i];
                    BodyPart part2 = m_SnakeParts[j];

                    if ((new Rectangle(part1.GetPosition().X, part1.GetPosition().Y, m_CircleRadius, m_CircleRadius)).IntersectsWith(
                        new Rectangle(part2.GetPosition().X, part2.GetPosition().Y, m_CircleRadius, m_CircleRadius)))
                        return true;
                }
            }
            return false;
        }

        // 設定蛇頭方向
        public void SetDirection(Direction Dir) {
            if (m_MoveDirection == Direction.left && Dir == Direction.right)
                return;

            if (m_MoveDirection == Direction.right && Dir == Direction.left)
                return;

            if (m_MoveDirection == Direction.up && Dir == Direction.down)
                return;

            if (m_MoveDirection == Direction.down && Dir == Direction.up)
                return;

            // 若轉向正常，則轉向
            m_MoveDirection = Dir;
        }

        public bool IsIntersectingRect(Rectangle rect)
        {
            foreach(BodyPart Part in m_SnakeParts)
            {
                Point PartPos = Part.GetPosition();

                if (rect.IntersectsWith(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius)))
                    return true;
            }
            return false;
        }

        // 結束狀況 - 撞牆
        public void OnHitWall(Direction WhichWall) // WhichWall - 撞哪一面牆
        {
            GameForm.ToggleTimer(); // 啟動暫停系統 - 關閉
            MessageBox.Show("撞牆" ,"GAME OVER");
            GameForm.ResetGame();

            /*
            XmlDocument doc = new XmlDocument();
            doc.Load("settings.xml");
            // 選擇節點
            XmlNode Money = doc.SelectSingleNode("Settings/Money");
            // 取得節點 欄位
            XmlElement MoneyElement = (XmlElement)Money;
            // 取得節點 內容
            string MoneyData = MoneyElement.GetAttribute("value");
            // 取得節點 屬性
            XmlAttribute MoneyAttribute = MoneyElement.GetAttributeNode("value");
            // 列出節點內的屬性
            XmlAttributeCollection Moneyattribute = MoneyElement.Attributes;
            foreach (XmlAttribute item in Moneyattribute)
            {
                if (item.Value == "0")
                {
                    MessageBox.Show("您未下注，無獎無罰");
                } else if (score < item.Value) { //BUG - 變數無法存取
                    MessageBox.Show("分數比下注少喔");
                }

            }
            */


        }

        // 結束狀況 - 自撞
        public void OnHitSelf()
        {
            GameForm.ToggleTimer(); // 啟動暫停系統 - 關閉
            MessageBox.Show("自撞", "Game Over");
            GameForm.ResetGame();
        }

        //畫圖時間
        public void Draw(Graphics canvas)
        {
            Brush SnakeColor = Brushes.Black;
            List<Rectangle> Rects = GetRects();
            foreach(Rectangle Part in Rects) 
            {
                canvas.FillEllipse(SnakeColor, Part);
            }
        }

       

        //取得蛇身
        public List<Rectangle> GetRects() {
            List<Rectangle> Rects = new List<Rectangle>();
            foreach (BodyPart Part in m_SnakeParts)  { 
                Point PartPos = Part.GetPosition();
                Rects.Add(new Rectangle(PartPos.X, PartPos.Y, m_CircleRadius, m_CircleRadius));
            }
            return Rects;
        } 
    }
}
