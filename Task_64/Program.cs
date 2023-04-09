int n = UserInput("Введите целое число  N: ", "Ошибка!");
int fin = 1;


string result = Numbers(n, fin);

Console.WriteLine($"{n} -> {result}");



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



//-------------Вывод чисел рекурсией
string Numbers(int n, int fin)
{
    if (n == fin)
        return n.ToString();

    return n + " " + Numbers(n - 1, fin);
}