using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab2
{
    internal class Choice:IContainer
    {
        public int[] Mas { get; set; }
        public Choice(int size)
        {
            Mas = new int[size];
            Random random = new Random();
            for (int i = 0; i < Mas.Length; i++)
            {
                Mas[i] = random.Next(10, 100);
            }
        }
        public string Foreach()
        {
            string res = string.Empty;
            foreach (var i in Mas)
            {
                res += Math.Log(i) + " ";
            }
            return res;
        }

        public string Sort(IContainer mas)
        {
            for (int i = 0; i < Mas.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < Mas.Length; j++)
                {
                    if (Mas[j] < Mas[min])
                    {
                        min = j;
                    }
                }
                int temp = Mas[min];
                Mas[min] = Mas[i];
                Mas[i] = temp;
            }
            string res = String.Empty;
            for (int i = 0; i < Mas.Length; i++)
            {
                res += Mas[i] + " ";
            }
            return res;
        }
        public String Print()
        {
            string res = String.Empty;
            foreach (int i in Mas)
            {
                res += i + " ";
            }
            return $"{res:F2}";
        }
    }
}
