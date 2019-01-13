using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    // 鍵入管理系統
    class Input
    {
        // 儲存鍵盤按鍵
        private static Dictionary<Keys,bool> KeyTable = new Dictionary<Keys,bool>();

        // 鍵入判定
        public static bool IsKeyDown(Keys key)
        {
            bool KeyState;
            if (KeyTable.TryGetValue(key,out KeyState))
            {
                return KeyState;
            }
            return false;
        }

        public static void SetKey(Keys key,bool IsDown)
        {
            KeyTable[key] = IsDown;
        }
    }
}
