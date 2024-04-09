using makskurs.Классы;
using makskurs.формы_админа;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makskurs.формы_клиента
{
    public partial class userMain : Form
    {
        Database database = new Database();
        public userMain()
        {
            InitializeComponent();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Hide();
            userOrder frm1 = new userOrder();
            frm1.ShowDialog();
            this.Close();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPostav_Click(object sender, EventArgs e)
        {
            Hide();
            history frm1 = new history();
            frm1.ShowDialog();
            this.Close();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.tinkoff.ru/cf/5emznSducNd");
        }

        private void userMain_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Баланс from Пользователь where id = '" + login.klient + "'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            money.Text = table.Rows[0][0].ToString();
        }
    }
}
