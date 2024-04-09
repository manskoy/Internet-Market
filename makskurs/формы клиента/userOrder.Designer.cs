namespace makskurs.формы_клиента
{
    partial class userOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnADD = new System.Windows.Forms.Button();
            this.kolvo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cust = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.money = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Coral;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(83, 609);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(143, 64);
            this.btnADD.TabIndex = 205;
            this.btnADD.Text = "Купить";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // kolvo
            // 
            this.kolvo.BackColor = System.Drawing.Color.White;
            this.kolvo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.kolvo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.kolvo.ForeColor = System.Drawing.Color.Coral;
            this.kolvo.HintForeColor = System.Drawing.Color.Empty;
            this.kolvo.HintText = "";
            this.kolvo.isPassword = false;
            this.kolvo.LineFocusedColor = System.Drawing.Color.Tomato;
            this.kolvo.LineIdleColor = System.Drawing.Color.Coral;
            this.kolvo.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.kolvo.LineThickness = 3;
            this.kolvo.Location = new System.Drawing.Point(221, 177);
            this.kolvo.Margin = new System.Windows.Forms.Padding(4);
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(286, 51);
            this.kolvo.TabIndex = 200;
            this.kolvo.Text = "1";
            this.kolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolvo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(10, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 34);
            this.label3.TabIndex = 199;
            this.label3.Text = "Количество";
            // 
            // cust
            // 
            this.cust.BackColor = System.Drawing.Color.White;
            this.cust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cust.Enabled = false;
            this.cust.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cust.ForeColor = System.Drawing.Color.Coral;
            this.cust.HintForeColor = System.Drawing.Color.Empty;
            this.cust.HintText = "";
            this.cust.isPassword = false;
            this.cust.LineFocusedColor = System.Drawing.Color.Tomato;
            this.cust.LineIdleColor = System.Drawing.Color.Coral;
            this.cust.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.cust.LineThickness = 3;
            this.cust.Location = new System.Drawing.Point(235, 247);
            this.cust.Margin = new System.Windows.Forms.Padding(4);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(272, 51);
            this.cust.TabIndex = 196;
            this.cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(10, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 34);
            this.label9.TabIndex = 195;
            this.label9.Text = "Цена товара";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Coral;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(275, 609);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(143, 64);
            this.btnBack.TabIndex = 193;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(475, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(526, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Интернет магазин \'Vakepui\'";
            // 
            // listItems
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listItems.ColumnHeadersHeight = 22;
            this.listItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.listItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listItems.Location = new System.Drawing.Point(536, 133);
            this.listItems.Name = "listItems";
            this.listItems.ReadOnly = true;
            this.listItems.RowHeadersVisible = false;
            this.listItems.RowHeadersWidth = 62;
            this.listItems.RowTemplate.Height = 28;
            this.listItems.Size = new System.Drawing.Size(752, 575);
            this.listItems.TabIndex = 188;
            this.listItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Coral;
            this.listItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listItems.ThemeStyle.HeaderStyle.Height = 22;
            this.listItems.ThemeStyle.ReadOnly = true;
            this.listItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listItems.ThemeStyle.RowsStyle.Height = 28;
            this.listItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listItems_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.money);
            this.panel1.Controls.Add(this.lbBalance);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 87);
            this.panel1.TabIndex = 186;
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.money.ForeColor = System.Drawing.Color.White;
            this.money.Location = new System.Drawing.Point(12, 42);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(131, 34);
            this.money.TabIndex = 209;
            this.money.Text = "Деньги";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBalance.ForeColor = System.Drawing.Color.White;
            this.lbBalance.Location = new System.Drawing.Point(24, 4);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(152, 34);
            this.lbBalance.TabIndex = 208;
            this.lbBalance.Text = "Баланс: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(632, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Покупка товара";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(1257, 5);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(39, 38);
            this.lbExit.TabIndex = 10;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(116, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 34);
            this.label2.TabIndex = 189;
            this.label2.Text = "Название товара:";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.White;
            this.id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.id.ForeColor = System.Drawing.Color.Coral;
            this.id.HintForeColor = System.Drawing.Color.Empty;
            this.id.HintText = "";
            this.id.isPassword = false;
            this.id.LineFocusedColor = System.Drawing.Color.Tomato;
            this.id.LineIdleColor = System.Drawing.Color.Coral;
            this.id.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.id.LineThickness = 3;
            this.id.Location = new System.Drawing.Point(221, 180);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(277, 47);
            this.id.TabIndex = 197;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(779, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(270, 34);
            this.label6.TabIndex = 187;
            this.label6.Text = "Список товаров";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Enabled = false;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.Coral;
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.Tomato;
            this.name.LineIdleColor = System.Drawing.Color.Coral;
            this.name.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(45, 122);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(462, 51);
            this.name.TabIndex = 206;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.OnValueChanged += new System.EventHandler(this.name_OnValueChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.date.ForeColor = System.Drawing.Color.Coral;
            this.date.Location = new System.Drawing.Point(957, 42);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(92, 34);
            this.date.TabIndex = 207;
            this.date.Text = "Дата";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 207;
            this.pictureBox1.TabStop = false;
            // 
            // userOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userOrder";
            this.Load += new System.EventHandler(this.userOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private Bunifu.Framework.UI.BunifuMaterialTextbox kolvo;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView listItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox name;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}