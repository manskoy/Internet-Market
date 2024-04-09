namespace makskurs.формы_админа
{
    partial class Order
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
            this.kolvo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cust = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listOrders = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.polzId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateZapros = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateIspol = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOrders)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.kolvo.Location = new System.Drawing.Point(147, 225);
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(191, 33);
            this.kolvo.TabIndex = 178;
            this.kolvo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.kolvo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kolvo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(7, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 23);
            this.label3.TabIndex = 177;
            this.label3.Text = "Количество";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.name.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.name.ForeColor = System.Drawing.Color.Coral;
            this.name.ItemHeight = 30;
            this.name.Location = new System.Drawing.Point(119, 66);
            this.name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(230, 36);
            this.name.TabIndex = 176;
            this.name.SelectionChangeCommitted += new System.EventHandler(this.name_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(241, 1);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Интернет магазин \'Vakepui\'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Заказы";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(838, 3);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 26);
            this.lbExit.TabIndex = 10;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 23);
            this.label8.TabIndex = 172;
            this.label8.Text = "id Покупателя";
            // 
            // cust
            // 
            this.cust.BackColor = System.Drawing.Color.White;
            this.cust.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cust.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cust.ForeColor = System.Drawing.Color.Coral;
            this.cust.HintForeColor = System.Drawing.Color.Empty;
            this.cust.HintText = "";
            this.cust.isPassword = false;
            this.cust.LineFocusedColor = System.Drawing.Color.Tomato;
            this.cust.LineIdleColor = System.Drawing.Color.Coral;
            this.cust.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.cust.LineThickness = 3;
            this.cust.Location = new System.Drawing.Point(157, 263);
            this.cust.Name = "cust";
            this.cust.Size = new System.Drawing.Size(181, 33);
            this.cust.TabIndex = 174;
            this.cust.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(7, 276);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 23);
            this.label9.TabIndex = 173;
            this.label9.Text = "Цена товара";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Coral;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(119, 355);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 42);
            this.btnBack.TabIndex = 171;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(218, 309);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 42);
            this.btnDelete.TabIndex = 170;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Coral;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(119, 309);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 42);
            this.btnEdit.TabIndex = 169;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(7, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 23);
            this.label7.TabIndex = 166;
            this.label7.Text = "Дата запроса";
            // 
            // listOrders
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listOrders.ColumnHeadersHeight = 22;
            this.listOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.listOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOrders.Location = new System.Drawing.Point(357, 83);
            this.listOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listOrders.Name = "listOrders";
            this.listOrders.ReadOnly = true;
            this.listOrders.RowHeadersVisible = false;
            this.listOrders.RowHeadersWidth = 62;
            this.listOrders.RowTemplate.Height = 28;
            this.listOrders.Size = new System.Drawing.Size(501, 374);
            this.listOrders.TabIndex = 163;
            this.listOrders.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listOrders.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listOrders.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listOrders.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listOrders.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listOrders.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listOrders.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOrders.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Coral;
            this.listOrders.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listOrders.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOrders.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listOrders.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listOrders.ThemeStyle.HeaderStyle.Height = 22;
            this.listOrders.ThemeStyle.ReadOnly = true;
            this.listOrders.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listOrders.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listOrders.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOrders.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listOrders.ThemeStyle.RowsStyle.Height = 28;
            this.listOrders.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listOrders.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listOrders_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(519, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 23);
            this.label6.TabIndex = 162;
            this.label6.Text = "Список заказов";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 57);
            this.panel1.TabIndex = 161;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 164;
            this.label2.Text = "Название";
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
            this.id.Location = new System.Drawing.Point(147, 227);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(185, 31);
            this.id.TabIndex = 175;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // polzId
            // 
            this.polzId.BackColor = System.Drawing.Color.Transparent;
            this.polzId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.polzId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.polzId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.polzId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.polzId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.polzId.ForeColor = System.Drawing.Color.Coral;
            this.polzId.ItemHeight = 30;
            this.polzId.Location = new System.Drawing.Point(187, 112);
            this.polzId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.polzId.Name = "polzId";
            this.polzId.Size = new System.Drawing.Size(153, 36);
            this.polzId.TabIndex = 181;
            // 
            // dateZapros
            // 
            this.dateZapros.BackColor = System.Drawing.Color.White;
            this.dateZapros.Checked = true;
            this.dateZapros.FillColor = System.Drawing.Color.White;
            this.dateZapros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateZapros.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateZapros.Location = new System.Drawing.Point(187, 157);
            this.dateZapros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateZapros.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateZapros.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateZapros.Name = "dateZapros";
            this.dateZapros.Size = new System.Drawing.Size(133, 23);
            this.dateZapros.TabIndex = 182;
            this.dateZapros.Value = new System.DateTime(2023, 12, 1, 4, 1, 33, 482);
            // 
            // dateIspol
            // 
            this.dateIspol.BackColor = System.Drawing.Color.White;
            this.dateIspol.Checked = true;
            this.dateIspol.FillColor = System.Drawing.Color.White;
            this.dateIspol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateIspol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateIspol.Location = new System.Drawing.Point(205, 196);
            this.dateIspol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateIspol.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateIspol.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateIspol.Name = "dateIspol";
            this.dateIspol.Size = new System.Drawing.Size(133, 23);
            this.dateIspol.TabIndex = 184;
            this.dateIspol.Value = new System.DateTime(2023, 12, 1, 4, 1, 33, 482);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(7, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 183;
            this.label5.Text = "Дата реализации";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Coral;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Location = new System.Drawing.Point(19, 309);
            this.btnADD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(95, 42);
            this.btnADD.TabIndex = 185;
            this.btnADD.Text = "Добавить";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 464);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.dateIspol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateZapros);
            this.Controls.Add(this.polzId);
            this.Controls.Add(this.kolvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cust);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox kolvo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DataGridView listOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
        private Guna.UI2.WinForms.Guna2ComboBox polzId;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateZapros;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateIspol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnADD;
    }
}