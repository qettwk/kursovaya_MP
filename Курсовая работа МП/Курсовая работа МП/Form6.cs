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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        int i;

        private void button2_Click(object sender, EventArgs e)
        {

            string entered_data = textBox8.Text; //берётся введённое пользователем значение
            DateTime entered_data_time = Convert.ToDateTime(entered_data);  //перевод в тип DateTime

            for (i = i; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)

            {
                string date_in_cell = Convert.ToString(((Form1)this.Owner).dataGridView1[3, i].Value);  //берётся значение из таблицы
                DateTime date_in_cell_time = Convert.ToDateTime(date_in_cell);  //значение в DateTime

                int result = DateTime.Compare(entered_data_time, date_in_cell_time);    //сравнение
                if (result < 0)                                                         //если позже
                {

                    textBox1.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[0, i].Value);
                    textBox2.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[1, i].Value);
                    textBox3.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[2, i].Value);
                    textBox4.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[3, i].Value);
                    textBox5.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[4, i].Value);
                    textBox6.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[5, i].Value);
                    textBox7.Text = Convert.ToString(((Form1)this.Owner).dataGridView1[6, i].Value);
                    break;
                }
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы просмотрели всех клиентов у которых дата превышает заданную");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form1)this.Owner).dataGridView1[0, i].Value = textBox1.Text;
                ((Form1)this.Owner).dataGridView1[1, i].Value = textBox2.Text;
                ((Form1)this.Owner).dataGridView1[2, i].Value = textBox3.Text;
                ((Form1)this.Owner).dataGridView1[3, i].Value = textBox4.Text;
                ((Form1)this.Owner).dataGridView1[4, i].Value = textBox5.Text;
                ((Form1)this.Owner).dataGridView1[5, i].Value = textBox6.Text;
                ((Form1)this.Owner).dataGridView1[6, i].Value = textBox7.Text;
                i++;
            }
            catch
            {
                MessageBox.Show("Изменять больше нечего");
            }
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
