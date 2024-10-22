using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Обробник натискання кнопки для обчислення площі куба
        private void btnCalculateCubeArea_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо довжину ребра куба
                double A = Convert.ToDouble(txtCubeEdge.Text);

                // Перевірка на від'ємне або нульове значення
                if (A <= 0)
                {
                    MessageBox.Show("Довжина ребра куба повинна бути більше 0.");
                    return;
                }

                // Обчислюємо площу куба (S = 6 * A^2)
                double cubeSurfaceArea = 6 * Math.Pow(A, 2);

                // Виводимо результат
                txtCubeAreaResult.Text = cubeSurfaceArea.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректне число для довжини ребра куба.");
            }
        }

        // Обробник натискання кнопки для обчислення площі прямокутного паралелепіпеда
        private void btnCalculateParallelepipedArea_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо довжину, ширину та висоту прямокутного паралелепіпеда
                double C = Convert.ToDouble(txtParallelepipedLength.Text);
                double D = Convert.ToDouble(txtParallelepipedWidth.Text);
                double H = Convert.ToDouble(txtParallelepipedHeight.Text);

                // Перевірка на від'ємні або нульові значення
                if (C <= 0 || D <= 0 || H <= 0)
                {
                    MessageBox.Show("Довжина, ширина та висота повинні бути більше 0.");
                    return;
                }

                // Обчислюємо площу прямокутного паралелепіпеда (S = 2 * (C * D + D * H + C * H))
                double parallelepipedSurfaceArea = 2 * (C * D + D * H + C * H);

                // Виводимо результат
                txtParallelepipedAreaResult.Text = parallelepipedSurfaceArea.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа для довжини, ширини та висоти паралелепіпеда.");
            }
        }
    }
}