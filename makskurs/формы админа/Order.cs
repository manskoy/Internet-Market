using makskurs.Классы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace makskurs.формы_админа
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
            GetItems();
            GetPokup();
            name.SelectedIndex = -1;
        }
        Functions Con;
        private void ShowItems()
        {
            string Query = "select * from Заказ";
            listOrders.DataSource = Con.GetData(Query);
        }
        private void GetItems()
        {
            string Query = "Select Название from Товар";
            name.ValueMember = Con.GetData(Query).Columns["Название"].ToString();
            name.DisplayMember = Con.GetData(Query).Columns["Название"].ToString();
            name.DataSource = Con.GetData(Query);
        }
        private void GetPokup()
        {
            string Query = "Select id from Пользователь";
            polzId.ValueMember = Con.GetData(Query).Columns["id"].ToString();
            polzId.DisplayMember = Con.GetData(Query).Columns["id"].ToString();
            polzId.DataSource = Con.GetData(Query);
        }

        private void kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void price()
        {
            if (kolvo.Text == "1")
            {
                cust.Text = cust.Text;
            }
            else
            {
                double kol = Int32.Parse(kolvo.Text);
                double Itogo = Math.Round(kol * Int32.Parse(cust.Text));
                cust.Text = Itogo.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || kolvo.Text == "" || kolvo.Text == "0")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    price();
                    string название = name.Text;
                    string покупатель = polzId.Text;
                    string ДатаЗапроса = dateZapros.Value.ToString();
                    string ДатаИсполнения = dateIspol.Value.ToString();
                    string колво = kolvo.Text;
                    string цена = cust.Text;
                    string Query = "update Заказ set НазваниеТовара = '{0}', idПользователя = '{1}', ДатаЗапроса = '{2}', ДатаВыполнения = '{3}', Количество = '{4}', Цена = '{5}' where idЗаказа = '" + id.Text + "'";

                    Query = string.Format(Query, название, покупатель, ДатаЗапроса, ДатаИсполнения, колво, цена);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Заказ изменён!");
                    name.Text = ""; cust.Text = "";kolvo.Text = "";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || kolvo.Text == "" || kolvo.Text == "0")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    price();
                    string название = name.Text;
                    string покупатель = polzId.Text;
                    string ДатаЗапроса = dateZapros.Value.ToString();
                    string ДатаИсполнения = dateIspol.Value.ToString();
                    string колво = kolvo.Text;
                    string цена = cust.Text;
                    string Query = "delete from Заказ where idЗаказа = '" + id.Text + "'";

                    Query = string.Format(Query, название, покупатель, ДатаЗапроса, ДатаИсполнения, колво, цена);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Заказ удалён!");
                    name.Text = ""; cust.Text = ""; kolvo.Text = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void listOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = listOrders.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = listOrders.SelectedRows[0].Cells[1].Value.ToString();
            polzId.Text = listOrders.SelectedRows[0].Cells[2].Value.ToString();
            dateZapros.Text = listOrders.SelectedRows[0].Cells[3].Value.ToString();
            dateIspol.Text = listOrders.SelectedRows[0].Cells[4].Value.ToString();
            kolvo.Text = listOrders.SelectedRows[0].Cells[5].Value.ToString();
            cust.Text = listOrders.SelectedRows[0].Cells[6].Value.ToString();
            double kol = Int32.Parse(kolvo.Text);
            double Itogo = Math.Round(Int32.Parse(cust.Text)/kol);
            cust.Text = Itogo.ToString();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || kolvo.Text == "" || kolvo.Text == "0")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    price();
                    string название = name.Text;
                    string покупатель = polzId.Text;
                    string ДатаЗапроса = dateZapros.Value.ToString();
                    string ДатаИсполнения = dateIspol.Value.ToString();
                    string колво = kolvo.Text;
                    string цена = cust.Text;
                    string Query = "insert into Заказ values('{0}','{1}','{2}','{3}','{4}','{5}')";

                    Query = string.Format(Query, название, покупатель, ДатаЗапроса, ДатаИсполнения, колво, цена);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Заказ добавлен!");
                    name.Text = ""; cust.Text = ""; kolvo.Text = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true");
            con.Open();
            if (name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select Цена from Товар where Название = @Название", con);
                cmd.Parameters.AddWithValue("@Название", name.SelectedValue.ToString());
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    cust.Text = da.GetValue(0).ToString();
                }
                con.Close();
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }
    }
}
