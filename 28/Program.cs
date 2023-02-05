//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение цифр = {GetMultiply(num)}");

int GetMultiply(int n){ // n=4
    int result = 1;
    for (int i = 2; i <= n; i++){ // i <= n; 5 <= 4
        result *= i; // result = 6 * 4 = 24;
    }
    return result;
}
//30 Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]