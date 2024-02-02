using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11Chernyshenko.lab2
{
    interface IContainer
    {
        public int[] Mas { get; set; }
        string Sort(IContainer mas);
        string Foreach();
    }
}
