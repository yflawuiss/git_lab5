using System;

namespace example_1
{
    class Array<T>
    {
        // Поле для збереження об'єктів довільного типу
        T[] elements;

        // Конструктор узагальненого класу
        public Array(params T[] args)
        {
            elements = new T[args.Length];
            args.CopyTo(elements, 0);
        }

        // Індексатор для доступу до елементів узагальненого масиву
        public T this[int index]
        {
            set
            {
                if (index < 0 || index >= elements.Length)
                    throw new Exception("Iндекс елемента виходить за межi масиву.");
                elements[index] = value;
            }
            get
            {
                if (index < 0 || index >= elements.Length)
                    throw new Exception("Iндекс елемента виходить за межi масиву.");
                return elements[index];
            }
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Узагальнений масив для типу int
                Array<int> intArray = new Array<int>(2, 4, 6, 8, 10);
                Console.WriteLine(intArray[2]);  // Виведе 6

                intArray[3] = -5;
                Console.WriteLine(intArray[3]);  // Виведе -5

                intArray[-1] = 5;  // Спричинення виводу повідомлення про вихід за межі масиву
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Повідомлення про вихід за межі масиву
            }

            try
            {
                // Узагальнений масив для типу string
                Array<string> strArray = new Array<string>("apple", "strawberry", "camera");
                Console.WriteLine(strArray[0]);  // Виведе apple

                strArray[1] = "orange";
                Console.WriteLine(strArray[1]);  // Виведе orange

                strArray[3] = "brick";  // Спричинення виводу повідомлення про вихід за межі масиву
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  // Повідомлення про вихід за межі масиву
            }
        }
    }
}