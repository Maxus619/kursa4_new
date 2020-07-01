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
    public partial class UIGraph : UserControl
    {
        public static string connStr = "server = localhost; user = root; database = kurs; port = 3306; password = 1234";
        public MySqlConnection conn = new MySqlConnection(connStr);

        public MySqlDataAdapter adapter;

        public System.Data.DataTable table = new System.Data.DataTable();
        public System.Data.DataTable table1 = new System.Data.DataTable();

        public UIGraph()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
        }

        public void RefreshTable()
        {
            try
            {
                table1.Clear();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT grafik.nomer_smeni as Номер, grafik.data_grafika as Дата, grafik.smena as Смена, grafik.fio_rabotnika as Фамилия FROM grafik WHERE data_grafika >= current_date()", conn);
                adapter.Fill(table1);
                dataGridView1.DataSource = table1;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string nomer = dataGridView1.Rows[i].Cells[0].Value.ToString();
                adapter = new MySqlDataAdapter($"SELECT nomer_smeni FROM grafik WHERE nomer_smeni = '{nomer}'", conn);
                adapter.Fill(table);

                //Проверка на номер смены
                if (table.Rows.Count > 0)
                { 
                    string data = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    string smena = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    string tabel = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    string query1 = $"UPDATE grafik SET data_grafika = {data}, smena = {smena}, tabelniy_nomer = {tabel} WHERE nomer_smeni = {nomer}";
                    MySqlCommand command1 = new MySqlCommand(query1, conn);
                    conn.Open();
                    try
                    {
                        command1.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка изменения графика");
                        conn.Close();
                        return;
                    }
                    return;
                }

                string query = "INSERT INTO grafik VALUES ()";
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Ошибка изменения графика");
                    conn.Close();
                    return;
                }
                conn.Close();
            }
            //MessageBox.Show("Пользователь добавлен");
            Refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Удалите значение, или исправьте на другое", "Введено неверное значение");
        }
    }
}