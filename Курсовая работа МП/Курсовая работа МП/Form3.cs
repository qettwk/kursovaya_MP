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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname_entered = textBox1.Text;                                         //считывание введённых пользователем данных
            for (int i = ((Form1)this.Owner).dataGridView1.RowCount - 1; i >= 0; i--)       //перебор всех ячеек с фамилиями
            {
                string surname_client = Convert.ToString(((Form1)this.Owner).dataGridView1 [0, i].Value);        //считывание значения из каждой ячейки

                if (surname_entered == surname_client)                                      //если введённое значение совпадает со значением ячейки, то происходит удаление из основной таблицы (Form1) строки с данной ячейкой
                {

                    ((Form1)this.Owner).dataGridView1.Rows.Remove(((Form1)this.Owner).dataGridView1.Rows[i]);

                }
            }
            Close();
        }
    }
}
