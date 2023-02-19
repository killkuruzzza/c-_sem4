﻿Console.Clear();
Console.Write("Введите число: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[");
for (int i = 0; i < num - 1; i++){
    Console.Write($"{array[i]}, ");
}Console.Write($"{array[num - 1]}]");


int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}
/*
**Задача 1:**Напишите функцию, которая принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4-> 16

-- -

**Задача 2:**Напишите программу, которая принимает на вход число и
 выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Важно: не использовать строки, использовать только арифметические действия

---

**Задача 3:**Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]




/*На столе лежат n монеток. Некоторые из них лежат вверх решкой,
 а некоторые – гербом. Определите минимальное число монеток,
  которые нужно перевернуть, чтобы все монетки были повернуты вверх одной
   и той же стороной.

Монетки
Входные данные
В первой строке входного файла INPUT.TXT записано натуральное 
число N (1 ≤ N ≤ 100) – число монеток. В каждой из последующих N строк
 содержится одно целое число – 1 если монетка лежит решкой вверх и 0 если вверх гербом.

Выходные данные
В выходной файл OUTPUT.TXT выведите минимальное количество монет,
 которые нужно перевернуть.*/
// int n = int.Parse(Console.ReadLine());
// int[] mas = new int[n];
// for (int i = 0; i < n;i ++){
//     int j = int.Parse(Console.ReadLine());
//     mas[i] = j;
// }