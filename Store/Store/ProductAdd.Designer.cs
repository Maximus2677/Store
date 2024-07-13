namespace Store
{
    partial class ProductAdd
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
            this.pb_Set = new System.Windows.Forms.PictureBox();
            this.btn_Select = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Op = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Art = new System.Windows.Forms.TextBox();
            this.tb_Kol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Set)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Set
            // 
            this.pb_Set.Location = new System.Drawing.Point(36, 110);
            this.pb_Set.Name = "pb_Set";
            this.pb_Set.Size = new System.Drawing.Size(189, 171);
            this.pb_Set.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Set.TabIndex = 0;
            this.pb_Set.TabStop = false;
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(70, 287);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(119, 23);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Выбрать картинку";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(279, 337);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Добавить";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(310, 116);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(348, 20);
            this.tb_Name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добавить товар";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Артикул";
            // 
            // tb_Op
            // 
            this.tb_Op.Location = new System.Drawing.Point(310, 142);
            this.tb_Op.MaxLength = 500;
            this.tb_Op.Multiline = true;
            this.tb_Op.Name = "tb_Op";
            this.tb_Op.Size = new System.Drawing.Size(348, 92);
            this.tb_Op.TabIndex = 10;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(310, 240);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(348, 20);
            this.tb_Price.TabIndex = 11;
            // 
            // tb_Art
            // 
            this.tb_Art.Location = new System.Drawing.Point(310, 266);
            this.tb_Art.Name = "tb_Art";
            this.tb_Art.Size = new System.Drawing.Size(348, 20);
            this.tb_Art.TabIndex = 12;
            // 
            // tb_Kol
            // 
            this.tb_Kol.Location = new System.Drawing.Point(310, 292);
            this.tb_Kol.Name = "tb_Kol";
            this.tb_Kol.Size = new System.Drawing.Size(348, 20);
            this.tb_Kol.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Количество";
            // 
            // ProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 382);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Kol);
            this.Controls.Add(this.tb_Art);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Op);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.pb_Set);
            this.Name = "ProductAdd";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.ProductAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Set)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Set;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Op;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Art;
        private System.Windows.Forms.TextBox tb_Kol;
        private System.Windows.Forms.Label label6;
    }
}