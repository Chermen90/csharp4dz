Console.Clear();
//просим пользователя ввести первое число
Console.WriteLine("Введите первое число: ");
int firstNumber = int.Parse (Console.ReadLine ());

// и второе число
Console.WriteLine("Введите второе число: ");
int secNumber = int.Parse (Console.ReadLine ());

//выводим результат функции на экран
Console.WriteLine ($"Число {firstNumber} в степени {secNumber} равно {GetResult(firstNumber, secNumber)}");


//функция принимает два элемента int и выдаёт результат в виде double
double GetResult (int firstNumber, int secNumber)
{   double result = Math.Pow(firstNumber, secNumber);   
    return result;
}
