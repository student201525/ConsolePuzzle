using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Game2 : Game,IPlayable
    {
        public Game2(int[] point): base(point)
        {
        }

        public bool finish()
        {
            int value = 1;
            for (int i = 0; i < width; ++i)
            {
                for (int j = 0; j < height; ++j)
                {
                    if (field[i, j] == value)
                    {
                        ++value;
                        if (value == Length)
                        {
                            value = 0;
                        }
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            return true;

        }

       

       // public virtual void mixer(int[] p)
        //{
               public virtual void mixer(int[] p)
        {


            // int[] values = new int[width * height];

            Random gen = new Random();

            int coordinateX = 0;
            int coordinateY = 0;
            int temp = 0;

            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    coordinateX = gen.Next(0, field.GetLength(0));
                    coordinateY = gen.Next(0, field.GetLength(1));

                    temp = field[coordinateX, coordinateY];
                    field[coordinateX, coordinateY] = field[i, j];
                    field[i, j] = temp;
                }
            }




            //int tmp = 0;

            //Random rnd = new Random();

            //for (int i = 0; i < p.Length; i++)
            //{
            //    bool isExist = false;
            //    do
            //    {
            //        isExist = false;
            //        tmp = rnd.Next(0, p.Length);
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (tmp == p[j]) { isExist = true; }
            //        }
            //    }
            //    while (isExist);
            //    p[i] = tmp;
            //}
        }

        //public override void Move(int value)
        //{
        //    base.Move(value);
        //}
    }
        
    }

