using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursa4_new
{
    public partial class FormMain : Form
    {
        public static string connStr = "server = localhost; user = root; database = kurs; port = 3306; password = 1234";
        public MySqlConnection conn = new MySqlConnection(connStr);

        public MySqlDataAdapter adapter;
        public MySqlDataAdapter adapter1;

        public DataTable table = new DataTable();
        public DataTable table1 = new DataTable();

        public static string fio;

        private Point mouseOffset;
        private bool isMouseDown = false;

        public FormMain()
        {
            InitializeComponent();

            uiSell1.BringToFront();
            pAuth.BringToFront();

            cbWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        }

        public void InitDB()
        {
            string query = "USE kurs";
            MySqlCommand comm = new MySqlCommand(query, conn);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Ошибка выбора базы данных!");
            }
        }
        
        private void RefreshUsers()
        {
            table1.Clear();
            adapter1 = new MySqlDataAdapter($"SELECT tabelniy_nomer, familia_rabotnika, imya_rabotnika, otchestvo_rabotnika FROM kurs.rabotniki", conn);
            adapter1.Fill(table1);
        }

        public void ButtonClick(Button btn)
        {
            btnSell.BackColor = Color.Firebrick;
            btnLek.BackColor = Color.Firebrick;
            btnGraph.BackColor = Color.Firebrick;
            btnReg.BackColor = Color.Firebrick;
            btn.BackColor = Color.IndianRed;

            pSelect.Height = btn.Height;
            pSelect.Top = btn.Top;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            uiSell1.BringToFront();
            ButtonClick(btnSell);
        }
        
        private void btnLek_Click(object sender, EventArgs e)
        {
            uiLek1.BringToFront();
            ButtonClick(btnLek);
            uiLek1.RefreshTable(0);
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            uiGraph1.BringToFront();
            ButtonClick(btnGraph);
            uiGraph1.RefreshTable();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            uiReg2.BringToFront();
            ButtonClick(btnReg);
            uiReg2.RefreshTable();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            /*
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            }
            else if (dialogResult == DialogResult.No)
            {

            }
            */
            cbWork.Text = "";
            tbLogin.Text = "";
            mtbPass.Text = "";
            fio = "";

            pAuth.BringToFront();

            btnLek.Visible = true;
            btnGraph.Visible = true;
            btnReg.Visible = true;

            pAuth.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Исключения пароля
            if (tbLogin.Text == "" || mtbPass.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            if (cbWork.Text == "")
            {
                MessageBox.Show("Выберите должность");
                return;
            }
            if (tbLogin.Text.Contains("\\") || mtbPass.Text.Contains("\\") || tbLogin.Text.Contains("'") || mtbPass.Text.Contains("'"))
            {
                MessageBox.Show("Введеные неверные символы");
                return;
            }

            adapter = new MySqlDataAdapter(
                "SELECT tabelniy_nomer, pswd, doljnost, familia_rabotnika, imya_rabotnika, otchestvo_rabotnika " +
                "FROM kurs.rabotniki " +
                $"WHERE tabelniy_nomer = '{tbLogin.Text}' AND pswd = '{mtbPass.Text}' AND doljnost = '{cbWork.Text}'", 
                conn
            );
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][2].ToString() == "Фармацевт")
                {
                    btnLek.Visible = false;
                    btnGraph.Visible = false;
                    btnReg.Visible = false;
                }
                fio = table.Rows[0][3].ToString() + " " + table.Rows[0][4].ToString() + " " + table.Rows[0][5].ToString();
                pAuth.Hide();
            }
            else MessageBox.Show("Неправильный логин, пароль или должность");
            table.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pAuth.BringToFront();
            try
            {
                conn.Open();
                InitDB();
                conn.Close();

                RefreshUsers();
            }
            catch
            {
                MessageBox.Show("Невозможно подключиться к базе данных!");
            }
            
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            // Changes the isMouseDown field so that the form does
            // not move unless the user is pressing the left mouse button.
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}