using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab2
{
    internal class Bubble : IContainer
    {
        public int[] Mas { get; set; }
        public Bubble(int size)
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
            string res = String.Empty;
            for (int i = 0; i < Mas.Length; i++)
            {
                res += Math.Sqrt(Mas[i]) + " ";
            }
            return $"{ res: F2}";
        }

        public string Sort(IContainer mas)
        {
            int temp;
            for (int i = 0; i < Mas.Length; i++)
            {
                for (int j = 0; j < Mas.Length; j++)
                {
                    if (Mas[i] > Mas[j])
                    {
                        temp = Mas[i];
                        Mas[i] = Mas[j];
                        Mas[j] = temp;
                    }
                }
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

