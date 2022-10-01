//просим пользователя ввести длину массива и 
//записываем её в переменную length
Console.WriteLine("Введите длину массива: ");
int length = int.Parse (Console.ReadLine ());

//объявляем переменную array, куда положим результат функции
int [] array = GetNum ();

//объявляем функцию, кот-я возвращает int
int [] GetNum ()
{   
    //объявляем переменные
    // в number будем записывать числа от пользователя
    // в arr - элементы массива
    int number = 0;
    int [ ] arr = new int [length];
    //прописываем цикл for, который i < length раз получает числа от пользователя
    //и добавляет их в массив
    for(int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i+1} число: ");
        number = int.Parse (Console.ReadLine ());
        arr[i] = number;
    }
    //возвращаем массив
    return arr;
}

//печатаем результат на экран
Console.WriteLine($"[{String.Join(",", array)}]");