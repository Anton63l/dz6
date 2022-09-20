// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int[] Spisok(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         System.Console.Write("Введите цифру в массиве: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void Count(int[] array)
// {
//     var counter = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             counter++;
//         }
//     }

//     System.Console.WriteLine($"Вы ввели {counter} чисел больше 0");
// }


// System.Console.Write("Введите количество цифр в массиве: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Count(Spisok(m));


// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



// void Coordinates(float b1, float k1, float b2, float k2)
// {
//     if ((k1 == k2) && (b1 == b2)){
//         System.Console.WriteLine($"Прямые совпадают");

//     }


//     else if (k1==k2){
//         System.Console.WriteLine($"Прямые параллельны");
//     }

//     else
//     {
//         float x = (b2 - b1) / (k1 - k2);
//         float y = k1 * x + b1;
            
//         System.Console.WriteLine($"Точка пересечения прямых ({x},{y})");


//     }

// }

// System.Console.Write("Введите b1: ");
// var b1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите k1: ");
// var k1 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите b2: ");
// var b2 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите k2: ");
// var k2 = Convert.ToInt32(Console.ReadLine());

// Coordinates(b1, k1, b2, k2);