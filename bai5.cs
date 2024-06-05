using System;

class bai5
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        while (true)
        {
            Console.Write("Hãy đoán một số từ 1 đến 100: ");
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("Chúc mừng! Bạn đã đoán đúng số bí mật.");
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("Số bạn đoán nhỏ hơn số bí mật. Hãy thử lại.");
            }
            else
            {
                Console.WriteLine("Số bạn đoán lớn hơn số bí mật. Hãy thử lại.");
            }
        }
    }
}