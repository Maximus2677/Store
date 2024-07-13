using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Katalog : Form
    {
        bool sot;
        int idu;

        dataBase dataBase = new dataBase();

        public Katalog(bool sot, int idu)
        {
            InitializeComponent();
            this.sot = sot;
            this.idu = idu;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd.ShowDialog();
        }

        private void Katalog_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
            if (sot)
            {
                btn_Add.Visible = true;
                button3.Visible = true;
            }
        }

        private void RefreshDataGrid()
        {
            DataGridView dgv = dataGridView1;

            dgv.Rows.Clear();

            dataBase.openConnection();

            string query = $"Select ImageProduct, NameProduct, Articule, IDProduct from Products";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var imageData = (byte[])dataTable.Rows[i].ItemArray[0];
                var memorySream = new MemoryStream(imageData);

                dgv.Rows.Add(System.Drawing.Image.FromStream(memorySream), dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3]);
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

            DataGridView dgw = dataGridView1;

            dgw.Rows.Clear();

            string query = $"Select ImageProduct, NameProduct, Articule, IDProduct from Products where concat (NameProduct, Articule, IDProduct) like '%" + tb_Search.Text + "%'";

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                var imageData = (byte[])dataTable.Rows[i].ItemArray[0];
                var memorySream = new MemoryStream(imageData);

                dgw.Rows.Add(System.Drawing.Image.FromStream(memorySream), dataTable.Rows[i].ItemArray[1], dataTable.Rows[i].ItemArray[2], dataTable.Rows[i].ItemArray[3]);
            }
            dataBase.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRow();
            RefreshDataGrid();
        }

        private void DeleteRow()
        {
            dataBase.openConnection();

            var id = Idd.Text;

            if (id != "0")
            {
                deleteOrder(Convert.ToInt32(id));

                string querystring = $"delete from Products where IDProduct = '{Convert.ToInt32(id)}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Товар успешно удалён!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Idd.Text = "0";
            }
            else
            {
                MessageBox.Show("Не выбран товар для удаления!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dataBase.closeConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                Idd.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Idd.Text != "0")
            {
                if (sot)
                {
                    ProductPage productPage = new ProductPage(Convert.ToInt32(Idd.Text));
                    productPage.ShowDialog();
                }
                else
                {
                    ProductPagePok productPagePok = new ProductPagePok(Convert.ToInt32(Idd.Text), idu);
                    productPagePok.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Не выбран товар", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteOrder(int id)
        {
            string querystring = $"delete from Orders where IDProduct = '{id}'";
            SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.getConnection());
            sqlCommand.ExecuteNonQuery();
        }
    }
}
