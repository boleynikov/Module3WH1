using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_HW1
{
    class Starter
    {
        public static void Run()
        {
            CustomList<int> listInt = new CustomList<int>();
            listInt.Add(4);
            listInt.Add(3);
            listInt.Add(2);
            listInt.Add(1);
            Console.WriteLine("Элементы добавленные в массив по одному");
            ShowArray(listInt);
            var newArray = new int[] { 5, 2, 6, 8, 1, 3, 4 };
            listInt.AddRange(newArray);
            Console.WriteLine("Теперь добавили пачкой");
            ShowArray(listInt);
            listInt.Remove(3);
            listInt.Remove(2);
            Console.WriteLine("Коллекция с удалёнными значениями 3 и 2(первое их вхождение)");
            ShowArray(listInt);
            listInt.RemoveAt(5);
            Console.WriteLine("Коллекция с удалённым элементом по индексу 5");
            ShowArray(listInt);
            listInt.Sort();
            Console.WriteLine("Отсортированная коллекция");
            ShowArray(listInt);
            Console.WriteLine();
            CustomList<string> listString = new CustomList<string>();
            listString.Add("Kiev");
            listString.Add("London");
            listString.Add("Buharest");
            listString.Add("Panama");
            Console.WriteLine("Элементы добавленные в массив по одному");
            ShowArray(listString);
            var newStringArray = new string[] { "Tokio", "Praga", "Los-Angeles", "Vena" };
            listString.AddRange(newStringArray);
            Console.WriteLine("Теперь добавили пачкой");
            ShowArray(listString);
            listString.Remove("Tokio");
            listString.Remove("Buharest");
            Console.WriteLine("Коллекция с удалёнными значениями Tokio и Buharest(первое их вхождение)");
            ShowArray(listString);
            listString.RemoveAt(5);
            Console.WriteLine("Коллекция с удалённым элементом по индексу 5");
            ShowArray(listString);
            listString.Sort();
            Console.WriteLine("Отсортированная коллекция");
            ShowArray(listString);
        }
        static void ShowArray(CustomList<string> list)
        {
            foreach (var digit in list)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
        }
        static void ShowArray(CustomList<int> list)
        {
            foreach (var digit in list)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
        }
    }
}
