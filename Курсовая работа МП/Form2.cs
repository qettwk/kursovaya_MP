using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_МП
{
    public partial class Form2 : Form
    {

        public static string surname_client;                                                                                        //объявление переменных, которые будут храниться в таблице
        public static int number;
        public static string clothes;

        public static string date_order;
        public static string date_completion;
        

        public static string surname_master;
        public static double cost;
        public Form2()
        {
            InitializeComponent();
        }
       

        private void label4_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                surname_client = textBox1.Text;                                                                                              //проверка правильности введённых данных
                number = Convert.ToInt32(textBox2.Text);
                clothes = textBox3.Text;

                date_order = textBox4.Text;
                DateTime date_order_time = Convert.ToDateTime(date_order);

                date_completion = textBox5.Text;
                DateTime date_completion_time = Convert.ToDateTime(date_completion);



                surname_master = textBox6.Text;
                cost = Convert.ToDouble(textBox7.Text);
                ((Form1)this.Owner).dataGridView1.Rows.Add(surname_client, number, clothes, date_order, date_completion, surname_master, cost); //заполнение основной таблицы (Form1)
                textBox1.Clear();       //очистка TextBox для заполнения данных нового заказа
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();

            }
            catch
            {
                MessageBox.Show("Данные введены неправильно. Попробуйте ещё раз.");
            }
        }
    }
}
