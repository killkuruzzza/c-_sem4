//Напишите программу, которая принимает 
//на вход число N и выдаёт произведение чисел от 1 до N.
Clear();
Write("Введите число: ");
int num = int.Parse(ReadLine());
WriteLine($"Произведение цифр = {GetMultiply(num)}");


int GetMultiply(int number)
{
    int result = 1;
    for (int i = 2; i <= number; i++)
    {
        result *= i;
    }
    return result;
}
