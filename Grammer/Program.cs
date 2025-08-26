namespace Grammar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 값 형식 (value type)
            // int, float, double, char, bool, struct, enum

            // 참조 형식 (reference type)
            // class, object, string, interface, dynamic, delegate, 배열

            // 값 형식은 ref 키워드를 붙여야 원본 값이 수정되고, 참조 형식은 ref 형식을
            // 쓰지 않아도 원본 값이 수정됩니다.

            // 'string'은 참조 형식이지만 값 형식처럼 행동을 하므로 함수의 인자로
            // 전달할 때 ref 키워드를 써야지 원본 값이 수정됩니다.

            #region 박싱
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.

            // int value = 100;

            // object generic = value;

            // Console.WriteLine("value : " +  value);
            // Console.WriteLine("generic : " + generic);

            #endregion

            #region 언박싱
            // 참조 형식의 데이터를 값 형식으로 변환하는 과정입니다.

            // int box = (int)generic; // 명시적 형변환

            // Console.WriteLine("box : " + box);

            #endregion

            #region 매개변수 한정자
            // 함수의 매개변수 앞에 해당하는 인자의 전달 방식을
            // 지정하는 키워드입니다.

            // ref : 참조로 전달 (읽기 / 쓰기)
            // out : 참조로 전달 (쓰기)
            // in  : 참조로 전달 (읽기)
            // params : 가변 인자

            Utility utility = new Utility();
            
            int a = 1;
            int b = 3;
            
            int c = -5;
            
            float directionLength;
            
            Vector2 direction = new Vector2(1, 2);
            
            utility.Pause();
            utility.Swap(ref a, ref b);
            utility.Magnitude(direction, out directionLength);
            
            Console.WriteLine($"a : {a}\nb : {b}"); // 이런 방식의 출력도 가능
            Console.WriteLine("Absolute c : " + utility.Absolute(in c));
            Console.WriteLine("direction length : " + directionLength);

            #endregion
        }
    }
}
