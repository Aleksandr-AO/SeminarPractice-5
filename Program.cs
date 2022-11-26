﻿/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int [] Randomarray(int size) // Заполнение массива рандомными числами от (100 до 999)
{
    int [] newarray = new int [size];
    for (int i = 0; i < size; i++)
        newarray [i] = new Random().Next(100, 1000); 
    return newarray;
}
void ShowArray (int[] array) //демонстрация массива
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int CountUnevenNumber(int[] array) // Счетчик четных чисел в массиве
{
    int count = 0;
for(int j = 0; j < array.Length; j++)
    if (array[j] % 2 == 0)
    count++;
       return count;
}

Console.WriteLine("Input size of array: ");
int array_size = Convert.ToInt32(Console.ReadLine());

int[] array1 = Randomarray(array_size);
ShowArray(array1);

int array2 = CountUnevenNumber(array1);
Console.WriteLine($"Count even number: {array2}");






/*
Задача 36: 
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0





Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76


*/