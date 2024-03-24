using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:");

            Console.WriteLine("1. Vẽ hình vuông");
            Console.WriteLine("2. Vẽ hình chữ nhật");
            Console.WriteLine("3. Vẽ hình tam giác");
            Console.WriteLine("4. Thoát");

            Console.WriteLine("Nhập lựa chọn của bạn:");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DrawSquare();
                    break;
                case "2":
                    DrawRectangle();
                    break;
                case "3":
                    DrawTriangle();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }

    static void DrawSquare()
    {
        Console.WriteLine("Đây là hình vuông");
        Console.WriteLine("********");
        Console.WriteLine("*      *");
        Console.WriteLine("*      *");
        Console.WriteLine("********");
    }

    static void DrawRectangle()
    {
        Console.WriteLine("Đây là hình chữ nhật");
        Console.WriteLine("**********");
        Console.WriteLine("*         *");
        Console.WriteLine("**********");
    }

    static void DrawTriangle()
    {
        Console.WriteLine("Đây là hình tam giác");
        Console.WriteLine("    *");
        Console.WriteLine("   ***");
        Console.WriteLine("  *****");
        Console.WriteLine(" *******");
    }
}