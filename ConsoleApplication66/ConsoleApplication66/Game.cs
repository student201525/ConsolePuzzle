using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication66
{
    class Game
    {

        public int[] point = new int[100];
        public int Length = 0;

        public static int[] ArrayText = new int[100];
        public readonly int width = 4, height = 4;
        public int[,] field;
        public Points[] FieldValue = new Points[100];

        public Game(int[] point)
        {
            field=new int[width, height];
            int ruru = 0;

            //string[] file = new string[4];
           
            Length = width*height;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    field[j, i] = point[ruru];
                    FieldValue[point[ruru]] = new Points(j, i);
                    ruru++;

                }
            }

        }

        public int this[int x, int y]
        {
            get
            {
                if (x < 0 || x >= width*height || y < 0 || y >= width * height)
                {
                    throw new ArgumentOutOfRangeException("Indexes are out of range");
                }
                return field[x, y];
            }
        }

         int[] GetLocation(int value)
        {
            int[] coordValue = new int[2];
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    if (value == field[i, j])
                    {
                        coordValue[0] = i;
                        coordValue[1] = j;
                    }
                }
            }
            return coordValue;
        }
        
        public virtual bool Move(int value)
        {
            int Check = 0;
            try
            {
                if (value > 15 || value < 0)
                {
                    throw new ArgumentException();
                }

                int[] locValue = GetLocation(value);
                int[] locNull = GetLocation(0);


                if ((Math.Abs(locValue[0] - locNull[0]) == 1 && locValue[1] == locNull[1]) ||
                ((Math.Abs(locValue[1] - locNull[1]) == 1 && locValue[0] == locNull[0])))
                {
                    int temp = 0;
                    temp = field[locValue[0], locValue[1]];
                    field[locValue[0], locValue[1]] = field[locNull[0], locNull[1]];
                    field[locNull[0], locNull[1]] = temp;
                    Check = temp;
                    return true;           
                }
                else
                {
                    throw new Exception();
                }

            }

            catch (ArgumentException)
            {
               Console.WriteLine("Такого числа не существует, попробуйте еще раз: ");
            }
            catch (Exception)
           {
               Console.WriteLine("Рядом с этим числом нету 0, попробуйте еще раз: ");
            }

            return false;
        }

        //public virtual void Move(int value)
        //{

        //    try
        //    {

        //        if (value > 15 || value < 0)
        //        {
        //            throw new ArgumentException();
        //        }

        //        int x = GetLocation(0).x;
        //        int y = GetLocation(0).y;

        //        int ValueX = GetLocation(value).x;
        //        int ValueY = GetLocation(value).y;

        //        if ((ValueX == x && (ValueY == y - 1 || ValueY == y + 1)) || (ValueY == y && (ValueX == x - 1 || ValueX == x + 1)))
        //        {

        //            field[x, y] = value;
        //            field[ValueX, ValueY] = 0;

        //            var vere = FieldValue[0];
        //            FieldValue[0] = FieldValue[value];
        //            FieldValue[value] = vere;

        //            //obj.History(value);

        //        }

        //        else
        //        {
        //            throw new Exception();
        //        }
        //    }

        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine("Такого числа не существует, попробуйте еще раз: ");
        //    }
        //    catch (Exception)
        //    {
        //        Console.WriteLine("Рядом с этим числом нету 0, попробуйте еще раз: ");
        //    }


        //}

        //public static int TextSCV()
        //{
        //    int ruru = 0;
        //    try
        //    {
        //        string[] text = File.ReadAllLines(@"C:\Users\сергей\Desktop\TriangleGit\Switty\ConsoleApplication9\ConsoleApplication9\text.csv");
        //        Char place = ' ';

        //        for (int i = 0; i < text.Length; ++i)
        //        {
        //            string[] row = text[i].Split(place);
        //            foreach (var substring in row)
        //            {
        //                ArrayText[ruru] = Convert.ToInt32(substring);
        //                //Console.WriteLine(ArrayText[ruru]);
        //                ++ruru;
        //            }
        //        }

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("The file could not be read:");
        //        Console.WriteLine(e.Message);
        //    }
        //    return ruru;
        //}
    }
}