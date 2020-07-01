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
    public partial class UILek : UserControl
    {
        public static string connStr = "server = localhost; user = root; database = kurs; port = 3306; password = 1234";
        public MySqlConnection conn = new MySqlConnection(connStr);

        public System.Data.DataTable table1 = new System.Data.DataTable();
        public System.Data.DataTable table2 = new System.Data.DataTable();

        public UILek()
        {
            InitializeComponent();
            dataGridView1.ForeColor = Color.Black;
        }

        private void UILek_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter adapter1 = new MySqlDataAdapter(
                "SELECT kod_gruppi as Код_группы, naimenovanie_gruppi as Наименование " +
                "FROM kategorii_lekarstv",
                conn
            );
                adapter1.Fill(table1);
                for (int i = 0; i < table1.Rows.Count; i++)
                {
                    cbCat.Items.Add(table1.Rows[i][1]);
                }
            }
            catch { }
        }

        public void RefreshTable(int ind)
        {
            try
            {
                if (ind == 0)
                {
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(
                        "SELECT lekarstva.artikul_lekarstva as Артикул, kategorii_lekarstv.naimenovanie_gruppi as Группа, lekarstva.naimenovanie_lekarstva as Наименование, lekarstva.kolvo as 'Кол-во', lekarstva.price as Цена " +
                        "FROM lekarstva " +
                        "INNER JOIN kategorii_lekarstv ON lekarstva.kod_gruppi = kategorii_lekarstv.kod_gruppi",
                        conn
                    );
                    table2.Clear();
                    adapter2.Fill(table2);
                    dataGridView1.DataSource = table2;
                }
                else
                {
                    string kod = table1.Rows[ind - 1][0].ToString();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(
                        "SELECT lekarstva.artikul_lekarstva as Артикул, kategorii_lekarstv.naimenovanie_gruppi as Группа, lekarstva.naimenovanie_lekarstva as Наименование, lekarstva.kolvo as 'Кол-во', lekarstva.price as Цена " +
                        "FROM lekarstva " +
                        "INNER JOIN kategorii_lekarstv ON lekarstva.kod_gruppi = kategorii_lekarstv.kod_gruppi " +
                        $"WHERE lekarstva.kod_gruppi = {kod}",
                        conn
                    );
                    table2.Clear();
                    adapter2.Fill(table2);
                    dataGridView1.DataSource = table2;
                }
            }
            catch { }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable(cbCat.SelectedIndex);
        }
    }
}