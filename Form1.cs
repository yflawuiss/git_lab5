using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Робимо текстові поля тільки для читання та блокуємо фокус
            tbAfterAdd.ReadOnly = true;
            tbAfterAdd.GotFocus += (s, e) => this.ActiveControl = null;

            tbAfterDiff.ReadOnly = true;
            tbAfterDiff.GotFocus += (s, e) => this.ActiveControl = null;

            tbR1AfterMultiplier.ReadOnly = true;
            tbR1AfterMultiplier.GotFocus += (s, e) => this.ActiveControl = null;

            tbR2AfterMultiplier.ReadOnly = true;
            tbR2AfterMultiplier.GotFocus += (s, e) => this.ActiveControl = null;
        }
        private void lbMultiplier_Click(object sender, EventArgs e)
        {

        }

        private void lbR1_Click(object sender, EventArgs e) 
        {
            
        }

        private void lbR2_Click(object sender, EventArgs e)
        {

        }

        private void lbAfterDiff_Click(object sender, EventArgs e)
        {

        }

        private void lbAfterAdd_Click(object sender, EventArgs e)
        {

        }

        private void lbR1AfterMultiplier_Click(object sender, EventArgs e)
        {

        }

        private void lbR2AfterMultiplier_Click(object sender, EventArgs e)
        {

        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            // Отримання радіусів з NumericUpDown
            double radius1 = (double)numR1.Value;
            double radius2 = (double)numR2.Value;
            double multiplier = (double)numMultiplier.Value;

            // Створення об'єктів TCircle з використанням узагальнення
            TCircle<double> circle1 = new TCircle<double>(radius1);
            TCircle<double> circle2 = new TCircle<double>(radius2);

            // Обчислення площі та довжини
            double area1 = circle1.Area();
            double length1 = circle1.Length();
            double area2 = circle2.Area();
            double length2 = circle2.Length();

            // Порівняння радіусів
            bool sameRadius = circle1.CompareTo(circle2);

            // Створення та відкриття вікна додаткових відомостей
            AdditionalInfoForm additionalInfoForm = new AdditionalInfoForm(area1, length1, area2, length2, sameRadius);
            additionalInfoForm.Show();

            // Використання перевантажених операторів
            TCircle<double> sumCircle = circle1 + circle2;  // Додавання радіусів
            TCircle<double> diffCircle = circle1 - circle2;  // Віднімання радіусів
            TCircle<double> scaledCircle1 = circle1 * multiplier;  // Множення радіуса на число
            TCircle<double> scaledCircle2 = circle2 * multiplier;  // Множення радіуса на число

            // Вивід результатів суми та різниці радіусів
            tbAfterAdd.Text = $"{sumCircle.GetRadius():F2}";
            tbAfterDiff.Text = $"{diffCircle.GetRadius():F2}";

            // Вивід результатів множення
            tbR1AfterMultiplier.Text = $"{scaledCircle1.GetRadius():F2}";
            tbR2AfterMultiplier.Text = $"{scaledCircle2.GetRadius():F2}";
        }

        private void numR1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numR2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numMultiplier_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbAfterAdd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbAfterDiff_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbR1AfterMultiplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbR2AfterMultiplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Налаштування для NumR1, NumR2, NumMultiplier
            numR1.DecimalPlaces = 2;
            numR1.Increment = 0.5M;
            numR1.Minimum = 0;
            numR1.Maximum = 100;

            numR2.DecimalPlaces = 2;
            numR2.Increment = 0.5M;
            numR2.Minimum = 0;
            numR2.Maximum = 100;

            numMultiplier.DecimalPlaces = 2;
            numMultiplier.Increment = 0.5M;
            numMultiplier.Minimum = -100;
            numMultiplier.Maximum = 100;
        }
    }
}