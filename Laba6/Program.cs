using System;
using System.Collections;
using System.Collections.Generic;
using Laba6;

class program
{

    //Перше завдання


    static void Main(string[] args)
    {
        MyList<int> list = new MyList<int>();
        while (true)
        {
            Console.WriteLine("1.Додати елемент");
            Console.WriteLine("2.Переглянути елемент за iндексом");
            Console.WriteLine("3.Кiлькiсть елементiв в списку");
            Console.WriteLine("4.Усi елементи списку");
            Console.WriteLine("Уведiть будь-яке iнше число щоб вийти");
            int code = 0;
            try
            {
                code = Convert.ToInt32(Console.ReadLine());
            }
            catch
            { return; }
            switch (code)
            {
                case 1:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Уведiть число:");
                        list.Add(Convert.ToInt32(Console.ReadLine()));
                        Console.Clear();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Уведiть iндекс:");
                        Console.WriteLine(list[Convert.ToInt32(Console.ReadLine())]);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("Кiлькiсть елементiв в списку: " + list.Count);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                case 4:
                    {
                        for (int i = 0; i < list.Count; i++)
                            Console.Write(list[i] + " ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                default:
                    return;
            }
        }
    }


    //Друге завдання


    //static void Main()
    //{
    //    MyDictionary<string, int> dictionary = new MyDictionary<string, int>();
    //    while (true)
    //    {
    //        Console.WriteLine("1.Додати елемент");
    //        Console.WriteLine("2.Переглянути елемент за iндексом");
    //        Console.WriteLine("3.Кiлькiсть елементiв в списку");
    //        Console.WriteLine("4.Усi елементи списку");
    //        Console.WriteLine("Уведiть будь-яке iнше число щоб вийти");
    //        int code = 0;
    //        try
    //        {
    //            code = Convert.ToInt32(Console.ReadLine());
    //        }
    //        catch
    //        { return; }
    //        switch (code)
    //        {
    //            case 1:
    //                {
    //                    Console.WriteLine();
    //                    Console.WriteLine("Уведiть ключ:");
    //                    string key = Console.ReadLine();
    //                    Console.WriteLine("Уведiть число:");
    //                    int value = Convert.ToInt32(Console.ReadLine());
    //                    dictionary.Add(key, value);
    //                    Console.Clear();
    //                    break;
    //                }

    //            case 2:
    //                {
    //                    Console.WriteLine();
    //                    Console.WriteLine("Уведiть iндекс:");
    //                    Console.WriteLine(dictionary[Convert.ToInt32(Console.ReadLine())]);
    //                    Console.ReadKey();
    //                    Console.Clear();
    //                    break;
    //                }

    //            case 3:
    //                {
    //                    Console.WriteLine("Кiлькiсть елементiв в списку: " + dictionary.Count);
    //                    Console.ReadKey();
    //                    Console.Clear();
    //                    break;
    //                }
    //            case 4:
    //                {
    //                    for (int i = 0; i < dictionary.Count; i++)
    //                        Console.Write(dictionary[i] + " ");
    //                    Console.ReadKey();
    //                    Console.Clear();
    //                    break;
    //                }
    //            default:
    //                return;
    //        }
    //    }
    //}


    //Третє завдання


    //public static void Main()
    //{
    //    MyList<int> list = new MyList<int>();
    //    list.Add(1);
    //    list.Add(2);
    //    list.Add(3);
    //    var arr = list.ToArray();
    //    foreach (var it in arr)
    //        Console.Write($"{it} ");
    //    Console.WriteLine();
    //}
}