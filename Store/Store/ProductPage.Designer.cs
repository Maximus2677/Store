namespace Store
{
    partial class ProductPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Op = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Art = new System.Windows.Forms.TextBox();
            this.tb_Kol = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tb_Op
            // 
            this.tb_Op.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Op.Location = new System.Drawing.Point(301, 73);
            this.tb_Op.MaxLength = 500;
            this.tb_Op.Multiline = true;
            this.tb_Op.Name = "tb_Op";
            this.tb_Op.Size = new System.Drawing.Size(487, 146);
            this.tb_Op.TabIndex = 2;
            this.tb_Op.Text = "Описание";
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(374, 225);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(100, 20);
            this.tb_Price.TabIndex = 3;
            this.tb_Price.Text = "Цена";
            // 
            // tb_Art
            // 
            this.tb_Art.Location = new System.Drawing.Point(374, 251);
            this.tb_Art.Name = "tb_Art";
            this.tb_Art.Size = new System.Drawing.Size(100, 20);
            this.tb_Art.TabIndex = 4;
            this.tb_Art.Text = "Артикул";
            // 
            // tb_Kol
            // 
            this.tb_Kol.Location = new System.Drawing.Point(374, 277);
            this.tb_Kol.Name = "tb_Kol";
            this.tb_Kol.Size = new System.Drawing.Size(100, 20);
            this.tb_Kol.TabIndex = 5;
            this.tb_Kol.Text = "Количесво";
            // 
            // tb_Name
            // 
            this.tb_Name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Name.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(12, 12);
            this.tb_Name.MaxLength = 40;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(776, 39);
            this.tb_Name.TabIndex = 6;
            this.tb_Name.Text = "Название товара";
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(84, 312);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(138, 23);
            this.btn_Image.TabIndex = 7;
            this.btn_Image.Text = "Изменить изображение";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(713, 415);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Описание:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Артикул:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Количество:";
            // 
            // ProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Image);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Kol);
            this.Controls.Add(this.tb_Art);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Op);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductPage";
            this.Text = "Страница товара";
            this.Load += new System.EventHandler(this.ProductPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_Op;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Art;
        private System.Windows.Forms.TextBox tb_Kol;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}