namespace makskurs.формы_админа
{
    partial class main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPolz = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnItems = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnOrder = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnPostav = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbExit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 87);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(336, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Основное меню";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.White;
            this.lbExit.Location = new System.Drawing.Point(918, 6);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(39, 38);
            this.lbExit.TabIndex = 10;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(112, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(742, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Панель управления онлайн магазином";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 42);
            this.panel2.TabIndex = 32;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Coral;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(160, 39);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPolz
            // 
            this.btnPolz.BorderRadius = 15;
            this.btnPolz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPolz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPolz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPolz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPolz.FillColor = System.Drawing.Color.Coral;
            this.btnPolz.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnPolz.ForeColor = System.Drawing.Color.White;
            this.btnPolz.Location = new System.Drawing.Point(66, 154);
            this.btnPolz.Name = "btnPolz";
            this.btnPolz.Size = new System.Drawing.Size(262, 74);
            this.btnPolz.TabIndex = 33;
            this.btnPolz.TabStop = false;
            this.btnPolz.Text = "Пользователи";
            this.btnPolz.Click += new System.EventHandler(this.btnPolz_Click);
            // 
            // btnItems
            // 
            this.btnItems.BorderRadius = 15;
            this.btnItems.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItems.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItems.FillColor = System.Drawing.Color.Coral;
            this.btnItems.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(66, 345);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(262, 74);
            this.btnItems.TabIndex = 36;
            this.btnItems.TabStop = false;
            this.btnItems.Text = "Товары";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 15;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.Coral;
            this.btnOrder.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(585, 154);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(262, 74);
            this.btnOrder.TabIndex = 37;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "Заказы";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPostav
            // 
            this.btnPostav.BorderRadius = 15;
            this.btnPostav.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPostav.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPostav.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPostav.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPostav.FillColor = System.Drawing.Color.Coral;
            this.btnPostav.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnPostav.ForeColor = System.Drawing.Color.White;
            this.btnPostav.Location = new System.Drawing.Point(585, 345);
            this.btnPostav.Name = "btnPostav";
            this.btnPostav.Size = new System.Drawing.Size(262, 74);
            this.btnPostav.TabIndex = 38;
            this.btnPostav.TabStop = false;
            this.btnPostav.Text = "Поставщики";
            this.btnPostav.Click += new System.EventHandler(this.btnPostav_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 624);
            this.Controls.Add(this.btnPostav);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnPolz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogout;
        private Guna.UI2.WinForms.Guna2TileButton btnPolz;
        private Guna.UI2.WinForms.Guna2TileButton btnItems;
        private Guna.UI2.WinForms.Guna2TileButton btnOrder;
        private Guna.UI2.WinForms.Guna2TileButton btnPostav;
    }
}