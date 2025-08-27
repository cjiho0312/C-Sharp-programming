namespace Collection
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
            /*
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
            */
            #endregion

            #region Stack
            /*
            // 후입선출 
              
            Stack <int> stack = new Stack<int>();

            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            */
            #endregion

            #region Queue
            /*
            // 선입선출

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            while(queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            */
            #endregion

            #region Linked List
            /*
            LinkedList<int> linkedlist = new LinkedList<int>();

            linkedlist.AddFirst(10);
            linkedlist.AddFirst(20);
            linkedlist.AddFirst(30);
            linkedlist.AddLast(5);

            foreach (int element in linkedlist)
            {
                Console.WriteLine(element);
            }
            */
            #endregion

            #endregion
        }
    }
}
