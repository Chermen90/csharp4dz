//просим пользователя ввести число 
Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine ());

//выводим результат функции при условии, что введённое 
//пользователем число было больше 9, иначе сообщаем ему, что он ввёл однозначное число
if(number > 9)
{
    Console.WriteLine ($"Сумма цифр в числе {number} равна {GetNumber(number)}");
}
else
{
    Console.WriteLine ($"Вы ввели однозначное число");
}


// объявляем функцию, которая принимает int - число от пользователя - и выдаёт int
int GetNumber (int number)
{
    //объявляем переменные
    int newNum = 0;
    int sum = 0;

    //через цикл while проходим по числу, 
    //в переменную newNum записываем последнюю цифру числа
    //в переменную sum записываем сумму цифр из переменной newNum

    while(number > 0)
        {
        newNum = number % 10;
        number = number / 10;
        sum += newNum;
        }
    

    
    //возвращаем результат в переменной num
    return sum;    
}


