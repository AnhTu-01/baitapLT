using System;

class bai6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhập một dãy số (nhập 0 để kết thúc):");

        int sum = 0;
        while (true)
        {
            Console.Write("Nhập số: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            if (number < 0)
            {
                continue;
            }

            sum += number;
        }

        Console.WriteLine("Tổng các số dương là: " + sum);
    }
}