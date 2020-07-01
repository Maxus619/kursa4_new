using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursa4_new
{
    public partial class UISell : UserControl
    {
        public static string connStr = "server = localhost; user = root; database = kurs; port = 3306; password = 1234";
        public MySqlConnection conn = new MySqlConnection(connStr);

        public System.Data.DataTable table = new System.Data.DataTable();
        public System.Data.DataTable table1 = new System.Data.DataTable();
        public System.Data.DataTable table2 = new System.Data.DataTable();
        public System.Data.DataTable table3 = new System.Data.DataTable();

        int sum = 0;
        string nomchek = "";

        public UISell()
        {
            InitializeComponent();

            dataGridView1.ForeColor = Color.Black;
            toolTip1.SetToolTip(this.btnDelete, "Для удаления нажмите на пустой столбец рядом со строкой");
            cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Проверка на оба текстбокса
            if (cbName.Text == "" || tbCount.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            //Проверка на число
            try
            {
                Int32.Parse(tbCount.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Введено неверное количество");
                return;
            }
            //Проверка на значение 0 и меньше
            if (Int32.Parse(tbCount.Text) <= 0)
            {
                MessageBox.Show("Введено неверное количество");
                return;
            }

            MySqlDataAdapter adapter1 = new MySqlDataAdapter(
                "SELECT artikul_lekarstva, price, kolvo " +
                "FROM lekarstva " +
                $"WHERE artikul_lekarstva = {table.Rows[cbName.SelectedIndex][0].ToString()}",
                conn
            );
            adapter1.Fill(table1);

            //Проверка на лекартсво
            if (table1.Rows.Count == 0)
            {
                MessageBox.Show("Товар не найден");
                return;
            }
            bool isLekAdd = false;

            //Поиск лекарства в списке покупок
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //Если лекарство добавлено
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == table.Rows[cbName.SelectedIndex][0].ToString())
                {
                    //Проверка на количество
                    int kol = Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + Int32.Parse(tbCount.Text); //Количество товара в списке + добавляемого
                    if (kol > Int32.Parse(table1.Rows[0][2].ToString()))
                    {
                        MessageBox.Show($"Невозможно добавить, товара осталось: {Int32.Parse(table1.Rows[0][2].ToString()) - Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())}");
                        table1.Clear();
                        return;
                    }
                    dataGridView1.Rows[i].Cells[2].Value = kol;
                    sum = sum + (Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) * Int32.Parse(tbCount.Text));
                    lSumm.Text = Convert.ToString(sum) + " руб";
                    isLekAdd = true;
                    break;
                }
            }
            //Если лекарство не было добавлено в список
            if (isLekAdd == false)
            {
                //Проверка на количество
                if (Int32.Parse(table1.Rows[0][2].ToString()) < Int32.Parse(tbCount.Text))
                {
                    MessageBox.Show($"Невозможно добавить, товара осталось: {Int32.Parse(table1.Rows[0][2].ToString())}");
                    table1.Clear();
                    return;
                }
                
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(
                    "SELECT artikul_lekarstva, naimenovanie_lekarstva, price " +
                    "FROM lekarstva " +
                    $"WHERE artikul_lekarstva = {table.Rows[cbName.SelectedIndex][0].ToString()}",
                    conn
                );
                adapter2.Fill(table2);
                this.dataGridView1.Rows.Add(table2.Rows[0][0].ToString(), table2.Rows[0][1].ToString(), tbCount.Text, table2.Rows[0][2]);
                sum = sum + (Int32.Parse(table2.Rows[0][2].ToString()) * Int32.Parse(tbCount.Text));
                lSumm.Text = Convert.ToString(sum) + " руб";
                table2.Clear();
            }
            table1.Clear();
        }

        private void ClearAll()
        {
            cbName.Text = "";
            tbCount.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            lSumm.Text = "0 руб";
            sum = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void btnDone_Click(object sender, EventArgs e)
        {
            //Добавление в таблицу продажа
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Корзина пустая");
                return;
            }
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string query1 = $"INSERT INTO prodaja (data_vremya_prodaji) VALUES ('{sqlFormattedDate}')";
            MySqlCommand command1 = new MySqlCommand(query1, conn);
            conn.Open();
            try
            {
                command1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка формирования покупки");
                return;
            }
            conn.Close();

            //Поиск номера чека
            MySqlDataAdapter adapter3 = new MySqlDataAdapter($"SELECT nomer_checka FROM prodaja", conn);
            table3.Clear();
            adapter3.Fill(table3);
            nomchek = table3.Rows[table3.Rows.Count - 1][0].ToString();

            //Добавление в таблицу чек
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string query2 = $"INSERT INTO chek (nomer_checka, artikul_lekarstva, kolvo_lekarstva, price) VALUES ('{nomchek}', '{dataGridView1.Rows[i].Cells[0].Value.ToString()}', '{dataGridView1.Rows[i].Cells[2].Value.ToString()}', '{dataGridView1.Rows[i].Cells[3].Value.ToString()}')";
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                conn.Open();
                try
                {
                    command2.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка формирования покупки");
                    return;
                }
                //Удаление купленного товара из базы
                string query3 = $"UPDATE lekarstva SET kolvo = kolvo - {dataGridView1.Rows[i].Cells[2].Value.ToString()} WHERE artikul_lekarstva = {dataGridView1.Rows[i].Cells[0].Value.ToString()}";
                MySqlCommand command3 = new MySqlCommand(query3, conn);
                try
                {
                    command3.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка обновления количества");
                    return;
                }
                conn.Close();
            }
            printPreviewDialog1.ShowDialog();
            MessageBox.Show("Покупка совершена");
            ClearAll();
        }

        private void UISell_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void RefreshTable()
        {
            try
            {
                MySqlDataAdapter adapter4 = new MySqlDataAdapter("SELECT artikul_lekarstva, naimenovanie_lekarstva FROM lekarstva", conn);
                adapter4.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    cbName.Items.Add(table.Rows[i][1]);
                }
            }
            catch { }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int row = 300;
            Graphics g = e.Graphics;
            Font messageFont = new Font("Arial", 24, System.Drawing.GraphicsUnit.Point);
            Font messageFont1 = new Font("Arial", 32, FontStyle.Bold);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            StringFormat sf1 = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            g.DrawString("ТОВАРНЫЙ ЧЕК", messageFont, Brushes.Black, new Rectangle(20, 50, 800, 50), sf);
            g.DrawString("Аптека Здрав", messageFont, Brushes.Black, new Rectangle(20, 100, 800, 50), sf);
            g.DrawString("г. Уфа, ул.Кирова д.65", messageFont, Brushes.Black, 100, 150);
            g.DrawString(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString(), messageFont, Brushes.Black, 100, 200);
            g.DrawString("Продажа №" + nomchek, messageFont, Brushes.Black, 100, 250);

            //Список покупок
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                g.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), messageFont, Brushes.Black, 100, row);
                row += 50;
                g.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), messageFont, Brushes.Black, 100, row);
                g.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), messageFont, Brushes.Black, 700, row);
                row += 50;
            }

            g.DrawString("Кассир " + FormMain.fio, messageFont, Brushes.Black, 100, row + 50);
            g.DrawString("Закрытие чека", messageFont, Brushes.Black, 100, row + 100);
            g.DrawString("ИТОГ - " + Convert.ToString(sum), messageFont1, Brushes.Black, 100, row + 150);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}