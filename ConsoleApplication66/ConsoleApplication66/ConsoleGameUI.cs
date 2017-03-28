using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class ConsoleGameUI
    {
        IPlayable Puzzle;
        
            public ConsoleGameUI(IPlayable puzzle)
            {
            Puzzle = puzzle;
            }
    
            //public void mixer(int[] p)
            //{

            //}

            //public bool finish()
            //{
            //throw new NotImplementedException();
            //}

            //public void Move(int value)
            //{

            //}

        public void drawField()
        {
            
            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n");
            for (int i = 0; i < (Puzzle as Game).width; i++)
            {

                for (int j = 0; j < (Puzzle as Game).height; j++)
                {
                    Console.Write((Puzzle as Game).field[i, j] + "\t");
                }
                Console.WriteLine();

            }

            Console.Write("~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + "\n");

        }

        public void GetMenu()
        {
            int score = 0;
            int[] p = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 };
            Console.WriteLine("\t *******************");
            Console.Write("\t * ИГРА - ПЯТНАШКИ *" + "\n");
            Console.WriteLine("\t *******************");
           
            //Game2 Random = new Game2(p);
     
           
            Game3 MyGame = new Game3(p);

            Puzzle.mixer(p);
          this.drawField();
          
            Console.WriteLine("ti daun");
            for (;;)
            {
                Console.WriteLine("Выберите число: ");
                int a = Convert.ToInt32(Console.ReadLine());

         Puzzle.Move(a);
                this.drawField();


                Console.WriteLine("1 - Отменить ход, 2 - продолжить");
                int tmp = Convert.ToInt32(Console.ReadLine());


                if (tmp > 2 || tmp < 1)
                {
                    Console.WriteLine("Нужно выбрать либо 1, либо 2");
                    Console.WriteLine("1 - Отменить ход, 2 - продолжить");
                    tmp = Convert.ToInt32(Console.ReadLine());
                }

                if (tmp == 1)
                {
                    Console.WriteLine("Вы выбрали 1 ");
                    MyGame.Redo(a);

                    this.drawField();
                    Console.WriteLine("1 - Отменить откат, 2 - продолжить");
                    tmp = Convert.ToInt32(Console.ReadLine());

                    if (tmp > 2)
                    {
                        Console.WriteLine("Нужно выбрать либо 1, либо 2");
                        Console.WriteLine("1 - Отменить ход, 2 - продолжить");
                        tmp = Convert.ToInt32(Console.ReadLine());
                    }

                    if (tmp == 1)
                    {
                        Console.WriteLine("Вы выбрали 1 ");
                        MyGame.Undo(a);
                        this.drawField();
                    }
                    if (tmp == 2)
                    {
                        Console.WriteLine("Вы выбрали 2 ");
                    }
                }

                if (tmp == 2)
                {
                    Console.WriteLine("Вы выбрали 2 ");
                }

                if (Puzzle.finish())
                {
                    this.drawField();
                    Console.WriteLine("Вы выиграли!!!!");
                    Console.WriteLine("Конец игры");
                    break;
                }
                score++;

                Console.WriteLine("Количество ходов: " + score);
            }

        }
    }
}
