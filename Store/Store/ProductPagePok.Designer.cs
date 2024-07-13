namespace Store
{
    partial class ProductPagePok
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
            this.l_Kol = new System.Windows.Forms.Label();
            this.l_Art = new System.Windows.Forms.Label();
            this.l_Price = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_Name = new System.Windows.Forms.Label();
            this.btn_Buy = new System.Windows.Forms.Button();
            this.tb_Op = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_Kol
            // 
            this.l_Kol.AutoSize = true;
            this.l_Kol.Location = new System.Drawing.Point(301, 279);
            this.l_Kol.Name = "l_Kol";
            this.l_Kol.Size = new System.Drawing.Size(69, 13);
            this.l_Kol.TabIndex = 26;
            this.l_Kol.Text = "Количество:";
            // 
            // l_Art
            // 
            this.l_Art.AutoSize = true;
            this.l_Art.Location = new System.Drawing.Point(301, 266);
            this.l_Art.Name = "l_Art";
            this.l_Art.Size = new System.Drawing.Size(51, 13);
            this.l_Art.TabIndex = 25;
            this.l_Art.Text = "Артикул:";
            // 
            // l_Price
            // 
            this.l_Price.AutoSize = true;
            this.l_Price.Location = new System.Drawing.Point(301, 253);
            this.l_Price.Name = "l_Price";
            this.l_Price.Size = new System.Drawing.Size(36, 13);
            this.l_Price.TabIndex = 24;
            this.l_Price.Text = "Цена:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // l_Name
            // 
            this.l_Name.AutoSize = true;
            this.l_Name.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_Name.Location = new System.Drawing.Point(6, 9);
            this.l_Name.Name = "l_Name";
            this.l_Name.Size = new System.Drawing.Size(133, 31);
            this.l_Name.TabIndex = 27;
            this.l_Name.Text = "Название";
            // 
            // btn_Buy
            // 
            this.btn_Buy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Buy.Location = new System.Drawing.Point(713, 415);
            this.btn_Buy.Name = "btn_Buy";
            this.btn_Buy.Size = new System.Drawing.Size(75, 23);
            this.btn_Buy.TabIndex = 28;
            this.btn_Buy.Text = "Купить";
            this.btn_Buy.UseVisualStyleBackColor = true;
            this.btn_Buy.Click += new System.EventHandler(this.btn_Buy_Click);
            // 
            // tb_Op
            // 
            this.tb_Op.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Op.Location = new System.Drawing.Point(301, 43);
            this.tb_Op.Multiline = true;
            this.tb_Op.Name = "tb_Op";
            this.tb_Op.ReadOnly = true;
            this.tb_Op.Size = new System.Drawing.Size(487, 207);
            this.tb_Op.TabIndex = 29;
            this.tb_Op.Text = "Описание";
            // 
            // ProductPagePok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Op);
            this.Controls.Add(this.btn_Buy);
            this.Controls.Add(this.l_Name);
            this.Controls.Add(this.l_Kol);
            this.Controls.Add(this.l_Art);
            this.Controls.Add(this.l_Price);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ProductPagePok";
            this.Text = "Страница товара";
            this.Load += new System.EventHandler(this.ProductPagePok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Kol;
        private System.Windows.Forms.Label l_Art;
        private System.Windows.Forms.Label l_Price;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_Name;
        private System.Windows.Forms.Button btn_Buy;
        private System.Windows.Forms.TextBox tb_Op;
    }
}