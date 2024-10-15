using System;

namespace example_2
{
    // Узагальнений клас Array<T> з обмеженням типу T на реалізацію інтерфейсу IComparable
    class Array<T> where T : IComparable<T>
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

        // Метод для підрахунку кількості елементів, більших за заданий елемент
        public int CountGreaterThan(T elem)
        {
            int count = 0;
            foreach (T e in elements)
            {
                if (e.CompareTo(elem) > 0)
                    count++;
            }
            return count;
        }

        // Метод для виведення всіх елементів масиву
        public void Print()
        {
            foreach (var element in elements)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Узагальнений масив для типу int
                Array<int> intArray = new Array<int>(-5, -1, 0, 1, 5);
                Console.Write("Елементи масиву intArray: ");
                intArray.Print();

                // Використання методу CountGreaterThan
                Console.WriteLine($"Кiлькiсть елементiв, бiльших за -1: {intArray.CountGreaterThan(-1)}");  // Виведе 3

                // Доступ та зміна елементів за допомогою індексатора
                Console.WriteLine($"Елемент за iндексом 2: {intArray[2]}");  // Виведе 0
                intArray[2] = 1;
                Console.WriteLine($"Новий елемент за iндексом 2: {intArray[2]}");  // Виведе 1
       
                intArray[-1] = 5;  // Спричинення виводу повідомлення про вихід за межі масиву
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Узагальнений масив для типу string
                Array<string> strArray = new Array<string>("water", "cracker", "cherry", "wire");
                Console.Write("Елементи масиву strArray: ");
                strArray.Print();

                // Використання методу CountGreaterThan
                Console.WriteLine("Кiлькiсть елементiв, бiльших за 'cracker': " + strArray.CountGreaterThan("cracker"));  // Виведе 2

                // Доступ та зміна елементів за допомогою індексатора
                Console.WriteLine($"Елемент за iндексом 1: {strArray[1]}");  // Виведе cracker
                strArray[1] = "banana";
                Console.WriteLine($"Новий елемент за iндексом 1: {strArray[1]}");  // Виведе banana

                strArray[3] = "brick"; 
                Console.WriteLine(strArray[3]);  // Виведе brick

                strArray[4] = "invalid";  // Спричинення виводу повідомлення про вихід за межі масиву
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}