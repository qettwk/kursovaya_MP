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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string surname_client;
            int number = 0;
            int duration_order;

            string date_order;
            string date_completion;


            for (int i = 0; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)
            {
                

                    number = Convert.ToInt32(((Form1)this.Owner).dataGridView1[1, i].Value);
                    surname_client = Convert.ToString(((Form1)this.Owner).dataGridView1[0, i].Value);
                    
                    date_order = Convert.ToString(((Form1)this.Owner).dataGridView1[3, i].Value);
                    DateTime date_order_time = Convert.ToDateTime(date_order);

                    date_completion = Convert.ToString(((Form1)this.Owner).dataGridView1[4, i].Value);
                    DateTime date_completion_time = Convert.ToDateTime(date_completion);

                    
                    duration_order = (date_completion_time - date_order_time).Days;
                
                    dataGridView2.Rows.Add(surname_client, number, duration_order);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
