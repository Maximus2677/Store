using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class ProductPagePok : Form
    {
        dataBase dataBase = new dataBase();

        int id, idu;

        public ProductPagePok(int id, int idu)
        {
            InitializeComponent();
            this.id = id;
            this.idu = idu;
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (chekKlient())
            {
                OrderAdd orderAdd = new OrderAdd(id, idu);
                orderAdd.ShowDialog();
            }
            else
            {
                MessageBox.Show("Личный кабинет не заполнен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProductPagePok_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string query = $"Select * from Products where IDProduct = '{id}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            l_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();
            tb_Op.Text = "Описание: " + dataTable.Rows[0].ItemArray[3].ToString();
            l_Price.Text = "Цена: " + dataTable.Rows[0].ItemArray[4].ToString();
            l_Art.Text = "Артикул: " + dataTable.Rows[0].ItemArray[5].ToString();
            l_Kol.Text = "Количество на складе: "+ dataTable.Rows[0].ItemArray[6].ToString();

            var imageData = (byte[])dataTable.Rows[0].ItemArray[2];
            var memorySream = new MemoryStream(imageData);

            pictureBox1.Image = Image.FromStream(memorySream);

            dataBase.closeConnection();
        }

        private bool chekKlient()
        {
            dataBase.openConnection();
            string query = $"Select * from Klients where IDUser = '{idu}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            dataBase.closeConnection();

            bool a;

            if (dataTable.Rows.Count == 0)
            {
                a = false;
            }
            else
            {
                a = true;
            }
            return a;
        }
    }
}
