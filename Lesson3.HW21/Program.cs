// Задача 21
Console.WriteLine("Задача 21");
Console.Write("Введите число x1 - ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите число y1 - ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите число z1 - ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите число x2 - ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите число y2 - ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите число z2 - ");
int z2 = int.Parse(Console.ReadLine());

double length (int x1,int y1,int z1,int x2, int y2, int z2){
    return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
}


Console.WriteLine("Длинна отрезка - "+Math.Round(length(x1,y1,z1,x2,y2,z2),2));