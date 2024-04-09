using makskurs.Классы;
using makskurs.формы_админа;
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
using System.Xml.Linq;
using System.Media;
using TheArtOfDevHtmlRenderer.Adapters;
using System.IO;

namespace makskurs.формы_клиента
{
    public partial class userOrder : Form
    {
        Database database = new Database();
        public userOrder()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
            timer.Tick += new EventHandler(RefreshLabel);
            timer.Interval = 1000;
            timer.Start();
        }
        Timer timer = new Timer();
        Functions Con;

        public void RefreshLabel(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("dd.MM.yyyy"); ;
        }
        private void ShowItems()
        {
            string Query = "select * from Товар";
            listItems.DataSource = Con.GetData(Query);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            price();
            if (name.Text == "" || kolvo.Text == "" || kolvo.Text == "0" || cust.Text == "" || money.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                if (Int32.Parse(money.Text) < Int32.Parse(cust.Text))
                {
                    MessageBox.Show("Недостаточно средств!");
                    cust.Text = listItems.SelectedRows[0].Cells[3].Value.ToString();
                }
                else
                {
                    try
                    {
                        string название = name.Text;
                        string покупатель = login.klient;
                        string ДатаЗапроса = date.Text;
                        string ДатаИсполнения = date.Text;
                        string колво = kolvo.Text;
                        string цена = cust.Text;
                        string Query = "insert into Заказ values('{0}','{1}','{2}','{3}','{4}','{5}')";

                        Query = string.Format(Query, название, покупатель, ДатаЗапроса, ДатаИсполнения, колво, цена);
                        Con.SetData(Query);
                        balik();
                        UpdateBalance();
                        ShowItems();
                        SoundPlayer dengi = new SoundPlayer(@"C:\Users\User\Desktop\ПЕРЕДЕЛАЙ — копия\makskurs\packages\dengi.wav");
                        dengi.Play();
                        MessageBox.Show("Товар куплен!");
                        name.Text = ""; cust.Text = ""; kolvo.Text = "1"; pictureBox1.Image = null;
                    }
                    catch (Exception Myex)
                    {
                        MessageBox.Show(Myex.Message);
                    }
                }

            }
        }
        public void price()
        {
            if (name.Text == "" || kolvo.Text == "" || kolvo.Text == "0" || cust.Text == "" || money.Text == "")
            {
            }
            else
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
        }
        public void balik()
        {
            double itog = Int32.Parse(money.Text) - Int32.Parse(cust.Text);
            money.Text = itog.ToString();
        }
        private void UpdateBalance()
        {
            SqlConnection con = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Пользователь set Баланс = '" + money.Text + "' where id = '" + login.klient + "';", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void kolvo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void userOrder_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select Баланс from Пользователь where id = '"+login.klient+"'";
            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            money.Text = table.Rows[0][0].ToString();
        }

        private void listItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name.Text = listItems.SelectedRows[0].Cells[0].Value.ToString();
            DataTable dt = listItems.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ConvertByteArrayToImage((byte[])row[5]);
            }
        }

        private void name_OnValueChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true");
            con.Open();
            if (name.Text != "")
            {
                SqlCommand cmd = new SqlCommand("select Цена from Товар where Название = @Название", con);
                cmd.Parameters.AddWithValue("@Название", name.Text);
                SqlDataReader da = cmd.ExecuteReader();
               while (da.Read())
                {
                    cust.Text = da.GetValue(0).ToString();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            userMain frm1 = new userMain();
            frm1.ShowDialog();
            this.Close();
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
