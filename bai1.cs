using System;

class bai1
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một số nguyên: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Số bạn vừa nhập là số dương.");
        }
        else if (number < 0)
        {
            Console.WriteLine("Số bạn vừa nhập là số âm.");
        }
        else
        {
            Console.WriteLine("Số bạn vừa nhập là số 0.");
        }
    }
}