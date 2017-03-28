using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    interface IPlayable
    {
        void mixer(int[] p);
        bool finish();
        bool Move(int value);
    }
}
