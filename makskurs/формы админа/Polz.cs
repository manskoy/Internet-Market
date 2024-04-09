using makskurs.Классы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace makskurs.формы_админа
{
    public partial class Polz : Form
    {
        Database database = new Database();
        public Polz()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPolz();
        }
        Functions Con;
        private void ShowPolz()
        {
            string Query = "select * from Пользователь";
            listPolz.DataSource = Con.GetData(Query);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (checkuser())

            {
                return;
            }
            if (FIO.Text == "" || adres.Text == "" || password.Text == "" || login.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string фио = FIO.Text;
                    string адрес = adres.Text;
                    string Логин = login.Text;
                    string Пароль = password.Text;
                    bool Админ = admin.Checked;
                    string баланс = balance.Text;
                    string Query = "insert into Пользователь values('{0}','{1}','{2}','{3}','{4}','{5}')";

                    Query = string.Format(Query, фио, адрес, Логин, Пароль, Админ, баланс);
                    Con.SetData(Query);
                    ShowPolz();
                    MessageBox.Show("Пользователь добавлен!");
                    FIO.Text = ""; adres.Text = ""; password.Text = ""; login.Text = ""; balance.Text = ""; admin.Checked = false;
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (FIO.Text == "" || adres.Text == "" || password.Text == "" || login.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string код = id.Text;
                    string фио = FIO.Text;
                    string адрес = adres.Text;
                    string Логин = login.Text;
                    string Пароль = password.Text;
                    bool Админ = admin.Checked;
                    string баланс = balance.Text;
                    string Query = "update Пользователь set ФИО = '{1}', Адрес = '{2}', login = '{3}', password = '{4}', admin = '{5}', Баланс = '{6}' where id = '{0}'";

                    Query = string.Format(Query, код, фио, адрес, Логин, Пароль, Админ, баланс);
                    Con.SetData(Query);
                    ShowPolz();
                    MessageBox.Show("Пользователь обнавлён!");
                    FIO.Text = ""; adres.Text = ""; password.Text = ""; login.Text = ""; balance.Text = ""; admin.Checked = false;

                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FIO.Text == "" || adres.Text == "" || password.Text == "" || login.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string код = id.Text;
                    string фио = FIO.Text;
                    string адрес = adres.Text;
                    string Логин = login.Text;
                    string Пароль = password.Text;
                    bool Админ = admin.Checked;
                    string баланс = balance.Text;
                    string Query = "delete from Пользователь where id = {0}";

                    Query = string.Format(Query, код, фио, адрес, Логин, Пароль, Админ, баланс);
                    Con.SetData(Query);
                    ShowPolz();
                    MessageBox.Show("Пользователь удалён!");
                    FIO.Text = ""; adres.Text = ""; password.Text = ""; login.Text = ""; balance.Text = ""; admin.Checked = false;
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            main frm1 = new main();
            frm1.ShowDialog();
            this.Close();
        }

        private void listPolz_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = listPolz.SelectedRows[0].Cells[0].Value.ToString();
            FIO.Text = listPolz.SelectedRows[0].Cells[1].Value.ToString();
            adres.Text = listPolz.SelectedRows[0].Cells[2].Value.ToString();
            login.Text = listPolz.SelectedRows[0].Cells[3].Value.ToString();
            password.Text = listPolz.SelectedRows[0].Cells[4].Value.ToString();
            balance.Text = listPolz.SelectedRows[0].Cells[6].Value.ToString();
        }
        private Boolean checkuser()
        {
            var log = login.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, login, password from Пользователь where login = '{log}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Polz_Load(object sender, EventArgs e)
        {

        }
    }
}
