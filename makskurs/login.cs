using makskurs.Классы;
using makskurs.формы_админа;
using makskurs.формы_клиента;
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

namespace makskurs
{
    public partial class login : Form
    {
        Database database = new Database();
        public login()
        {
            InitializeComponent();
        }
        public static string klient = "";
        public static string адрес = "";
        public static string фио = "";
        public static string баланс = "";

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var login = tblog.Text;
            var pass = tbpass.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id,Фио,Адрес, Баланс, login, password from Пользователь where login = '{login}' and password = '{pass}'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                klient = table.Rows[0][0].ToString();
                адрес = table.Rows[0][2].ToString();
                фио = table.Rows[0][1].ToString();
                баланс = table.Rows[0][3].ToString();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                DataTable table1 = new DataTable();

                string querystring1 = $"select admin, login, password from Пользователь where login = '{login}' and password = '{pass}' and admin = '{true}'";
                SqlCommand command1 = new SqlCommand(querystring1, database.getConnection());

                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);

                if (table1.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли как админ!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    main frm1 = new main();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                    tblog.Text = "";
                    tbpass.Text = "";
                }
                else
                {
                    MessageBox.Show("Вы успешно вошли как покупатель!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userMain frm1 = new userMain();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Show();
                    tblog.Text = "";
                    tbpass.Text = "";
                }
            }
            else

            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            reg frm_reg = new reg();
            frm_reg.ShowDialog();
            this.Hide();
        }

        private void lbClear_Click(object sender, EventArgs e)
        {
            tblog.Text = "";
            tbpass.Text = "";
        }

        private void tbpass_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tbpass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
