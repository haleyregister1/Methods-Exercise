using System;
using System.Collections.Generic;

namespace LukeWarmMethodConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Here is a list between 1000 and -1000");
            Console.ReadLine();
            ThousandsList();
            Console.WriteLine("Here is that list by threes:");
            Console.ReadLine();
            ThousandsByThrees();
            EqualTo(0, 0);
            EvenOROdd(0);
            PosOrNeg(0);
            AgeCandidate(0);
            InTensRange(0);
            MultiTable(0, 0);
            int[] arr = RandomGenArray(0);
            SumOfArray(arr);
            Console.WriteLine("Give me a number to cube: ");
            CubeNumbers(0);
        }
        static public void ThousandsList()
        {
            List<int> thousands = new List<int>();
            int i = 0;

            do
            {
                i++;
                thousands.Add(i);
            }
            while (i < 1000);

            while (i > -1000)
            {
                --i;
                thousands.Add(i);
            }

            foreach (int thousand in thousands)
            {
                Console.WriteLine(thousand);
            }

            for (i = 1999; i >= thousands.Count && i >=0; i++)
            {
                Console.WriteLine(thousands[i]);
            }

            Console.WriteLine("");
        }
        static public void ThousandsByThrees()
        {
            int x = 1000;
            do
            {
                Console.WriteLine(x--);
            }
            while (x >= 1000);

            int y = 3;

            while (y < 999)
            {
                y = y + 3;
                Console.WriteLine(y);
            }

            Console.WriteLine("");
        }
        static public bool EqualTo(int a, int b)
        {
            Console.WriteLine("Give me two numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine($"{a} is equal to {b}");
                Console.WriteLine("");
                return true; 
            }
            else
            {
                Console.WriteLine($"{a} is not equal to {b}");
                Console.WriteLine("");
                return false;
            }

             
        }
        static public bool EvenOROdd(int c)
        {
            Console.WriteLine("Give me a number");
            c = int.Parse(Console.ReadLine());

            if (c % 2 == 0)
            {
                Console.WriteLine($"{c} is even");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine($"{c} is odd");
                Console.WriteLine("");
                return false;
            }
        }
        static public bool PosOrNeg(int a)
        {
            Console.WriteLine("Give me another number");
            a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a} is a positive number");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine($"{a} is a negative number");
                Console.WriteLine("");
                return false;
            }
        }
        static public bool AgeCandidate(int a)
        {
            Console.WriteLine("How old are you?");
            a = int.Parse(Console.ReadLine());

            if (a >= 18)
            {
                Console.WriteLine("You can vote! Yayyyy!!!");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine("You can't vote, dingus!");
                Console.WriteLine("");
                return false;
            }
        }
        static public bool InTensRange(int a)
        {
            Console.WriteLine("Give me a positive or negative number");
            a = int.Parse(Console.ReadLine());

            if (a <= 10 && a >= -10)
            {
                Console.WriteLine($"{a} is between -10 and 10!");
                Console.WriteLine("");
                return true;
            }
            else
            {
                Console.WriteLine($"{a} is not between -10 and 10.");
                Console.WriteLine("");
                return false;
            }
        }
        static public void MultiTable(int a, int b)
        {
            Console.WriteLine("Give me number to create a multiplication table");
            a = int.Parse(Console.ReadLine());

            for (b = 0; b <= 12; b++)
            {
                Console.Write("{0} X {1} = {2} \n", a, b, a * b);

            }
            Console.WriteLine("");
        }
        static public int[] RandomGenArray(int a)
        {
            Console.WriteLine("Give me the total amount of numbers you want to generate");
            a = int.Parse(Console.ReadLine());

            int[] b = new int[a];

            Random randNum = new Random();

            for (int i = 0; i < b.Length; i++)
            {
                b[i] = randNum.Next(1001);
                Console.WriteLine(b[i] + " ");
                Console.WriteLine("");
            }
            return b;
        }
        static public void SumOfArray(int[] totalSums)
        {
            int sum = 0;
            Array.ForEach(totalSums, i => sum += i);

            Console.WriteLine($"The array added together is {sum}");
            Console.WriteLine("");
        }
        static public void CubeNumbers(int cubed)
        {
            cubed = int.Parse(Console.ReadLine());

            int cube = cubed * cubed * cubed;
            Console.WriteLine($"{cubed} cubed is {cube}");
        }
    }
}

