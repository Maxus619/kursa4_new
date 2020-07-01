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
    public partial class UIReg : UserControl
    {
        public static string connStr = "server = localhost; user = root; database = kurs; port = 3306; password = 1234";
        public MySqlConnection conn = new MySqlConnection(connStr);

        public MySqlDataAdapter adapter;

        public DataTable table = new DataTable();
        public DataTable table1 = new DataTable();
        public DataTable table2 = new DataTable();

        int tab; //табельный номер

        public UIReg()
        {
            InitializeComponent();

            dataGridView1.ForeColor = Color.Black;
            cbWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            toolTip1.SetToolTip(this.btnDelete, "Для удаления выделите табельный номер работника и на кнопку удалить");

            CheckTab();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            mtbPass.Text = "";
            tbFName.Text = "";
            tbLName.Text = "";
            tbOtch.Text = "";
            cbWork.Text = "";
        }

        private void CheckTab()
        {
            try
            {
                table2.Clear();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(
                    "SELECT tabelniy_nomer " +
                    "FROM rabotniki " +
                    "ORDER BY tabelniy_nomer DESC LIMIT 1",
                    conn
                );
                adapter2.Fill(table2);
                tab = Int32.Parse(table2.Rows[0][0].ToString()) + 1;
                lTab.Text = Convert.ToString(tab);
            }
            catch { }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            table.Clear();
            //Проверка на пустые текстбоксы
            if (mtbPass.Text == "" || tbLName.Text == "" || tbFName.Text == "" || tbOtch.Text == "")
            {
                MessageBox.Show("Введены не все данные");
                return;
            }
            //Проверка на длину пароля
            if (mtbPass.TextLength < 8)
            {
                MessageBox.Show("Пароль должен содержать не менее 8 символов");
                return;
            }
            //Проверка на символы
            if (mtbPass.Text.Contains("@") || mtbPass.Text.Contains(" "))
            {
                MessageBox.Show("Пароль содержит недопустимые символы");
                return;
            }
            adapter = new MySqlDataAdapter(
                "SELECT tabelniy_nomer " +
                "FROM rabotniki " +
                $"WHERE tabelniy_nomer = '{lTab.Text}'",
                conn
            );
            adapter.Fill(table);
            //Проверка на повтор табельного
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой табельный номер уже используется");
                return;
            }
            string query = $"INSERT INTO rabotniki VALUES ('{lTab.Text}', '{mtbPass.Text}', '{cbWork.Text}', '{tbLName.Text}', '{tbFName.Text}', '{tbOtch.Text}')";
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка добавления");
                conn.Close();
                return;
            }
            conn.Close();
            MessageBox.Show("Пользователь добавлен");
            CheckTab();
            Clear();
            RefreshTable();
        }

        public void RefreshTable()
        {
            try
            {
                table1.Clear();
                dataGridView1.DataSource = null;
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(
                    "SELECT tabelniy_nomer as Табельный, pswd as Пароль, doljnost as Должность, familia_rabotnika as Фамилия, imya_rabotnika as Имя, otchestvo_rabotnika as Отчество " +
                    "FROM rabotniki",
                    conn
                );
                adapter1.Fill(table1);
                dataGridView1.DataSource = table1;
            }
            catch { }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Удаление", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes & dataGridView1.SelectedRows.Count > 0)
            {                
                string query1 = $"DELETE FROM grafik WHERE tabelniy_nomer = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}";
                MySqlCommand command1 = new MySqlCommand(query1, conn);

                conn.Open();
                command1.ExecuteNonQuery();

                string query2 = $"DELETE FROM rabotniki WHERE tabelniy_nomer = {dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}";
                MySqlCommand command2 = new MySqlCommand(query2, conn);
                command2.ExecuteNonQuery();

                conn.Close();
                RefreshTable();
            }
        }
    }
}