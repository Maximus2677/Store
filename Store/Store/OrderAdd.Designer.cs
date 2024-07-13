namespace Store
{
    partial class OrderAdd
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
            this.l_Date = new System.Windows.Forms.Label();
            this.l_SurName = new System.Windows.Forms.Label();
            this.l_Name = new System.Windows.Forms.Label();
            this.l_LastName = new System.Windows.Forms.Label();
            this.l_ProdName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_Price = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.l_Telefon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_Date
            // 
            this.l_Date.AutoSize = true;
            this.l_Date.Location = new System.Drawing.Point(96, 81);
            this.l_Date.Name = "l_Date";
            this.l_Date.Size = new System.Drawing.Size(33, 13);
            this.l_Date.TabIndex = 0;
            this.l_Date.Text = "Дата";
            // 
            // l_SurName
            // 
            this.l_SurName.AutoSize = true;
            this.l_SurName.Location = new System.Drawing.Point(96, 181);
            this.l_SurName.Name = "l_SurName";
            this.l_SurName.Size = new System.Drawing.Size(56, 13);
            this.l_SurName.TabIndex = 1;
            this.l_SurName.Text = "Фамилия";
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Location = new System.Drawing.Point(96, 207);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(29, 13);
            this.l_Name.TabIndex = 2;
            this.l_Name.Text = "Имя";
            // 
            // l_LastName
            // 
            this.l_LastName.AutoSize = true;
            this.l_LastName.Location = new System.Drawing.Point(96, 233);
            this.l_LastName.Name = "l_LastName";
            this.l_LastName.Size = new System.Drawing.Size(54, 13);
            this.l_LastName.TabIndex = 3;
            this.l_LastName.Text = "Отчество";
            // 
            // l_ProdName
            // 
            this.l_ProdName.AutoSize = true;
            this.l_ProdName.Location = new System.Drawing.Point(96, 116);
            this.l_ProdName.Name = "l_ProdName";
            this.l_ProdName.Size = new System.Drawing.Size(95, 13);
            this.l_ProdName.TabIndex = 4;
            this.l_ProdName.Text = "Название товара";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Количество:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 282);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "1";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Location = new System.Drawing.Point(96, 311);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(33, 13);
            this.l_Price.TabIndex = 7;
            this.l_Price.Text = "Цена";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Заказать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(93, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 31);
            this.label8.TabIndex = 9;
            this.label8.Text = "Сделать заказ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(95, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Данные покупателя:";
            // 
            // l_Telefon
            // 
            this.l_Telefon.AutoSize = true;
            this.l_Telefon.Location = new System.Drawing.Point(96, 259);
            this.l_Telefon.Name = "l_Telefon";
            this.l_Telefon.Size = new System.Drawing.Size(52, 13);
            this.l_Telefon.TabIndex = 11;
            this.l_Telefon.Text = "Телефон";
            // 
            // OrderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 405);
            this.Controls.Add(this.l_Telefon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_Price);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_ProdName);
            this.Controls.Add(this.l_LastName);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_SurName);
            this.Controls.Add(this.l_Date);
            this.Name = "OrderAdd";
            this.Text = "Создание заказа";
            this.Load += new System.EventHandler(this.OrderAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Date;
        private System.Windows.Forms.Label l_SurName;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Label l_LastName;
        private System.Windows.Forms.Label l_ProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_Price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label l_Telefon;
    }
}