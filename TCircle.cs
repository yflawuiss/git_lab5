using System;

namespace task_2
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
}