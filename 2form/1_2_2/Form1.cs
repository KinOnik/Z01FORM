using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool notEven = false;
            bool notDoubleDigit = false;
            try
            {
                int num = Convert.ToInt32(textBox1.Text);
                if (num < 10 || num > 99)
                {
                    Otvet.Text = "Не двузначное";
                    notDoubleDigit = true;
                    throw new Exception("");
                }
                if (((num % 10) + (num / 10)) % 2 == 0)
                {
                    Otvet.Text = "Да!";
                }
                else
                {
                    Otvet.Text = "нет";
                    notEven = true;
                    throw new Exception("");
                }
            }
            catch (Exception) when (notEven)
            {
                MessageBox.Show(
                      "Сумму чисел нечетная!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
                notEven = false;
            }
            catch (Exception) when (notDoubleDigit)
            {
                MessageBox.Show(
                      "Число не двузначное!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
                notDoubleDigit = false;
            }
            catch (Exception)
            {
                Otvet.Text = "НЕ ЧИСЛО";
                MessageBox.Show(
                      "Введено не число!",
                      "Предупреждение",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning,
                      MessageBoxDefaultButton.Button3);
            }
        }
    }
}
