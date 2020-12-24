using System;
using System.Globalization;
using System.Windows.Forms;

namespace TheGraphingOfEquations
{
    public partial class theGraphingOfEquations : Form
    {
        //Функция, которая выставляет дефолтные значения для всех TextBox'ов
        private void SetDefaultValuesToTextBoxes()
        {
            if (coefficientTextBox1.Text.Length == 0)
                coefficientTextBox1.Text = "1";
            if (coefficientTextBox2.Text.Length == 0)
                coefficientTextBox2.Text = "0";
            if (coefficientTextBox3.Text.Length == 0)
                coefficientTextBox3.Text = "0";
            if (leftLimitTextBox.Text.Length == 0)
                leftLimitTextBox.Text = "-10";
            if (rightLimitTextBox.Text.Length == 0)
                rightLimitTextBox.Text = "10";
            if (stepTextBox.Text.Length == 0)
                stepTextBox.Text = "0.1";
        }
        public theGraphingOfEquations()
        {
            InitializeComponent();
            //Сразу после создания формы вызываем функцию, которая выставляет дефолтные значения для всех TextBox'ов
            SetDefaultValuesToTextBoxes();
        }

        //Создаем делегаты для функций рассчета графиков
        private delegate double formula(double x);
        private delegate double formulaSinVars(double x, double cooefficient1, double coefficient2, double coefficient3);

        //Функция для рассчета графика косинуса
        static double CosFormula(double x)
        {
            return Math.Cos(x);
        }

        //Функция для рассчета графика синуса
        static double SinFormula(double x)
        {
            return Math.Sin(x);
        }

        //Функция для рассчета графика синуса + косинуса
        static double SinCosFormula(double x)
        {
            return Math.Sin(x) + Math.Cos(x);
        }

        //Функция для рассчета графика вариаций синуса
        static double SinVarsFormula(double x, double cooefficient1, double coefficient2, double coefficient3)
        {
            return Math.Sin(cooefficient1 * x + coefficient2) + coefficient3;
        }

        //Функция для отрисовки графика по стандартной формуле
        private void DrawGraph(int seriesNum, double leftLimit, double rightLimit, double step, bool checkBox, formula formula)
        {
            //Если нажат checkBox, строим график функции
            if (checkBox)
            {
                double x = leftLimit;
                while (x <= rightLimit)
                {
                    double y = formula(x);
                    mainChart.Series[seriesNum].Points.AddXY(x, y);
                    x += step;
                }
            }
            //Если нет, то удаляем график
            else
                mainChart.Series[seriesNum].Points.Clear();
        }

        //Функция для отрисовки графика по формуле для вариаций синуса
        private void DrawGraph(int seriesNum, double leftLimit, double rightLimit, double step, bool checkBox, formulaSinVars formula)
        {
            //Если нажат checkBox, строим график функции
            if (checkBox)
            {
                double x = leftLimit;
                while (x <= rightLimit)
                {
                    double y = formula(x, Double.Parse(coefficientTextBox1.Text, CultureInfo.InvariantCulture),
                                          Double.Parse(coefficientTextBox2.Text, CultureInfo.InvariantCulture),
                                          Double.Parse(coefficientTextBox3.Text, CultureInfo.InvariantCulture));
                    mainChart.Series[seriesNum].Points.AddXY(x, y);
                    x += step;
                }
            }
            //Если нет, то удаляем график
            else
                mainChart.Series[seriesNum].Points.Clear();
        }

        //Функция, которая отрисовывает график синуса, когда нажат CheckBox
        private void SinCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DrawGraph(1, Double.Parse(leftLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(rightLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(stepTextBox.Text, CultureInfo.InvariantCulture), sinCheckBox.Checked, SinFormula);
        }

        //Функция, которая отрисовывает график косинуса, когда нажат CheckBox
        private void CosCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            DrawGraph(2, Double.Parse(leftLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(rightLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(stepTextBox.Text, CultureInfo.InvariantCulture), cosCheckBox.Checked, CosFormula);
        }

        //Функция, которая отрисовывает график синуса + косинуса, когда нажат CheckBox
        private void SinCosCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            DrawGraph(3, Double.Parse(leftLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(rightLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(stepTextBox.Text, CultureInfo.InvariantCulture), sinCosCheckBox.Checked, SinCosFormula);
        }

        //Функция, которая отрисовывает график вариаций синуса, когда нажата Button
        private void ToGraphTheEquationButton_Click(object sender, EventArgs e)
        {
            SetDefaultValuesToTextBoxes();

            mainChart.Series[0].Points.Clear();
            DrawGraph(0, Double.Parse(leftLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(rightLimitTextBox.Text, CultureInfo.InvariantCulture),
                         Double.Parse(stepTextBox.Text, CultureInfo.InvariantCulture), true, SinVarsFormula);
        }

        //Функция, которая проверяет корректность пользовательского ввода в TextBox'ы
        private void TextBoxInputValidation(KeyPressEventArgs e, TextBox textBox)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (e.KeyChar == Convert.ToChar(Keys.Back))
                return;
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.KeyChar = '.';
                if (textBox.Text.IndexOf('.') != -1)
                    e.Handled = true;
                if (!(textBox.Text.EndsWith("0") ||
                      textBox.Text.EndsWith("1") ||
                      textBox.Text.EndsWith("2") ||
                      textBox.Text.EndsWith("3") ||
                      textBox.Text.EndsWith("4") ||
                      textBox.Text.EndsWith("5") ||
                      textBox.Text.EndsWith("6") ||
                      textBox.Text.EndsWith("7") ||
                      textBox.Text.EndsWith("8") ||
                      textBox.Text.EndsWith("9")))
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == '-')
            {
                if (textBox.Text.IndexOf('-') != -1)
                    e.Handled = true;
                if (textBox.SelectionStart != 0)
                    e.Handled = true;
                return;
            }
            e.Handled = true;
        }

        //Проверка пользовательского ввода для CoefficientTextBox1
        private void CoefficientTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, coefficientTextBox1);
        }

        //Проверка пользовательского ввода для CoefficientTextBox2
        private void CoefficientTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, coefficientTextBox2);
        }

        //Проверка пользовательского ввода для CoefficientTextBox3
        private void CoefficientTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, coefficientTextBox3);
        }

        //Проверка пользовательского ввода для LeftLimitTextBox
        private void LeftLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, leftLimitTextBox);
        }

        //Проверка пользовательского ввода для RightLimitTextBox
        private void RightLimitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, rightLimitTextBox);
        }

        //Проверка пользовательского ввода для StepTextBox
        private void StepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBoxInputValidation(e, stepTextBox);
            if (e.KeyChar == '-')
                e.Handled = true;
        }
    }
}
