int m = UserInput("Введите целое число  M: ", "Ошибка!");
int n = UserInput("Введите целое число N: ", "Ошибка!");

int result = Ackermann(m,n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");




//============================Методы=====================

//------------------------Ввод данных
int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if ((int.TryParse(Console.ReadLine(), out int userNumber)) && userNumber >= 0)

            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


//-------------------Функция Аккермана

int Ackermann(int m, int n)
{
    if(m==0) return n+1;
    if(n==0) return Ackermann(m-1, 1);
    return Ackermann(m-1, Ackermann(m, n-1));
}
