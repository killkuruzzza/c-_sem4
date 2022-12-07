// Напишите программу, которая принимает на вход число A
// и выдаёт сумму чисел от 1 до A

Console.Write ("Введите число: ");
int limit = int.Parse (Console.ReadLine ());
Console.WriteLine ($"Сумма чисел от 1 до {limit} равна {GetSum (limit)}");

int GetSum (int limit) {
    int sum = 1;
    for (int i = 1; i <= limit; i++)
        sum *= i;
    return sum;
}


