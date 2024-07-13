using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Store
{
    public partial class OrdersView : Form
    {
        dataBase dataBase = new dataBase();

        int ido, idu;
        bool sot;

        public OrdersView(bool sot, int idu)
        {
            InitializeComponent();
            this.sot = sot;
            this.idu = idu;
        }

        private void OrdersView_Load(object sender, EventArgs e)
        {
            refreshDataGrid();

            if (sot)
            {
                Idd.Visible = true;
                label2.Visible = true;
                comboBox1.Visible = true;
                btn_Save.Visible = true;
                btn_Delete.Visible = true;
            }
        }

        private void refreshDataGrid()
        {
            DataGridView dgv = dataGridView1;

            dgv.Rows.Clear();

            dataBase.openConnection();

            if (sot)
            {
                string query = $"Select IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price from Orders, Products, Klients, Statuses where Orders.IDProduct = Products.IDProduct and Orders.IDKlient = Klients.IDKlient and Orders.IDStatus = Statuses.IDStatus";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgv.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4], dataTable.Rows[i].ItemArray[5], dataTable.Rows[i].ItemArray[6], dataTable.Rows[i].ItemArray[7], dataTable.Rows[i].ItemArray[8], dataTable.Rows[i].ItemArray[9]);
                }
            }
            else
            {
                string query = $"Select IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price from Orders, Products, Klients, Statuses where Orders.IDProduct = Products.IDProduct and Orders.IDKlient = Klients.IDKlient and Orders.IDStatus = Statuses.IDStatus and IDUser = {idu}";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgv.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4], dataTable.Rows[i].ItemArray[5], dataTable.Rows[i].ItemArray[6], dataTable.Rows[i].ItemArray[7], dataTable.Rows[i].ItemArray[8], dataTable.Rows[i].ItemArray[9]);
                }
            }

            dataBase.closeConnection();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                Idd.Text = "ID: " + row.Cells[0].Value.ToString();
                comboBox1.SelectedItem = row.Cells[7].Value;

                ido = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            dgv.Rows.Clear();

            dataBase.openConnection();

            if (sot)
            {
                string query = $"Select IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price from Orders, Products, Klients, Statuses where Orders.IDProduct = Products.IDProduct and Orders.IDKlient = Klients.IDKlient and Orders.IDStatus = Statuses.IDStatus and concat (IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price) like '%" + tb_Search.Text + "%'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgv.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4], dataTable.Rows[i].ItemArray[5], dataTable.Rows[i].ItemArray[6], dataTable.Rows[i].ItemArray[7], dataTable.Rows[i].ItemArray[8], dataTable.Rows[i].ItemArray[9]);
                }
            }
            else
            {
                string query = $"Select IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price from Orders, Products, Klients, Statuses where Orders.IDProduct = Products.IDProduct and Orders.IDKlient = Klients.IDKlient and Orders.IDStatus = Statuses.IDStatus and IDUser = {idu} and concat (IDOrder, DateOrder, NameProduct, Surname, KlientName, LastName, Telefon, StatusName, Orders.Kolichestvo, Orders.Price) like '%" + tb_Search.Text + "%'";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                DataTable dataTable = new DataTable();

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dgv.Rows.Add(dataTable.Rows[i].ItemArray[0], dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3], dataTable.Rows[i].ItemArray[4], dataTable.Rows[i].ItemArray[5], dataTable.Rows[i].ItemArray[6], dataTable.Rows[i].ItemArray[7], dataTable.Rows[i].ItemArray[8], dataTable.Rows[i].ItemArray[9]);
                }
            }
            dataBase.closeConnection();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            save();
            refreshDataGrid();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            delete();
            refreshDataGrid();
        }

        private void save()
        {
            dataBase.openConnection();

            int idd = ido;
            int stat = comboBox1.SelectedIndex;

            if (idd != 0)
            {
                if (stat != -1)
                {
                    string query = $"Update Orders set IDStatus = {stat} where IDOrder = {idd}";

                    SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                    sqlCommand.ExecuteNonQuery();

                    MessageBox.Show("Изменения успешно сохранены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Неверное значение в поле статус!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Не выбран заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.openConnection();
        }

        private void delete()
        {
            dataBase.openConnection();

            int idd = ido;

            if (idd != 0)
            {
                string query = $"Delete Orders where IDOrder = {idd}";

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Заказ успешно удалён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Не выбран заказ!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.openConnection();
        }
    }
}
