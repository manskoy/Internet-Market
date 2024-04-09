using makskurs.Классы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makskurs.формы_админа
{
    public partial class Postav : Form
    {
        public Postav()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPostav();
        }
        Functions Con;
        private void ShowPostav()
        {
            string Query = "select * from Поставщик";
            listPostav.DataSource = Con.GetData(Query);
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || adres.Text == "" || delegat.Text == "" || nomer.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string делегат = delegat.Text;
                    string номер = nomer.Text;
                    string адрес = adres.Text;
                    string Query = "insert into Поставщик values('{0}','{1}','{2}','{3}')";

                    Query = string.Format(Query, название, делегат, номер, адрес);
                    Con.SetData(Query);
                    ShowPostav();
                    MessageBox.Show("Поставщик добавлен!");
                    name.Text = ""; adres.Text = ""; delegat.Text = ""; nomer.Text = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || adres.Text == "" || delegat.Text == "" || nomer.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string делегат = delegat.Text;
                    string номер = nomer.Text;
                    string адрес = adres.Text;
                    string Query = "update Поставщик set Название = '{0}', Представитель = '{1}', Телефон = '{2}', Адрес = '{3}' where Название = '"+id.Text+"'";

                    Query = string.Format(Query, название, делегат, номер, адрес);

                    Con.SetData(Query);
                    ShowPostav();
                    MessageBox.Show("Поставщик обнавлён!");
                    name.Text = ""; adres.Text = ""; delegat.Text = ""; nomer.Text = "";
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || adres.Text == "" || delegat.Text == "" || nomer.Text == "")
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string делегат = delegat.Text;
                    string номер = nomer.Text;
                    string адрес = adres.Text;
                    string Query = "delete from Поставщик where Название = '"+id.Text+"'";

                    Query = string.Format(Query, название, делегат, номер, адрес);
                    Con.SetData(Query);
                    ShowPostav();
                    MessageBox.Show("Поставщик удалён!");
                    name.Text = ""; adres.Text = ""; delegat.Text = ""; nomer.Text = "";
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

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listPostav_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = listPostav.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = listPostav.SelectedRows[0].Cells[0].Value.ToString();
            delegat.Text = listPostav.SelectedRows[0].Cells[1].Value.ToString();
            nomer.Text = listPostav.SelectedRows[0].Cells[2].Value.ToString();
            adres.Text = listPostav.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void nomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Postav_Load(object sender, EventArgs e)
        {

        }
    }
}
