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
    public partial class AdminPanel : Form
    {
        dataBase dataBase = new dataBase();

        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            DataGridView dgw = dataGridView1;

            dgw.Rows.Clear();

            string query = $"Select * from Users";

            dataBase.openConnection();

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dgw.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4]);
            }
            dataBase.closeConnection();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            dataBase.openConnection();

            DataGridView dgw = dataGridView1 ;

            dgw.Rows.Clear();

            string query = $"Select * from Users where concat (IDUser, UserLogin, UserPassword, UserRole, IsAdmin) like '%" + tb_Search.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dgw.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4]);
            }
            dataBase.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                var r = dataGridView1.Rows[i].Cells[3].Value.ToString();
                var a = dataGridView1.Rows[i].Cells[4].Value.ToString();

                var query = $"update Users set UserRole = '{r}', IsAdmin = '{a}' where IDUser = '{id}'";
                var command = new SqlCommand(query, dataBase.getConnection());
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.closeConnection();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            RefreshDataGrid();
        }

        private void DeleteRow()
        {
            dataBase.openConnection();

            var id = label2.Text;

            if (id != "0")
            {
                deleteKlent(Convert.ToInt32(id));

                string querystring = $"delete from Users where IDUser = '{Convert.ToInt32(id)}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Пользователь успешно удалён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                label2.Text = "0";
            }
            else
            {
                MessageBox.Show("Не выбран пользователь для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                label2.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();
        }

        private void deleteKlent(int id)
        {
            deleteOrder(searchKlient(id));

            string querystring = $"delete from Klients where IDUser = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void deleteOrder(int id)
        {
            string querystring = $"delete from Orders where IDKlient = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private int searchKlient(int id)
        {
            string querystring = $"Select IDKlient from Klients where IDUser = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0].ItemArray[0]);
            }
            else
            {
                return 0;
            }
        }
    }
}
