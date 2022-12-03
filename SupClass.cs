using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace practicalWorkNo12
{
    internal class SupClass
    {
        /// <summary>
        /// Выполняет задание
        /// </summary>
        /// <param name="input">ТекстБокс с входными данными</param>
        /// <param name="result">ТекстБокс с выходными даннымим</param>
        public static void TaskFunc(TextBox input, TextBox result)
        {
            if (input.Text == string.Empty)
            {
                MessageBox.Show("Ввод одного числа - поиск его зеркальной версии, ввод двух чисел - поиск площади и периметра прямоугольника со сторонами a и b, равными этим числам.", "Введено неверное количество чисел!");
                return;
            }

            string[] data = input.Text.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (data.Length == 0 || data.Length > 2)
            {
                MessageBox.Show("Ввод одного числа - поиск его зеркальной версии, ввод двух чисел - поиск площади и периметра прямоугольника со сторонами a и b, равными этим числам.", "Введено неверное количество чисел!");
                return;
            }
            else if (data.Length == 1)
            {
                uint value = uint.Parse(data[0]),
                     valueCopy = value,
                     temp = default;

                if (value == 0)
                {
                    result.Text = $"Число 0, при чтении справа налево, будет выглядеть как 0";
                    return;
                }

                while (value != 0)
                {
                    temp = temp * 10 + value % 10;

                    value /= 10;
                }

                result.Text = $"Число {valueCopy}, при чтении справа налево, будет выглядеть как {temp}";
            }
            else if (data.Length == 2)
            {
                uint aSide = uint.Parse(data[0]),
                     bSide = uint.Parse(data[1]);

                if (aSide == 0 && bSide == 0)
                {
                    result.Text = $"Площадь прямоугольника со сторонами 0 и 0 навна: 0\nЕго периметр равен: 0";
                    return;
                }

                result.Text = $"Площадь прямоугольника со сторонами {aSide} и {bSide} равна: {aSide * bSide}\nЕго периметр равен: {(aSide + bSide) * 2}";
            }
        }
    }
}
