using System;
internal class Exercise_01
{
    public static void Main(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Console.ReadKey();
    }
    //1. Do C, do K, Do F
    static void Ex01()
    {
        double celsius;
        string input;
        Console.Write("Nhap do C: ");
        input = Console.ReadLine();
        if (double.TryParse(input, out celsius))
        {
            double fahrenheit = (celsius * 18 / 10) + 32;
            double kelvin = celsius + 273;
            Console.WriteLine($"Do F: {fahrenheit}");
            Console.WriteLine($"Do K: {kelvin}");
        }
        else
        {
            Console.WriteLine("Nhap lai so: ");
        }
    }
     // 2. Dien tich be mat va the tich hinh cau
    static void Ex02()
    {
        Console.Write("Nhap ban kinh r: ");
        float radius = float.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Dien tich be mat hinh cau la: {surface}");
        Console.WriteLine($"The tich hinh cau la: {volume}");
    }
    // 3. Tinh ket qua
    static void Ex03()
    {
        Console.Write("Nhap hai so nguyen a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap hai so nguyen b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        Console.WriteLine($"{a} / {b} = {a / b}");
        Console.WriteLine($"{a} % {b} = {a % b}");
    }
}
