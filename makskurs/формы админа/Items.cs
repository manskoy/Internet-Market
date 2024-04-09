using makskurs.Классы;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace makskurs.формы_админа
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
            GetPostav();
        }
        Functions Con;
        private void ShowItems()
        {
            string Query = "select * from Товар";
            listItems.DataSource = Con.GetData(Query);
        }
        private void GetPostav()
        {
            string Query = "Select Название from Поставщик";
            postav.ValueMember = Con.GetData(Query).Columns["Название"].ToString();
            postav.DisplayMember = Con.GetData(Query).Columns["Название"].ToString();
            postav.DataSource = Con.GetData(Query);
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || postav.Text == "" || cust.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string Поставщик = postav.Text;
                    string Тип = tip.Text;
                    string Цена = cust.Text;
                    string ЕдиницаИзмерения = counttype.Text;
                    Image Фото = null;
                    string Query = "insert into Товар values('{0}','{1}','{2}','{3}','{4}','{5}')";

                    Query = string.Format(Query, название, Поставщик, Тип, Цена, ЕдиницаИзмерения, Фото);
                    Con.SetData(Query);
                    Update(ConvertImageToBytes(pictureBox1.Image));
                    ShowItems();
                    MessageBox.Show("Товар добавлен!");
                    name.Text = ""; cust.Text = ""; tip.Text = ""; kolvo.Text = ""; counttype.Text = ""; pictureBox1.Image = null;
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || postav.Text == "" || cust.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string Поставщик = postav.Text;
                    string Тип = tip.Text;
                    string Цена = cust.Text;
                    string ЕдиницаИзмерения = counttype.Text;
                    string Query = "update Товар set Название = '{0}', Поставщик = '{1}', Тип = '{2}', Цена = '{3}', ЕдиницаИзмерения = '{4}' where Название = '" + id.Text + "'";

                    Query = string.Format(Query, название, Поставщик, Тип, Цена, ЕдиницаИзмерения);
                    Update(ConvertImageToBytes(pictureBox1.Image));
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Товар изменён!");
                    name.Text = ""; cust.Text = ""; tip.Text = ""; kolvo.Text = ""; counttype.Text = ""; pictureBox1.Image = null;
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || postav.Text == "" || cust.Text == "" || pictureBox1.Image == null)
            {
                MessageBox.Show("Введены не все данные!!!");
            }
            else
            {
                try
                {
                    string название = name.Text;
                    string Поставщик = postav.Text;
                    string Тип = tip.Text;
                    string Цена = cust.Text;
                    string ЕдиницаИзмерения = counttype.Text;
                    string Query = "delete from Товар where Название = '" + id.Text + "'";

                    Query = string.Format(Query, название, Поставщик, Тип, Цена, ЕдиницаИзмерения);
                    Con.SetData(Query);
                    ShowItems();
                    MessageBox.Show("Товар удалён!");
                    name.Text = ""; cust.Text = ""; tip.Text = ""; kolvo.Text = ""; counttype.Text = ""; pictureBox1.Image = null;
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
            id.Text = listItems.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = listItems.SelectedRows[0].Cells[0].Value.ToString();
            postav.Text = listItems.SelectedRows[0].Cells[1].Value.ToString();
            tip.Text = listItems.SelectedRows[0].Cells[2].Value.ToString();
            cust.Text = listItems.SelectedRows[0].Cells[3].Value.ToString();
            counttype.Text = listItems.SelectedRows[0].Cells[4].Value.ToString();
            DataTable dt = listItems.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ConvertByteArrayToImage((byte[])row[5]);
            }
        }

        private void cust_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        public void Insert(byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true"))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (SqlCommand cmd = new SqlCommand("insert into Товар(Фото) values (@Фото)", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Фото", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void Update(byte[] image)
        {
            using (SqlConnection cn = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true"))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (SqlCommand cmd = new SqlCommand("update Товар set Фото = @Фото where Название = '" + name.Text + "'", cn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@Фото", image);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void LoadData()
        {
            using (SqlConnection cn = new SqlConnection(@"server=vakepui\SQLEXPRESS;database=maksim;Integrated Security=true"))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using (DataTable dt = new DataTable("Pictures"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select * from Товар", cn);
                    adapter.Fill(dt);
                    listItems.DataSource = dt;
                }
            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    LoadData();
                }
            }
        }

        private void listItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
