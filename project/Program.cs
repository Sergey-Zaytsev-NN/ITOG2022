// ## Задача:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;
using static System.Console;

Clear();

string[] massive = EnterArray();
string[] vuvod = FindLessThan(massive, 3);
WriteLine($"[{string.Join(", ", massive)}] -> [{string.Join(", ", vuvod)}]");

string[] FindLessThan(string[] input, int c) 
{
    string[] output = new string[CountLessThan(input, c)];

    for(int a = 0, b = 0; a < input.Length; a++) 
    {
        if(input[a].Length <= c) {
            output[b] = input[a];
            b++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int c) 
{
    int count = 0;

    for(int a = 0; a < input.Length; a++) {
        if(input[a].Length <= c) {
            count++;
        }
    }

    return count;
}

string[] EnterArray() 
{
    Write("Введите ваши значения через пробел: ");
    return ReadLine().Split(" ");
}