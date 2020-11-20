using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle(0) == 0);
            Console.WriteLine(Triangle(1) == 1);
            Console.WriteLine(Triangle(2) == 3);
            Console.WriteLine(Triangle(3) == 6);
            Console.WriteLine(Triangle(4) == 10);
            Console.WriteLine();
            Console.WriteLine(SumDigits(126) == 9);
            Console.WriteLine(SumDigits(49) == 13);
            Console.WriteLine(SumDigits(12) == 3);
            Console.WriteLine(SumDigits(2456) == 17);
            Console.WriteLine(SumDigits(13754) == 20);
            Console.WriteLine();
            Console.WriteLine(Count7(717) == 2);
            Console.WriteLine(Count7(7) == 1);
            Console.WriteLine(Count7(123) == 0);
            Console.WriteLine(Count7(797217387) == 4);
            Console.WriteLine(Count7(7374873) == 3);
            Console.WriteLine();
            Console.WriteLine(PowerN(3, 1) == 3);
            Console.WriteLine(PowerN(3, 2) == 9);
            Console.WriteLine(PowerN(3, 3) == 27);
            Console.WriteLine(PowerN(5, 3) == 125);
            Console.WriteLine(PowerN(2, 10) == 1024);
            Console.WriteLine();
            Console.WriteLine(CountHi("xxhixx") == 1);
            Console.WriteLine(CountHi("xhixhix") == 2);
            Console.WriteLine(CountHi("hi") == 1);
            Console.WriteLine(CountHi("hixhixhixhihihihihiihihhih") == 10);
            Console.WriteLine(CountHi("hixhxixhi") == 2);
            Console.WriteLine();
            Console.WriteLine(ChangeXY("codex") == "codey");
            Console.WriteLine(ChangeXY("xxhixx") == "yyhiyy");
            Console.WriteLine(ChangeXY("xhixhix") == "yhiyhiy");
            Console.WriteLine(ChangeXY("yhiyhiy") == "xhixhix");
            Console.WriteLine(ChangeXY("yyhixx") == "xxhiyy");
            Console.WriteLine();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        static int Triangle(int rows)
        {
            if(rows == 0)
            {
                return 0;
            }
            else
            {
                return Triangle(rows - 1) + rows;
            }
        }

        static int SumDigits(int n)
        {
            if (n  == 0)
            {
                return 0;
            }
            else
            {
                return n % 10 + SumDigits(n / 10);
            }
        }

        static int Count7(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                if (n % 10 == 7)
                {
                    return 1 + Count7(n / 10);
                }
                else
                {
                    return Count7(n / 10);
                }
            }
        }

        static int PowerN(int b, int n)
        {
            if (n == 1)
            {
                return b;
            }
            else
            {
                return b * PowerN(b, n - 1);
            }
        }

        static int CountHi(string str)
        {
            if (str.Length == 1)
            {
                return 0;
            }
            else
            {
                if (str[str.Length-2] == 'h' && str[str.Length-1] == 'i')
                {
                    return 1 + CountHi(str.Substring(0, str.Length - 1));
                }
                else
                {
                    return CountHi(str.Substring(0, str.Length - 1));
                }
            }
        }

        static string ChangeXY(string str)
        {
            if (str.Length == 1)
            {
                if (str[0] == 'x')
                {
                    return "y";
                }
                else if (str[0] == 'y')
                {
                    return "x";
                }
                else
                {
                    return str[0].ToString();
                }
            }
            else
            {
                if (str[0] == 'x')
                {
                    return "y" + str.Substring(1,str.Length-1);
                }
                else if (str[0] == 'y')
                {
                    return "x" + str.Substring(1, str.Length - 1);
                }
                else
                {
                    return str[0].ToString() + ChangeXY(str.Substring(1, str.Length - 1));
                }
            }
        }
    }
}
