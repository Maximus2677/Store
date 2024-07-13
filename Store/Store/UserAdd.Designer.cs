namespace Store
{
    partial class UserAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.cb_Sot = new System.Windows.Forms.CheckBox();
            this.cb_Admin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить пользователя";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // tb_Login
            // 
            this.tb_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Login.Location = new System.Drawing.Point(156, 76);
            this.tb_Login.MaxLength = 40;
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(208, 20);
            this.tb_Login.TabIndex = 5;
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Password.Location = new System.Drawing.Point(156, 102);
            this.tb_Password.MaxLength = 40;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(208, 20);
            this.tb_Password.TabIndex = 6;
            // 
            // cb_Sot
            // 
            this.cb_Sot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Sot.AutoSize = true;
            this.cb_Sot.Location = new System.Drawing.Point(156, 128);
            this.cb_Sot.Name = "cb_Sot";
            this.cb_Sot.Size = new System.Drawing.Size(79, 17);
            this.cb_Sot.TabIndex = 7;
            this.cb_Sot.Text = "Сотрудник";
            this.cb_Sot.UseVisualStyleBackColor = true;
            // 
            // cb_Admin
            // 
            this.cb_Admin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_Admin.AutoSize = true;
            this.cb_Admin.Location = new System.Drawing.Point(156, 151);
            this.cb_Admin.Name = "cb_Admin";
            this.cb_Admin.Size = new System.Drawing.Size(59, 17);
            this.cb_Admin.TabIndex = 8;
            this.cb_Admin.Text = "Админ";
            this.cb_Admin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(210, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Admin);
            this.Controls.Add(this.cb_Sot);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserAdd";
            this.Text = "Добавление пользователя";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.CheckBox cb_Sot;
        private System.Windows.Forms.CheckBox cb_Admin;
        private System.Windows.Forms.Button button1;
    }
}