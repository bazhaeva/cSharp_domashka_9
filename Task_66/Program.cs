int m = UserInput("Введите целое число  M: ", "Ошибка!");
int n = UserInput("Введите целое число N: ", "Ошибка!");

int sum = SumNumbers(m, n);
Console.WriteLine($"M = {m}; N = {n} -> {sum}");


//============================Методы=====================

//-----------Ввод данных
int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if ((int.TryParse(Console.ReadLine(), out int userNumber)) && userNumber > 0)

            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


//-------------Вывод суммы от M до N рекурсией
int SumNumbers(int m, int n)
{
    int sum = 0;
    if (m < n)
    {
        if (m == n)
            return sum + n;

        return m + SumNumbers(m + 1, n);

    }
    else                                        // На случай, если пользователь введет М > N
    {
        if (m == n)
            return sum + n;

        return m + SumNumbers(m - 1, n);
    }
}