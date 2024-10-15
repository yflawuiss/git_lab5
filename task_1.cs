using System;

namespace task_1
{
    public class TCircle<T> where T : struct, IConvertible
    {
        // Поле для зберігання радіуса
        private T radius;

        // Конструктор без параметрів
        public TCircle()
        {
            radius = default(T);
        }

        // Конструктор з параметрами
        public TCircle(T r)
        {
            radius = r;
        }

        // Конструктор копіювання
        public TCircle(TCircle<T> circle)
        {
            radius = circle.radius;
        }

        // Метод для введення радіуса (запрошення для введення даних)
        public void Input()
        {
            Console.Write("Введiть радiус кола: ");
            radius = (T)Convert.ChangeType(Convert.ToDouble(Console.ReadLine()), typeof(T));
        }

        // Метод для виведення радіуса
        public void Output()
        {
            // Форматоване виведення
            Console.WriteLine($"Радiус кола: {Convert.ToDouble(radius):F2}");
        }

        // Метод для отримання радіуса
        public T GetRadius()
        {
            return radius;
        }

        // Метод для обчислення площі круга
        public double Area()
        {
            return Math.PI * Convert.ToDouble(radius) * Convert.ToDouble(radius);
        }

        // Метод для обчислення площі сектора
        public double SectorArea(double angle)
        {
            return 0.5 * Convert.ToDouble(radius) * Convert.ToDouble(radius) * angle;
        }

        // Метод для обчислення довжини кола
        public double Length()
        {
            return 2 * Math.PI * Convert.ToDouble(radius);
        }

        // Порівняння радіусів двох кіл
        public bool CompareTo(TCircle<T> other)
        {
            return Convert.ToDouble(this.radius) == Convert.ToDouble(other.radius);
        }

        // Перевантаження оператора + (додавання радіусів двох кіл)
        public static TCircle<T> operator +(TCircle<T> a, TCircle<T> b)
        {
            return new TCircle<T>((T)Convert.ChangeType(Convert.ToDouble(a.radius) + Convert.ToDouble(b.radius), typeof(T)));
        }

        // Перевантаження оператора - (віднімання радіусів)
        public static TCircle<T> operator -(TCircle<T> a, TCircle<T> b)
        {
            return new TCircle<T>((T)Convert.ChangeType(Convert.ToDouble(a.radius) - Convert.ToDouble(b.radius), typeof(T)));
        }

        // Перевантаження оператора * (множення радіуса на число)
        public static TCircle<T> operator *(TCircle<T> a, double multiplier)
        {
            return new TCircle<T>((T)Convert.ChangeType(Convert.ToDouble(a.radius) * multiplier, typeof(T)));
        }
    }

    class Program
    {
        static void Main()
        {
            // Опис змінних
            TCircle<double> circle1 = new TCircle<double>();  // Створення першого кола
            TCircle<double> circle2 = new TCircle<double>();  // Створення другого кола

            // Введення радіусів двох кіл
            Console.WriteLine("   <~<~ Введення даних для першого кола ~>~>");
            circle1.Input();  // Запрошення для введення даних
            Console.WriteLine("   <~<~ Введення даних для другого кола ~>~>");
            circle2.Input();  // Запрошення для введення даних

            // Запит на вибір множник
            Console.Write("Введiть число, на яке буде множитися радiуси двох кiл: ");
            double multiplier = Convert.ToDouble(Console.ReadLine());

            // Обчислення площі та довжини кола
            double area1 = circle1.Area();
            double area2 = circle2.Area();
            double length1 = circle1.Length();
            double length2 = circle2.Length();

            // Форматоване виведення результатів у три стовпці
            Console.WriteLine($"\n{"Площа",-30}{"Довжина",-20}"); // Заголовки стовпців
            Console.WriteLine(string.Format("{0,-30}{1,-20}", $"1-го кола: {area1:F2}", $"1-го кола: {length1:F2}")); // Перший рядок
            Console.WriteLine(string.Format("{0,-30}{1,-20}", $"2-го кола: {area2:F2}", $"2-го кола: {length2:F2}")); // Другий рядок

            // Порівняння кіл за радіусами
            if (circle1.CompareTo(circle2))
            {
                Console.WriteLine("\nКола мають однаковий радiус.");
            }
            else
            {
                Console.WriteLine("\nКола мають рiзний радiус.");
            }

            // Використання перевантажених операторів
            TCircle<double> sumCircle = circle1 + circle2;  // Додавання радіусів
            TCircle<double> diffCircle = circle1 - circle2;  // Віднімання радіусів
            TCircle<double> scaledCircle1 = circle1 * multiplier;  // Множення радіуса на число
            TCircle<double> scaledCircle2 = circle2 * multiplier;  // Множення радіуса на число

            // Форматоване виведення результатів операцій
            Console.WriteLine($"\nРадiус кола пiсля додавання обох: {sumCircle.GetRadius():F2}");
            Console.WriteLine($"Радiус кола пiсля вiднiмання 2-го вiд 1-го: {diffCircle.GetRadius():F2}");
            Console.WriteLine($"Радiус 1-го кола пiсля множення на {multiplier}: {scaledCircle1.GetRadius():F2}");
            Console.WriteLine($"Радiус 2-го кола пiсля множення на {multiplier}: {scaledCircle2.GetRadius():F2}");
        }
    }
}