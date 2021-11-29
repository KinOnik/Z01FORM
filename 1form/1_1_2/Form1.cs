using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cubeArea = Convert.ToDouble(textBox1.Text);
                double edge = Math.Sqrt(cubeArea / 6);
                Otvet.Text = edge.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Вы ввели не число!",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button3);
            }
        }
    }
}
