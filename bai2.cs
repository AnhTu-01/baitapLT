using System;

class bai2
{
    static void Main(string[] args)
    {
        Console.Write("Nhập một số từ 1 đến 7: ");
        int day = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Thứ Hai";
                break;
            case 2:
                dayName = "Thứ Ba";
                break;
            case 3:
                dayName = "Thứ Tư";
                break;
            case 4:
                dayName = "Thứ Năm";
                break;
            case 5:
                dayName = "Thứ Sáu";
                break;
            case 6:
                dayName = "Thứ Bảy";
                break;
            case 7:
                dayName = "Chủ Nhật";
                break;
            default:
                dayName = "Không hợp lệ";
                break;
        }

        Console.WriteLine("Ngày bạn vừa nhập là: " + dayName);
    }
}