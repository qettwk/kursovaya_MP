using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Курсовая_работа_МП
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;      //таблица доступка только для чтения, её нельзя редактировать сразу после запуска
        }
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void таблицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void добавитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)   //переход на форму 2 с добавлением заказов
        {
            Form2 F2 = new Form2();
            F2.Show(this);
        }

        private void удалитьЗаказToolStripMenuItem_Click(object sender, EventArgs e)    //удаление выбранного заказа
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void удалитьВсеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)    //удаление всех заказов
        {
            dataGridView1.Rows.Clear();
        }

        private void включитьРежимРедактированияToolStripMenuItem_Click(object sender, EventArgs e) //включение режима редактирования
        {
            dataGridView1.ReadOnly = false;
        }

        private void выключитьРежимРедактированияToolStripMenuItem_Click(object sender, EventArgs e)    //выключение режима редактирования
        {
            dataGridView1.ReadOnly = true;
        }

        private void удалитьВсеЗаказыКлиентаToolStripMenuItem_Click(object sender, EventArgs e)         //переход на форму 3 удаления всех заказов клиента
        {
            Form3 F3 = new Form3();
            F3.Show(this);
        }

        private void количествоЗаказовМастераToolStripMenuItem_Click(object sender, EventArgs e)        //переход на форму 4 определения количества заказов мастера с указанной фамилией
        {
            Form F4 = new Form4();
            F4.Show(this);
        }



        private void самыйДорогойЗаказToolStripMenuItem_Click(object sender, EventArgs e)               //определение стоимости наиболее дорогого заказа
        {
            double current_price;                                                                       //переменная, которая хранит стоимость заказа (строки), рассматриваемого программой в течение данной итерации
            double max_price = 0;                                                                       //переменная, которая хранит максимальную стоимость заказа
            for (int i = 0; i < (dataGridView1.RowCount); i++)                        //цикл для перебора строк
            {
                current_price = Convert.ToDouble(dataGridView1[6, i].Value);         //присвоение переменной данной стоимости заказа значения из ячейки из столбца "Стоимость"
                if (current_price > max_price)                                                          //если нынешняя цена больше максимальной
                    max_price = current_price;                                                             //то максимальной ценой становится нынешняя
            }
            MessageBox.Show("Максимальная цена заказа: " + max_price);                             //отображение максимальной цены заказа в MessageBox
        }



        private void средняяСтоимостьЗаказовToolStripMenuItem_Click(object sender, EventArgs e)     //определение средней цены одной книги
        {
            double current_cost;                                                                    //цена, взятая из ячейки из столбца "Стоимость"
            double summary_cost = 0;                                                                //суммарная стоимость всех заказов для вычисления среднего арифметического
            int count_orders = Convert.ToInt32(dataGridView1.RowCount);                                            //делитель, которому присваивается значение, равное количеству строк (заказов) для вычисления средней стоимости заказов
            for (int i = 0; i < (dataGridView1.RowCount); i++)                    //цикл для перебора строк 
            {
                current_cost = Convert.ToDouble(dataGridView1[6, i].Value);                         //присвоение переменной данной стоимости заказа значения из ячейки из столбца "Стоимость"
                summary_cost = summary_cost + current_cost;                                         //вычисление суммарной стоимости всех заказов
            }

            MessageBox.Show("Средняя цена заказов равна: " + (summary_cost / count_orders));         //отображение средней цены заказа в MessageBox
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Stream mystr = null;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((mystr = openFileDialog1.OpenFile()) != null)
                    {
                        StreamReader myread = new StreamReader(mystr);
                        string[] str;
                        int num = 0;
                        try
                        {
                            string[] str1 = myread.ReadToEnd().Split('\n');
                            num = str1.Count();
                            dataGridView1.RowCount = num - 1;
                            for (int i = 0; i < num; i++)
                            {
                                str = str1[i].Split('ᅠ');
                                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                                {
                                    try
                                    {
                                        dataGridView1.Rows[i].Cells[j].Value = str[j];
                                    }
                                    catch { }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            myread.Close();
                        }
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Stream myStream;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        StreamWriter myWritet = new StreamWriter(myStream);
                        try
                        {
                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {

                                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                                {
                                    myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "ᅠ");
                                }
                                myWritet.WriteLine();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            myWritet.Close();
                        }
                        myStream.Close();
                    }
                }
            }
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 && paths[0].EndsWith(".txt"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else e.Effect = DragDropEffects.None;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            List<string> textLines = File.ReadAllLines(files[0]).ToList();

            string[] str;
            int num = 0;

            num = textLines.Count();
            dataGridView1.RowCount = num;
            for (int i = 0; i < textLines.Count; i++)
            {
                str = textLines[i].Split('ᅠ');
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F5 = new Form5();
            F5.Show(this);
        }

        private void редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F6 = new Form6();
            F6.Show(this);
        }
    }
}
