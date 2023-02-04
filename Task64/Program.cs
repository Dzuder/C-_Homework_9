using static System.Console;
Clear();

//Напишите программу, которая реализует рекурсивный метод вывода всех натуральных числел в промежутке от N до 1


//WriteLine(" Введите первое число: ");
//int number1 = int.Parse(ReadLine()!);

int number1 = 1; // по условиям задачи.

WriteLine(" Введите число: ");
int number2 = int.Parse(ReadLine()!);



GetNumbers(number1, number2);



void GetNumbers(int min, int max)
{
    if (min == max ) Write(min);
    else
    {
        GetNumbers(min + 1, max);
        Write($",{min}");
    }
}