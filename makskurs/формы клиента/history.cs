using makskurs.Классы;
using makskurs.формы_админа;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace makskurs.формы_клиента
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
            Con = new Functions();
            ShowItems();
        }
        Functions Con;
        public static string idzakaza = "";
        private void ShowItems()
        {
            string Query = "select * from Заказ where idПользователя = '" + login.klient+"'";
            listItems.DataSource = Con.GetData(Query);
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntback_Click(object sender, EventArgs e)
        {
            Hide();
            userMain frm1 = new userMain();
            frm1.ShowDialog();
            this.Close();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string Query = "select * from Заказ where idПользователя = '" + login.klient + "' and ДатаЗапроса = '"+guna2DateTimePicker1.Value.ToString()+"'";
            listItems.DataSource = Con.GetData(Query);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void check_Click(object sender, EventArgs e)
        {
            string txtQrCode = "Интернет магазин 'Vakepui'" + "\nЧек покупки товара" + "\nПокупатель: " + login.фио + "\nНомер заказа: " + listItems.SelectedRows[0].Cells[0].Value.ToString() + "\nНазвание товара: " + listItems.SelectedRows[0].Cells[1].Value.ToString() +
                "\nКоличество: " + listItems.SelectedRows[0].Cells[5].Value.ToString() + "\nДата покупки: " + ((DateTime)listItems.SelectedRows[0].Cells[3].Value).ToString("dd.MM.yyyy") + "\nДата исполнения: " + ((DateTime)listItems.SelectedRows[0].Cells[4].Value).ToString("dd.MM.yyyy") +
                "\nСтоимость: " + listItems.SelectedRows[0].Cells[6].Value.ToString();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtQrCode, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQR.Image = code.GetGraphic(5);

            if (idzakaza == "")
            {
                MessageBox.Show("Не выбран заказ");
            }
            else
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("Custom", 415, 500);
                printDocument1.PrinterSettings.DefaultPageSettings.PaperSize = printDocument1.DefaultPageSettings.PaperSize;
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
        }

        private void listItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idzakaza = listItems.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Интернет магазин 'Vakepui'", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.MediumSeaGreen, new Point(70));
            e.Graphics.DrawString("Чек покупки товара", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("Покупатель: " + login.фио, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 50));
            e.Graphics.DrawString("Номер заказа: " + listItems.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 70));
            e.Graphics.DrawString("Название товара: " + listItems.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 90));
            e.Graphics.DrawString("Количество: " + listItems.SelectedRows[0].Cells[5].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 110));
            e.Graphics.DrawString("Дата покупки: " + ((DateTime)listItems.SelectedRows[0].Cells[3].Value).ToString("dd.MM.yyyy"), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 130));
            e.Graphics.DrawString("Дата исполнения: " + ((DateTime)listItems.SelectedRows[0].Cells[4].Value).ToString("dd.MM.yyyy"), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Стоимость: " + listItems.SelectedRows[0].Cells[6].Value.ToString(), new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(10, 170));
            int newWidth = picQR.Width / 2;
            int newHeight = picQR.Height / 2;
            e.Graphics.DrawImage(picQR.Image, new Rectangle(80, 207, 250, 250));
        }

        private void history_Load(object sender, EventArgs e)
        {

        }
    }
}
