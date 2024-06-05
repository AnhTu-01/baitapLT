using System;

class bai4
{
    static void Main(string[] args)
    {
        Console.Write("Nhập số hàng: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Nhập số cột: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= columns; j++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("* ");
                }
                else
                {
                    Console.Write(" *");
                }
            }
            Console.WriteLine();
        }
    }
}