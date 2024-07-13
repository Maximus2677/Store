using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Store
{
    public partial class Login : Form
    {
        dataBase dataBase = new dataBase();

        Create_dataBase create_DataBase = new Create_dataBase();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            create_DataBase.createDB();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '●';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var userLogin = tb_Login.Text;
            var userPassword = md5.hashPassword(tb_Password.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"Select IDUser, UserLogin, UserPassword, UserRole, IsAdmin from Users where UserLogin = '{userLogin}' and UserPassword = '{userPassword}'";

            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Вы успешно вошли!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                int idu = Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);

                bool sot = Convert.ToBoolean(dataTable.Rows[0].ItemArray[3]);
                bool ad = Convert.ToBoolean(dataTable.Rows[0].ItemArray[4]);

                if (sot)
                {
                    SelectFormSot selectFormSot = new SelectFormSot(ad);
                    this.Hide();
                    selectFormSot.ShowDialog();
                    this.Show();
                }
                else
                {
                    SelectFromPok selectFromPok = new SelectFromPok(idu);
                    this.Hide();
                    selectFromPok.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reg reg = new Reg();
            reg.Show();
        }
    }
}
