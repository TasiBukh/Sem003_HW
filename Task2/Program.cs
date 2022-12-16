﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число: ");
int cube = int.Parse(Console.ReadLine());

void Cube (int[] cube)
{
    int counter = 0;
    int length = cube.Length;
    while (counter < length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    while (index < count)
    {
        Console.WriteLine(coll[index]+ " ");
        index++;
    }
}

int[] array = new int[cube+1];
Cube(array);
PrintArray(array);