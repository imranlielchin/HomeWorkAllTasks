using System.ComponentModel.Design.Serialization;

namespace HomeWORKALLTASKS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Taks 1           


            //long b;
            //l1:

            //b = Task1Int64();

            //if (b >= 1000 && b < 10000)
            //{ 
            //    b = 70000 + b;

            //    b = b * 10 + 8;
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine("daxil etdiyiniz reqem 1000-10000 araliqda deil");

            //    goto l1;
            //}

            #endregion

            #region task 2
            //long number, number2;
            //l1:

            //number = Task2Int64();

            //if(number>99 && number < 1000)
            //{
            //    number2 = number * 1000;
            //    number2 = number2 + number;
            //    Console.WriteLine(number2);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil Etdiyiniz eded 100-1000 araliginda deil");
            //    goto l1;
            //}
            #endregion


            #region task 3

            //long number,number1;
            //l1:
            //number = Task3Int64();
            //if (number > 9999 && number < 100000)
            //{
            //    number1 = number / 100 * 18;
            //    number = number - number1;
            //    number = number % 100 * 3;
            //   Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil olunan eded bu araliqda deyil 10000-100000 ");
            //    goto l1;
            //}

            #endregion



            #region task 4
            //long number;
            //l1:
            //number = Task4Int64();
            //if(number>99 && number < 1000)
            //{
            //    number = number * 10 + 7;
            //    number = number / 100 * 7;
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz eded bu araliqda deil 100-1000");
            //    goto l1;
            //}

            #endregion


            #region task 5
            //long number;
            //l1:
            //number = Task5Int64();
            //if(number>999 && number < 10000)
            //{
            //    number = 40000 + number;
            //    number = number * 100 + 44;
            //    number = number / 100 * 44;
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz eded bu araliqda deil 1000-10000");
            //    goto l1;
            //}
            #endregion

            #region task 6
            //double number;
            //l1:
            //number = Task6Double();
            //if (number>=1000 && number <= 9999)
            //{
            //    number = number / 100 * 20;
            //    number = number / 100 * 10;
            //    number=Math.Pow(number,2);
            //    Console.WriteLine(number);

            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz eded bu araliqda deil 1000-10000");
            //    goto l1;
            //}

            #endregion


            #region task 7
            //long number, number1, number2;
            //l1:
            //number1 = Task7Int64("number1:");
            //number2 = Task7Int64("number2:");
            //if (number1 > 9999 && number1 < 100000)
            //{
            //    if (number2 > 9999 && number2 < 100000)
            //    {
            //        number = number1 + number2;
            //        number = 500000 + number;
            //        number = number * 10 + 5;
            //        number = number / 100 * 5;
            //        Console.WriteLine(number);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem duzgun araliqda deil");
            //    goto l1;
            //}
            #endregion
            #region task 8
            //long number, number1, number2;
            //l1:
            //number1 = Task8Int64("number1:");
            //number2 = Task8Int64("number2:");

            //if ((number1 > 999 && number1 < 10000) && (number2 > 999999 && number2 < 10000000))
            //{
            //    number1 = number1 / 100 * 4;
            //    number2 = number2 / 100 * 9;
            //    number = number1 + number2;
            //    number = number / 100 * 10;
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //    goto l1;
            //}
            #endregion
            #region task 9
            //long a, b, c, d;
            //l1:
            //a = Task9Int64("number1:");
            //b = Task9Int64("number2:");
            //c = Task9Int64("number3:");
            //if((a>99999 && a<1000000) && (b>99999 && b<1000000)&& (c > 99999 && c < 1000000))
            //{
            //    a = a / 100 * 10;
            //    b = b / 100 * 10;
            //    c = c / 100 * 10;
            //    d = a + b + c;
            //    d = d / 100 * 10;
            //    Console.WriteLine(d);
            //}
            //else
            //{
            //    Console.WriteLine("Daxil etdyiniz reqem dogru araliqda deil");
            //    goto l1;
            //}
            #endregion
            #region task 10
            //    long a, b, c, d;
            //l1:
            //    a = Task10Int64("number1:");
            //    b = Task10Int64("number2:");
            //    c = Task10Int64("number3:");
            //    if((a>999 && a<10000)&& (b > 999 && b < 10000)&& (c > 999 && c < 10000))
            //    {
            //        a = a / 100 * 1;
            //        b = b / 100 * 2;
            //        c = c / 100 * 3;
            //        d = a - b - c;
            //        c = c / 100 * 7;
            //        d = d + c;
            //        Console.WriteLine(d);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdyiniz reqem dogru araliqda deil")
            //            goto l1;
            //    }
            #endregion
            #region task 11
            //    long a, b, c, d, e, f, g;
            //l1:
            //    a = Task11Int64("number1:");
            //    b = Task11Int64("number2:");
            //    c = Task11Int64("number3:");
            //    d = Task11Int64("number4:");
            //    if ((a>9999&& a<100000) && (b>9999&&b<100000) && (c>9999&&c<100000) && (d>9999&&d<100000))
            //    {
            //        e = a + c;
            //        f = b + d;
            //        g = e * f;
            //        c = c / 100 * 3;
            //        g = g - c;
            //        Console.WriteLine(g);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
            //            goto l1;
            //    }
            #endregion
            #region task 12
            long a, b, c, d, sum1, sum2, lastAnswer;
        l1:
            a = Task12Int64("number1:");
            b = Task12Int64("number2:");
            c = Task12Int64("number3:");
            d = Task12Int64("number4:");
            if ((a > 99999 && a < 1000000) && (b > 99999 && b < 1000000) && (c > 99999 && c < 1000000) && (d > 99999 && d < 1000000))
            {
                a = a / 100 * 10;
                b = b / 100 * 10;
                c = c / 100 * 10;
                d = d / 100 * 10;
                sum1 = a + b + c + d;
                a = a / 100 * 15;
                b = b / 100 * 15;
                c = c / 100 * 15;
                d = d / 100 * 15;
                sum2 = a + b + c + d;
                lastAnswer = sum1 * sum2;
                lastAnswer = lastAnswer / 100 * 10;
                lastAnswer = lastAnswer / 100 * 11;
                Console.WriteLine(lastAnswer);

            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz reqem dogru araliqda deil");
                goto l1;
            }
            #endregion
            #region task 13



            #endregion







        }

































        static int ReadInt32()
        {
            int a;

        l1: Console.Write("a:");

            if (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static long Task1Int64()
        {
            

        l1: Console.Write("a:");

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }






        static long Task2Int64()
        {
            

        l1: Console.Write("a:");

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }


        static long Task3Int64()
        {


        l1: Console.Write("a:");

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static long Task4Int64()
        {


        l1: Console.Write("a:");

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }



        static long Task5Int64()
        {


        l1: Console.Write("a:");

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }

        static double Task6Double()
        {


        l1: Console.Write("a:");

            if (double.TryParse(Console.ReadLine(), out double a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task7Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task8Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task9Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task10Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task11Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
        static long Task12Int64(string capture)
        {


        l1: Console.Write(capture);

            if (long.TryParse(Console.ReadLine(), out long a) == false)
            {
                Console.WriteLine("tam eded daxil etmelisiniz");
                goto l1;
            }

            return a;
        }
    }


    


}


