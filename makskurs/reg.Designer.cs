namespace makskurs
{
    partial class reg
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReg = new Guna.UI2.WinForms.Guna2TileButton();
            this.tbpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tblogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbExit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbClear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbadres = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbfio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.id = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 346);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "\'Vakepui\'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Интернет магазин";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::makskurs.Properties.Resources.png_clipart_brown_blue_and_black_store_illustration_storefront_online_shopping_supermarket_miscellaneous_retail__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 95);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.BorderRadius = 15;
            this.btnReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReg.FillColor = System.Drawing.Color.Coral;
            this.btnReg.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.btnReg.ForeColor = System.Drawing.Color.White;
            this.btnReg.Location = new System.Drawing.Point(320, 257);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(198, 48);
            this.btnReg.TabIndex = 28;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tbpass
            // 
            this.tbpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbpass.ForeColor = System.Drawing.Color.Coral;
            this.tbpass.HintForeColor = System.Drawing.Color.Empty;
            this.tbpass.HintText = "";
            this.tbpass.isPassword = false;
            this.tbpass.LineFocusedColor = System.Drawing.Color.Tomato;
            this.tbpass.LineIdleColor = System.Drawing.Color.Coral;
            this.tbpass.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.tbpass.LineThickness = 3;
            this.tbpass.Location = new System.Drawing.Point(320, 200);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(218, 30);
            this.tbpass.TabIndex = 26;
            this.tbpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tblogin
            // 
            this.tblogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tblogin.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tblogin.ForeColor = System.Drawing.Color.Coral;
            this.tblogin.HintForeColor = System.Drawing.Color.Empty;
            this.tblogin.HintText = "";
            this.tblogin.isPassword = false;
            this.tblogin.LineFocusedColor = System.Drawing.Color.Tomato;
            this.tblogin.LineIdleColor = System.Drawing.Color.Coral;
            this.tblogin.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.tblogin.LineThickness = 3;
            this.tblogin.Location = new System.Drawing.Point(320, 146);
            this.tblogin.Name = "tblogin";
            this.tblogin.Size = new System.Drawing.Size(218, 28);
            this.tblogin.TabIndex = 25;
            this.tblogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.Transparent;
            this.lbExit.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbExit.ForeColor = System.Drawing.Color.Coral;
            this.lbExit.Location = new System.Drawing.Point(555, 3);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(27, 26);
            this.lbExit.TabIndex = 24;
            this.lbExit.Text = "X";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(226, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(226, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Логин";
            // 
            // lbClear
            // 
            this.lbClear.AutoSize = true;
            this.lbClear.BackColor = System.Drawing.Color.Transparent;
            this.lbClear.Font = new System.Drawing.Font("Verdana", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbClear.ForeColor = System.Drawing.Color.Coral;
            this.lbClear.Location = new System.Drawing.Point(381, 315);
            this.lbClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbClear.Name = "lbClear";
            this.lbClear.Size = new System.Drawing.Size(78, 18);
            this.lbClear.TabIndex = 21;
            this.lbClear.Text = "Очистить";
            this.lbClear.Click += new System.EventHandler(this.lbClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(315, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Регистрация";
            // 
            // tbadres
            // 
            this.tbadres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbadres.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbadres.ForeColor = System.Drawing.Color.Coral;
            this.tbadres.HintForeColor = System.Drawing.Color.Empty;
            this.tbadres.HintText = "";
            this.tbadres.isPassword = false;
            this.tbadres.LineFocusedColor = System.Drawing.Color.Tomato;
            this.tbadres.LineIdleColor = System.Drawing.Color.Coral;
            this.tbadres.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.tbadres.LineThickness = 3;
            this.tbadres.Location = new System.Drawing.Point(320, 90);
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(218, 31);
            this.tbadres.TabIndex = 32;
            this.tbadres.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbfio
            // 
            this.tbfio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbfio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbfio.ForeColor = System.Drawing.Color.Coral;
            this.tbfio.HintForeColor = System.Drawing.Color.Empty;
            this.tbfio.HintText = "";
            this.tbfio.isPassword = false;
            this.tbfio.LineFocusedColor = System.Drawing.Color.Tomato;
            this.tbfio.LineIdleColor = System.Drawing.Color.Coral;
            this.tbfio.LineMouseHoverColor = System.Drawing.Color.Tomato;
            this.tbfio.LineThickness = 3;
            this.tbfio.Location = new System.Drawing.Point(320, 42);
            this.tbfio.Name = "tbfio";
            this.tbfio.Size = new System.Drawing.Size(218, 30);
            this.tbfio.TabIndex = 31;
            this.tbfio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Coral;
            this.label6.Location = new System.Drawing.Point(226, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 30;
            this.label6.Text = "Адрес";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Coral;
            this.label7.Location = new System.Drawing.Point(226, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "ФИО";
            // 
            // id
            // 
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
            this.id.Location = new System.Drawing.Point(320, 46);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(218, 25);
            this.id.TabIndex = 33;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.id.Visible = false;
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 346);
            this.Controls.Add(this.tbadres);
            this.Controls.Add(this.tbfio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tblogin);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "reg";
            this.Load += new System.EventHandler(this.reg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton btnReg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbpass;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tblogin;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbClear;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbadres;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbfio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox id;
    }
}