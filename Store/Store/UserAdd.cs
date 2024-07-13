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
    public partial class UserAdd : Form
    {
        dataBase dataBase = new dataBase();

        public UserAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var login = tb_Login.Text;
            var pass = md5.hashPassword(tb_Password.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            string querystring = $"Select UserLogin From Users where UserLogin = '{login}'";

            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                querystring = $"insert into Users (UserLogin, UserPassword, UserRole, IsAdmin) values ('{login}', '{pass}', '{cb_Sot.Checked}', '{cb_Admin.Checked}')";

                sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Пользователь успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Такой логин уже используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.closeConnection();
        }

        private void UserAdd_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '●';
        }
    }
}
