using System;

namespace example_3
{
    // Клас Sorter, що містить узагальнений метод SelectionSort
    class Sorter
    {
        // Узагальнений метод сортування простим вибором
        public static void SelectionSort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[index]) < 0)
                        index = j;
                }

                // Обмін елементів
                T temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Масив цілих чисел
            Console.WriteLine("    <~<~ intArray ~>~>");
            int[] intArray = { 2, 5, 6, 1, 3, 4 };
            Console.Write("Початковий масив intArray: ");
            PrintArray(intArray);

            // Сортування масиву intArray
            Sorter.SelectionSort(intArray);
            Console.Write("Вiдсортований масив intArray: ");
            PrintArray(intArray);

            // Масив рядків
            Console.WriteLine("\n    <~<~ strArray ~>~>");
            string[] strArray = { "water", "cracker", "cherry", "wire" };
            Console.Write("Початковий масив strArray: ");
            PrintArray(strArray);

            // Сортування масиву strArray
            Sorter.SelectionSort(strArray);
            Console.Write("Вiдсортований масив strArray: ");
            PrintArray(strArray);
        }

        // Mетод для виведення масивів
        static void PrintArray<T>(T[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}