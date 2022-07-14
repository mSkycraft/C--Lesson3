// Задача 23

Console.WriteLine("Задача 23");
Console.Write("Введите число - ");
int a = int.Parse(Console.ReadLine());


void cube (int a){
    for(int i = 1;i<=a;i++)
        Console.Write(Math.Pow(i,3)+" ");
    Console.WriteLine();
}


cube(a);