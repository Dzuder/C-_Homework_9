using static System.Console;
Clear();

//Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

WriteLine(" Введите начало диапазона: ");
int number1 = int.Parse(ReadLine()!);

WriteLine(" Введите конец диапазона: ");
int number2 = int.Parse(ReadLine()!);
WriteLine($"Cумма натуральных элементов в промежутке от {number1} до {number2}:\n {SumSegmentValues(number1, number2)}");


int SumSegmentValues(int min, int max)
{  
    if (min == max) return min;
    return SumSegmentValues(min, max - 1) + max; // совсем не понял как компилятор считает эту строку, просто подсмотрел задачу с семинара и адаптировал.
}