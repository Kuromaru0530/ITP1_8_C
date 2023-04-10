using System;
using System.Linq;
using System.Collections.Generic;

namespace ITP1_8_C
{
    class Program
    {
        static void Main()
        {
                var set = Enumerable.Range('a', 26).Select(i => (char)i).ToArray();
                int[] ans = new int[set.Length];
                List<string> list = new List<string>();

            while(true)
            {
                string Input = Console.ReadLine();

                if (Input == null) break;

                else
                {
                    list.Add(Input.ToLower());
                }
            }
            string[] lists = list.ToArray();
            for (int i = 0; i < lists.Length; i++)
            {
                foreach (char c in lists[i])
                    for (int j = 0; j < set.Length; j++)
                    {
                        if (set[j] == c)
                        {
                            ans[j]++;
                        }
                    }
            }
           
            
            for (int i = 0; i < set.Length; i++)
            {
                Console.WriteLine($"{set[i]} : {ans[i]}");
            }
        }
    }
}