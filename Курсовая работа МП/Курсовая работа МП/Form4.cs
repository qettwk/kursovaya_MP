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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string master_entered = textBox1.Text;                                                              //считывание введённой пользователем фамилии
            int count_orders = 0;                                                                               //инициализация переменной, хранящей количество заказов
            for (int i = 0; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)                                //перебор фамилий (всего первого столбца таблицы)
            {
                string master_surname = Convert.ToString(((Form1)this.Owner).dataGridView1[5, i].Value);       //данные берутся из ячейки, конвертируясь в тип String, после чего присваиваются переменной для сравнения
                if (master_entered == master_surname)                                                          //с введённой пользователем фамилией
                {
                    count_orders++;                                                                            //увеличение количества заказов на один после каждого совпадающего сравнения
                }
            }
            textBox2.Text = Convert.ToString(count_orders);                                                    //вывод количества заказов


        }
    }
}
