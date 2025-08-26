namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션

            #region List
            /*
            List<int> list = new List<int>();

            list.Capacity = 10;

            list.Add(10); // 10 [0]
            list.Add(20); // 10 20 [0][1]
            list.Add(30); // 10 20 30 [0][1][2]
            list.Add(40); 
            list.Add(50); 

            list.Insert(3, 75);  // Insert(index, element)

            foreach (int element in list) // 범위기반 for문
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #region Dictionary
            // hash table의 개방 주소법을 사용합니다.

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            int money = 0;

            dictionary.Add("Blade", 300);
            dictionary.Add("Knife", 200);
            dictionary.Add("Gun", 500);

            foreach (var element in dictionary) // 자료형 예측 : var
            {
                Console.WriteLine($"Key : {element.Key}");
                Console.WriteLine($"Value : {element.Value}");
            }

            string key = "Gun";

            if (dictionary.TryGetValue(key, out money))
            {
                money = dictionary[key];
            }
            else
            {
                dictionary.Add(key, 500);
            }

            Console.WriteLine($"\nMoney of {key} : {money}");

            #endregion

            #endregion
        }
    }
}
