using System;

class bai3
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một số nguyên dương: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int factorial = 1;

        if (number < 0)
        {
            Console.WriteLine("Số bạn vừa nhập không phải là số nguyên dương.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Giai thừa của {0} là {1}.", number, factorial);
        }
    }
}