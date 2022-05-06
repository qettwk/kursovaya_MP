
namespace Курсовая_работа_МП
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьРежимРедактированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьРежимРедактированияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.итогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяСтоимостьЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЗаказовМастераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самыйДорогойЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(13, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия клиента";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Номер заказа";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Наименование изделия";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата приёма заказа";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Дата выполнения заказа";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Фамилия мастера";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Стоимость заказа";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.таблицаToolStripMenuItem,
            this.изменениеToolStripMenuItem,
            this.итогоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1267, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // таблицаToolStripMenuItem
            // 
            this.таблицаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказToolStripMenuItem,
            this.включитьРежимРедактированияToolStripMenuItem,
            this.выключитьРежимРедактированияToolStripMenuItem,
            this.удалитьЗаказToolStripMenuItem,
            this.удалитьВсеЗаказыToolStripMenuItem});
            this.таблицаToolStripMenuItem.Name = "таблицаToolStripMenuItem";
            this.таблицаToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.таблицаToolStripMenuItem.Text = "Заказы";
            this.таблицаToolStripMenuItem.Click += new System.EventHandler(this.таблицаToolStripMenuItem_Click);
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            this.добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            this.добавитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.добавитьЗаказToolStripMenuItem.Text = "Добавить заказ";
            this.добавитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказToolStripMenuItem_Click);
            // 
            // включитьРежимРедактированияToolStripMenuItem
            // 
            this.включитьРежимРедактированияToolStripMenuItem.Name = "включитьРежимРедактированияToolStripMenuItem";
            this.включитьРежимРедактированияToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.включитьРежимРедактированияToolStripMenuItem.Text = "Включить режим редактирования";
            this.включитьРежимРедактированияToolStripMenuItem.Click += new System.EventHandler(this.включитьРежимРедактированияToolStripMenuItem_Click);
            // 
            // выключитьРежимРедактированияToolStripMenuItem
            // 
            this.выключитьРежимРедактированияToolStripMenuItem.Name = "выключитьРежимРедактированияToolStripMenuItem";
            this.выключитьРежимРедактированияToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.выключитьРежимРедактированияToolStripMenuItem.Text = "Выключить режим редактирования";
            this.выключитьРежимРедактированияToolStripMenuItem.Click += new System.EventHandler(this.выключитьРежимРедактированияToolStripMenuItem_Click);
            // 
            // удалитьЗаказToolStripMenuItem
            // 
            this.удалитьЗаказToolStripMenuItem.Name = "удалитьЗаказToolStripMenuItem";
            this.удалитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.удалитьЗаказToolStripMenuItem.Text = "Удалить заказ";
            this.удалитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаказToolStripMenuItem_Click);
            // 
            // удалитьВсеЗаказыToolStripMenuItem
            // 
            this.удалитьВсеЗаказыToolStripMenuItem.Name = "удалитьВсеЗаказыToolStripMenuItem";
            this.удалитьВсеЗаказыToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.удалитьВсеЗаказыToolStripMenuItem.Text = "Удалить все заказы";
            this.удалитьВсеЗаказыToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеЗаказыToolStripMenuItem_Click);
            // 
            // изменениеToolStripMenuItem
            // 
            this.изменениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem,
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem});
            this.изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            this.изменениеToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.изменениеToolStripMenuItem.Text = "Изменение";
            // 
            // удалитьВсеЗаказыКлиентаToolStripMenuItem
            // 
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem.Name = "удалитьВсеЗаказыКлиентаToolStripMenuItem";
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem.Size = new System.Drawing.Size(587, 26);
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem.Text = "Удалить все заказы клиента";
            this.удалитьВсеЗаказыКлиентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеЗаказыКлиентаToolStripMenuItem_Click);
            // 
            // редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem
            // 
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem.Name = "редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem";
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem.Size = new System.Drawing.Size(587, 26);
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem.Text = "Редактирование заказов, у которых дата приёма позже определённой";
            this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem.Click += new System.EventHandler(this.редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem_Click);
            // 
            // итогоToolStripMenuItem
            // 
            this.итогоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.средняяСтоимостьЗаказовToolStripMenuItem,
            this.количествоЗаказовМастераToolStripMenuItem,
            this.самыйДорогойЗаказToolStripMenuItem});
            this.итогоToolStripMenuItem.Name = "итогоToolStripMenuItem";
            this.итогоToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.итогоToolStripMenuItem.Text = "Итого";
            // 
            // средняяСтоимостьЗаказовToolStripMenuItem
            // 
            this.средняяСтоимостьЗаказовToolStripMenuItem.Name = "средняяСтоимостьЗаказовToolStripMenuItem";
            this.средняяСтоимостьЗаказовToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.средняяСтоимостьЗаказовToolStripMenuItem.Text = "Средняя стоимость заказов";
            this.средняяСтоимостьЗаказовToolStripMenuItem.Click += new System.EventHandler(this.средняяСтоимостьЗаказовToolStripMenuItem_Click);
            // 
            // количествоЗаказовМастераToolStripMenuItem
            // 
            this.количествоЗаказовМастераToolStripMenuItem.Name = "количествоЗаказовМастераToolStripMenuItem";
            this.количествоЗаказовМастераToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.количествоЗаказовМастераToolStripMenuItem.Text = "Количество заказов мастера";
            this.количествоЗаказовМастераToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаказовМастераToolStripMenuItem_Click);
            // 
            // самыйДорогойЗаказToolStripMenuItem
            // 
            this.самыйДорогойЗаказToolStripMenuItem.Name = "самыйДорогойЗаказToolStripMenuItem";
            this.самыйДорогойЗаказToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.самыйДорогойЗаказToolStripMenuItem.Text = "Самый дорогой заказ";
            this.самыйДорогойЗаказToolStripMenuItem.Click += new System.EventHandler(this.самыйДорогойЗаказToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(397, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заказы пошива одежды";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(36, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Посмотреть продолжительности заказов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1267, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem таблицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьРежимРедактированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьРежимРедактированияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеЗаказыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеЗаказыКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаказовУКоторыхДатаПриёмаПозжеОпределённойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem итогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЗаказовМастераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самыйДорогойЗаказToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem средняяСтоимостьЗаказовToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

