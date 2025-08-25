using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    // 매개변수 한정자

    // ref : 참조로 전달 (읽기 / 쓰기)
    // out : 참조로 전달 (쓰기)
    // in  : 참조로 전달 (읽기)
    // params : 가변 인자

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

        public void Pause()
        {
            Console.WriteLine("Pause....");
        }
    }
}
