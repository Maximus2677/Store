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

namespace Store
{
    public partial class Reg : Form
    {
        dataBase dataBase = new dataBase();

        public Reg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reg_Load(object sender, EventArgs e)
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

            string querystring = $"Select UserLogin from Users where UserLogin = '{userLogin}'";

            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                string querystring2 = $"Insert into Users (UserLogin, UserPassword, UserRole, IsAdmin) values ('{userLogin}', '{userPassword}', '0', '0')";

                SqlCommand sqlCommand2 = new SqlCommand(querystring2, dataBase.getConnection());

                sqlCommand2.ExecuteNonQuery();

                MessageBox.Show("Вы успешно зарегестрировались!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Такой логин уже используеться!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
        }
    }
}
