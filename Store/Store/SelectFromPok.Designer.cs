namespace Store
{
    partial class SelectFromPok
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
            this.Katalog = new System.Windows.Forms.Button();
            this.Zakazes = new System.Windows.Forms.Button();
            this.Kabinet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Katalog
            // 
            this.Katalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Katalog.Location = new System.Drawing.Point(60, 108);
            this.Katalog.Name = "Katalog";
            this.Katalog.Size = new System.Drawing.Size(130, 23);
            this.Katalog.TabIndex = 5;
            this.Katalog.Text = "Каталог товаров";
            this.Katalog.UseVisualStyleBackColor = true;
            this.Katalog.Click += new System.EventHandler(this.Katalog_Click);
            // 
            // Zakazes
            // 
            this.Zakazes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Zakazes.Location = new System.Drawing.Point(60, 79);
            this.Zakazes.Name = "Zakazes";
            this.Zakazes.Size = new System.Drawing.Size(130, 23);
            this.Zakazes.TabIndex = 4;
            this.Zakazes.Text = "Просмотр заказов";
            this.Zakazes.UseVisualStyleBackColor = true;
            this.Zakazes.Click += new System.EventHandler(this.Zakazes_Click);
            // 
            // Kabinet
            // 
            this.Kabinet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Kabinet.Location = new System.Drawing.Point(60, 50);
            this.Kabinet.Name = "Kabinet";
            this.Kabinet.Size = new System.Drawing.Size(130, 23);
            this.Kabinet.TabIndex = 3;
            this.Kabinet.Text = "Личный кабинет";
            this.Kabinet.UseVisualStyleBackColor = true;
            this.Kabinet.Click += new System.EventHandler(this.Kabinet_Click);
            // 
            // SelectFromPok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 189);
            this.Controls.Add(this.Katalog);
            this.Controls.Add(this.Zakazes);
            this.Controls.Add(this.Kabinet);
            this.Name = "SelectFromPok";
            this.Text = "Выбор окна";
            this.Load += new System.EventHandler(this.SelectFromPok_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Katalog;
        private System.Windows.Forms.Button Zakazes;
        private System.Windows.Forms.Button Kabinet;
    }
}