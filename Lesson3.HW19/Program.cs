//Задача 19
Console.WriteLine("Задача 19");
Console.Write("Введите число - ");
string a = Console.ReadLine();

void poli (string str){
    bool flag = true;
    for(int i = 0;i<(int)str.Length/2;i++)
        if(str[i]!=str[str.Length-i-1])
            flag = false;

    if(flag == true)
        Console.WriteLine("Да");
    else
        Console.WriteLine("Нет");
}

poli(a);