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
    public partial class AdditionalInfoForm : Form
    {
        public AdditionalInfoForm(double area1, double length1, double area2, double length2, bool sameRadius)
        {
            InitializeComponent();

            // Формування рядка з інформацією
            string details = "                                     <~<~ Додаткові відомості ~>~>" + Environment.NewLine + 
                                                                              Environment.NewLine + Environment.NewLine +
                             $" Площа 1-го кола: {area1:F2}" + Environment.NewLine +
                             $" Довжина 1-го кола: {length1:F2}" + Environment.NewLine + Environment.NewLine +
                             $" Площа 2-го кола: {area2:F2}" + Environment.NewLine +
                             $" Довжина 2-го кола: {length2:F2}" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
                             $"{(sameRadius ? "Кола мають однаковий радіус." : "Кола мають різний радіус.")}";

            // Встановлення тексту в TextBox
            tbDetails.Text = details;

            // Робимо текстове поле тільки для читання та блокуємо фокус
            tbDetails.ReadOnly = true;
            tbDetails.GotFocus += (s, e) => this.ActiveControl = null;
        }

        private void tbDetails_TextChanged(object sender, EventArgs e)
        {

        }
    }
}