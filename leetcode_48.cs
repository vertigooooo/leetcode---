using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,3];
            int temp = 1;
            for (int i = 0; i < System.Math.Sqrt(matrix.Length); i++)
                for(int j = 0; j < System.Math.Sqrt(matrix.Length); j++)
                    matrix[i,j] = temp++;
                
            
            Print(matrix);
            Transpose(matrix);
            Symmetric(matrix);
            Console.WriteLine();
            Print(matrix);
        }

        //顺时针旋转九十度
        public static void Rotate(int[,] matrix)
        {
            Transpose(matrix);
            Symmetric(matrix);
        }
        //转置
        public static void Transpose(int[,] matrix)
        {
            for(int i = 0;i < System.Math.Sqrt(matrix.Length); i++)
                for(int j = i;j < System.Math.Sqrt(matrix.Length); j++)
                    Swap(ref matrix[i, j], ref matrix[j, i]);
        }
        //对称
        public static void Symmetric(int[,] matrix)
        {
            for (int i = 0; i < System.Math.Sqrt(matrix.Length); i++)
                for (int j = 0; j < System.Math.Sqrt(matrix.Length)/2; j++)
                    Swap(ref matrix[i, j], ref matrix[i, (int)System.Math.Sqrt(matrix.Length) - j - 1]);
        }
        //交换俩数
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //打印
        public static void Print(int[,] matrix)
        {
            for (int i = 0; i < System.Math.Sqrt(matrix.Length); i++)
            {
                for (int j = 0; j < System.Math.Sqrt(matrix.Length); j++)
                        Console.Write(matrix[i, j]+" ");
                Console.WriteLine();
            }
        }

    }
}
