using makskurs.Классы;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makskurs
{
    public partial class reg : Form
    {
        Database database = new Database();
        public reg()
        {
            InitializeComponent();
            Con = new Functions();
        }
        Functions Con;

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private Boolean checkuser()
        {
            var login = tblogin.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select id, login, password from Пользователь where login = '{login}'";

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
        private void lbClear_Click(object sender, EventArgs e)
        {
            tbadres.Text = "";
            tbfio.Text = "";
            tblogin.Text = "";
            tbpass.Text = "";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (checkuser())

            {
                return;
            }
            if (tbadres.Text == "" || tbfio.Text == "" || tblogin.Text == "" || tbpass.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string фио = tbfio.Text;
                    string адрес = tbadres.Text;
                    string логин = tblogin.Text;
                    string пароль = tbpass.Text;
                    bool admin = false;
                    int баланс = 0;
                    string Query = "insert into Пользователь values('{0}','{1}','{2}','{3}','{4}', '{5}')";

                    Query = string.Format(Query, фио, адрес, логин, пароль, admin, баланс);
                    Con.SetData(Query);
                    MessageBox.Show("Вы успешно зарегестрировались!");
                    login frm_reg = new login();
                    this.Hide();
                    frm_reg.ShowDialog();
                    tbfio.Text = ""; tbadres.Text = ""; tblogin.Text = ""; tbpass.Text = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void reg_Load(object sender, EventArgs e)
        {

        }
    }
}
