using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Game3 : Game2
    {

       // int LengthHistory;
     List<int> HistoryMemory = new List<int>();
      // List<Points> HistoryMemory = new List<Points>();
        public Game3(int[] point):base(point)
        {
            HistoryMemory = new List<int>();
        }


        public void Undo(int amount)
        {
   
            // if (LengthHistory > 0)
            // {

          Move(amount);
            HistoryMemory.Add(amount);
           
            //}
            // else throw new Exception("Невозможно отменить");
        }

        public void Redo(int amount)
        {
            // if (LengthHistory > 0)
            // {
            Move(HistoryMemory.Last());
            HistoryMemory.Remove(HistoryMemory.Last());
            // }
        }

    }
}


