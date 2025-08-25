namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Utility utility = new Utility();

            // utility.Pause();

            int a = 1;
            int b = 3;

            int c = -5;
            
            utility.Swap(ref a, ref b);

            Console.WriteLine($"a : {a}\nb : {b}");
            Console.WriteLine("Absolute c : " + utility.Absolute(in c));
        }
    }
}
