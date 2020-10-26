using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2PAIS
{
    public partial class Form1 : Form
    {
        double CH;
        double DP;
        double A;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //подача заявки на расчет числ персонала
        {
            button1.Visible = false;
            button2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e) //кнопка ОК номер 1
        {
            double op_f, b_f;
            op_f = 0;
            b_f = 0;
            bool a = false;
            try
            {
                op_f = Convert.ToDouble(textBox1.Text);
                b_f = Convert.ToDouble(textBox2.Text);

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Пожалуйста, введите корректные данные!");
                a = true;
            }
            if (a == false)
            {
                button2.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                CH = op_f/b_f;

                label3.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //введите ОП
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //введите В
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //тб ОП
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Тб В
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //планируются ли
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //только развитие прдеприятия
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //только частичная замена практиков
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            textBox5.Visible = true;
            button7.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //и развитие и замена
            label3.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            button8.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //введите апл
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //кв
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //аб
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //апл
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //аб
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            //кв
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //ок2 для апл и вб
            double apl_f, ab_f;
            apl_f = 0;
            ab_f = 0;
            bool a = false;
            try
            {
                apl_f = Convert.ToDouble(textBox3.Text);
                ab_f = Convert.ToDouble(textBox4.Text);

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Пожалуйста, введите корректные данные!");
                a = true;
            }
            if (a == false)
            {
                label4.Visible =false;
                label6.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button6.Visible = false;
                label7.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                DP = apl_f - ab_f;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ок 2 для апл и кв
            double apl_f, kv_f;
            apl_f = 0;
            kv_f = 0;
            bool a = false;
            try
            {
                apl_f = Convert.ToDouble(textBox3.Text);
                kv_f = Convert.ToDouble(textBox5.Text);

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Пожалуйста, введите корректные данные!");
                a = true;
            }
            if (a == false)
            {
                label4.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                textBox5.Visible = false;
                button7.Visible = false;
                label7.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                DP = apl_f*kv_f;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //ок 2 для апл, аб, кв
            double apl_f, kv_f, ab_f;
            apl_f = 0;
            kv_f = 0;
            ab_f = 0;
            bool a = false;
            try
            {
                apl_f = Convert.ToDouble(textBox3.Text);
                kv_f = Convert.ToDouble(textBox5.Text);
                ab_f = Convert.ToDouble(textBox4.Text);

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Пожалуйста, введите корректные данные!");
                a = true;
            }
            if (a == false)
            {
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button8.Visible = false;
                label7.Visible = true;
                button9.Visible = true;
                button10.Visible = true;
                DP = apl_f-ab_f+apl_f * kv_f;
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //глубина планирования на период более трех лет?
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //да
            label7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            button11.Visible = true;
     
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //нет
            label7.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            label10.Visible = true;
            richTextBox1.Visible = true;
            A = CH + DP;
            richTextBox1.Text = "Cогласно произведенному расчету, основные параметры планирования персонала таковы:\nЧ = " + Math.Ceiling(CH) + "\nДП = " + Math.Ceiling(DP) + "\nA = " + Math.Ceiling(A) + "\nТаким образом, для заданных параметров общая потребность предприятия в кадрах составляет " + Math.Ceiling(A) + " сотрудников";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            //введите чр
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //введите кн
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            //ввод чр
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //ввод кн
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //ок 3 для ввода чр и кн

            double cr_f, kn_f;
            cr_f = 0;
            kn_f = 0;
            bool a = false;
            try
            {
                cr_f = Convert.ToDouble(textBox6.Text);
                kn_f = Convert.ToDouble(textBox7.Text);

            }
            catch
            {
                MessageBox.Show("Произошла ошибка. Пожалуйста, введите корректные данные!");
                a = true;
            }
            if (a == false)
            {
                label8.Visible = false;
                label9.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                button11.Visible = false;
                label10.Visible = true;
                richTextBox1.Visible = true;

                A = cr_f * kn_f;

                richTextBox1.Text = "Cогласно произведенному расчету, основные параметры планирования персонала таковы:\nЧ = "+Math.Ceiling(CH)+ "\nДП = "+Math.Ceiling(DP)+ "\nA = "+Math.Ceiling(A)+ "\nТаким образом, для заданных в параметров общая потребность предприятия в кадрах составляет " + Math.Ceiling(A) +" сотрудников";
            }

        }

        private void label10_Click(object sender, EventArgs e)
        {
            //расчет численности персонала получен
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //богатый текстбокс для отчета
        }
    }
}
