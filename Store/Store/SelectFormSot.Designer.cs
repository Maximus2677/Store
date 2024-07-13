namespace Store
{
    partial class SelectFormSot
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
            this.AdminPanel = new System.Windows.Forms.Button();
            this.Zakazes = new System.Windows.Forms.Button();
            this.Katalog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminPanel.Enabled = false;
            this.AdminPanel.Location = new System.Drawing.Point(65, 54);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(130, 23);
            this.AdminPanel.TabIndex = 0;
            this.AdminPanel.Text = "Администрирование";
            this.AdminPanel.UseVisualStyleBackColor = true;
            this.AdminPanel.Click += new System.EventHandler(this.AdminPanel_Click);
            // 
            // Zakazes
            // 
            this.Zakazes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Zakazes.Location = new System.Drawing.Point(65, 83);
            this.Zakazes.Name = "Zakazes";
            this.Zakazes.Size = new System.Drawing.Size(130, 23);
            this.Zakazes.TabIndex = 1;
            this.Zakazes.Text = "Просмотр заказов";
            this.Zakazes.UseVisualStyleBackColor = true;
            this.Zakazes.Click += new System.EventHandler(this.Zakazes_Click);
            // 
            // Katalog
            // 
            this.Katalog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Katalog.Location = new System.Drawing.Point(65, 112);
            this.Katalog.Name = "Katalog";
            this.Katalog.Size = new System.Drawing.Size(130, 23);
            this.Katalog.TabIndex = 2;
            this.Katalog.Text = "Каталог товаров";
            this.Katalog.UseVisualStyleBackColor = true;
            this.Katalog.Click += new System.EventHandler(this.Katalog_Click);
            // 
            // SelectFormSot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 190);
            this.Controls.Add(this.Katalog);
            this.Controls.Add(this.Zakazes);
            this.Controls.Add(this.AdminPanel);
            this.Name = "SelectFormSot";
            this.Text = "Выбор окна";
            this.Load += new System.EventHandler(this.SelectFormSot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AdminPanel;
        private System.Windows.Forms.Button Zakazes;
        private System.Windows.Forms.Button Katalog;
    }
}