using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog_4s_l9_1
{
    class Program
    {
        static void MethodAct(int[,] arr, Action<int> act)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    act(arr[i, j]);
        }

        static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = act(arr[i, j]);
        }

        static void Show(int num)
        {
            Console.Write(num + "\t");
        }
        static void ShowPositive(int num)
        {
            if (num > 0)
                Console.Write(num + "\t");
        }
        static int Mult3(int num)
        {
            if (num > 0)
                return num * 3;
            else
                return num;
        }

        static void Main(string[] args)
        {

            int[,] arr = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rand.Next(-10, 10);

            Console.WriteLine("Матрица");
            MethodAct(arr, Show);
            Console.WriteLine();

            Console.WriteLine("Положительные элементы матрицы");
            MethodAct(arr, ShowPositive);
            Console.WriteLine();

            Console.WriteLine("Положительные элементы матрицы, умноженные на 3");
            MethodFunc(arr, Mult3);
            MethodAct(arr, ShowPositive);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
       


    }

