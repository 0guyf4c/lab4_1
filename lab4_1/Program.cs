//int[] mas = new int[17];
//Random rnd = new Random();
//for (int i = 0; i < 17; i++)
//{
//    mas[i] = rnd.Next(10, 100);
//    Console.Write(mas[i] + " ");
//}
//Console.WriteLine();
//int s = 0;
//for (int i = 0; i < 17; i++)
//{
//    s = s + mas[i] / 10 + mas[i] % 10;
//}
//Console.WriteLine("Сумма цифр = " + s);

//int[] mas = new int[17];
//int sum = 0;
//Console.WriteLine("Введите 17 двузначных целых чисел:");
//for (int i = 0;i < mas.Length; i++)
//{
//    mas[i] = int.Parse(Console.ReadLine()!);
//}
//for(int i = 0; i < mas.Length; i++)
//{
//    int x = Math.Abs(mas[i]);
//    while (x > 0)
//    {
//        sum = sum + x % 10;
//        x = x / 10;
//    }
//}
//Console.WriteLine($"Сумма цифр массива: {sum}");