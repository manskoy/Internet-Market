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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnPolz_Click(object sender, EventArgs e)
        {
            Hide();
            Polz frm1 = new Polz();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Hide();
            Order frm1 = new Order();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            Hide();
            Items frm1 = new Items();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnPostav_Click(object sender, EventArgs e)
        {
            Hide();
            Postav frm1 = new Postav();
            frm1.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
