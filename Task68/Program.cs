using static System.Console;
Clear();
WriteLine("Введите первое число в Функции Аккермана: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите второе число в Функции Аккермана: ");
int b = int.Parse(ReadLine()!);
WriteLine("_______________________________________________");
WriteLine( Ackermann(a, b));



int Ackermann(int x, int y)
{
    if (x == 0) return y + 1;
    else if (y == 0) return Ackermann(x - 1, 1);
    else return Ackermann(x - 1, Ackermann(x, y - 1));
}