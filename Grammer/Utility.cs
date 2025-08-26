using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{

    public struct Vector2(int X, int Y)
    {
        public int x = X;
        public int y = Y;
    }

    internal class Utility
    {
        // 클래스 내부에서는 접근 지정자를 함수나 변수 앞에 붙여줘야 합니다.

        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public int Absolute(in int value)
        {
            int number = value;

            if (value < 0)
            {
                number = -number;
            }

            return number;
        }

        public void Magnitude(Vector2 vector2, out float length)
        {
            length = (float)Math.Sqrt(vector2.x * vector2.x + vector2.y * vector2.y);
        }

        public void Pause()
        {
            Console.WriteLine("Pause....");
        }
    }
}
