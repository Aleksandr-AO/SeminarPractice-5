/*Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2

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
 
Задача 36: 
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

int [] RandomArray(int size)
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
    newArray [i] = new Random().Next(-100, 100);
    return newArray;
}
 void ShowArray(int [] array)
 {
    for (int j = 0; j < array.Length; j++)
    Console.Write(array [j] + " ");
    Console.WriteLine(); 
     }

int SummElem(int [] summ)
{
    int summPos = 0;
    for (int a = 0; a < summ.Length; a++)
    if (a % 2 != 0)
    {
    summPos += summ[a];
    }
    return summPos;
}

Console.WriteLine("Input size of array: ");
int size1 = Convert.ToInt32(Console.ReadLine());

int[] array1 = RandomArray(size1);
ShowArray(array1);

int result = SummElem(array1);
Console.WriteLine($"the sum of the elements standing in odd positions: {result}");
/*
Задача 38: 
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double [] CreateRandomArray ( int size, int minValue, int maxValue)
{
double [] newArray = new double[size]; 
      for(int i = 0; i < size; i++)
    {
    double newArray1 = new Random().Next(minValue, maxValue); 
    double newArray2 = new Random().NextDouble();
    newArray[i] = newArray1 + newArray2;
    newArray [i] = Math.Round(newArray[i], 3);
    }
    return newArray;
}

void ShowArray(double [] array)
 {
    for (int j = 0; j < array.Length; j++)
    Console.Write(array [j] + " ");
    Console.WriteLine(); 
     }

double NumberMax(double [] array)
{
    double max = array[0];
  for( int i = 1; i < array.Length; i++)
  {
    if(array[i] > max)
    {
      max = array[i];
    }
  }
  return max;
}
double NumberMin(double[] array)
{
    double min = array[0];
  for( int i = 1; i < array.Length; i++)
  {
    if(array[i] < min)
    {
      min = array[i];
    }
  }
  return min;
}

Console.Write("Input size of array: ");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible val of array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible val of array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double [] array = CreateRandomArray (size1, minValue, maxValue);
ShowArray(array);

double resultMax = NumberMax(array);
double resultMin = NumberMin(array);

Console.WriteLine($"the difference between the maximum and minimum array elements: {resultMax - resultMin}");

