using System;
internal class Exercise_02
{
  public static void Run02(string[] args)
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Console.ReadKey();
  }
    //1. Thuc hien phep toan
    static void Ex01()
    {
        Console.Write("Nhap so a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a} + {b} = {a + b}");
        Console.WriteLine($"{a} - {b} = {a - b}");
        Console.WriteLine($"{a} * {b} = {a * b}");
        if (b != 0)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0");
        }
    }
    //2. Tinh gia tri ham so
    static void Ex02()
    {
        Console.WriteLine("Bang gia tri cua ham x = y^2 + 2y + 1:");
        Console.WriteLine("y\t\tx");

        for (int y = -5; y <= 5; y++)
        {
            double x = Math.Pow(y, 2) + 2 * y + 1;
            Console.WriteLine($"{y}\t\t{x}");
        }
    }
    //3. Toc do va thoi gian
    static void Ex03()
    {
        Console.Write("Nhap khoang cach (m): ");
        double distance = double.Parse(Console.ReadLine());
        Console.Write("Nhap so gio: ");
        double hours = double.Parse(Console.ReadLine());
        Console.Write("Nhap so phut ");
        double minutes = double.Parse(Console.ReadLine());
        Console.Write("Nhap so giay ");
        double seconds = double.Parse(Console.ReadLine());
        double distanceKm = distance / 1000;
        double distanceMiles = distance / 1609.34; // 1 mile = 1609.34 meters
        double timeHours = hours + (minutes / 60) + (seconds / 3600);
        double speedKmH = distanceKm / timeHours; // speed in kilometers per hour
        double speedMilesH = distanceMiles / timeHours; // speed in miles per hour
        Console.WriteLine($"Toc do: {speedKmH} km/h");
        Console.WriteLine($"Toc do: {speedMilesH} miles/h");
    }
    //4. Dien tich be mat va the tich hinh cau
    static void Ex04()
    {
        Console.Write("Nhap ban kinh r: ");
        float radius = float.Parse(Console.ReadLine());
        double surface = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Dien tich be mat hinh cau la: {surface}");
        Console.WriteLine($"The tich hinh cau la: {volume}");
    }
    //5. Kiem tra mot ky tu
    static void Ex05()
    {
        Console.Write("Nhap mot ky tu: ");
        char c = Console.ReadKey().KeyChar;
        if (char.IsDigit(c))
        {
            Console.WriteLine($"\n'{c}' la mot chu so.");
        }
        else if ("ueoaiUEOAI".IndexOf(c) >= 0)
        {
            Console.WriteLine($"\n'{c}' la mot nguyen am.");
        }
        else
        {
            Console.WriteLine($"\n'{c}' la mot ky hieu khac.");
        }
    }
}