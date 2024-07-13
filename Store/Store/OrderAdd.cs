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
    public partial class OrderAdd : Form
    {
        dataBase dataBase = new dataBase();

        int id, idu, idk;
        float PriceT, temp;

        public OrderAdd(int id, int idu)
        {
            InitializeComponent();
            this.id = id;
            this.idu = idu;
        }

        private void OrderAdd_Load(object sender, EventArgs e)
        {
            l_Date.Text = "Дата: " + DateTime.Now.ToString();
            chekTovar();
            chekKlient();
            raschet();
        }

        private void chekTovar()
        {
            dataBase.openConnection();

            string query = $"Select NameProduct, Price from Products where IDProduct = '{id}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            dataBase.closeConnection();

            l_ProdName.Text = "Название товара: " + dataTable.Rows[0].ItemArray[0].ToString();
            PriceT = Convert.ToSingle(dataTable.Rows[0].ItemArray[1]);
        }

        private void chekKlient()
        {
            dataBase.openConnection();

            string query = $"Select Surname, KlientName, LastName, Telefon, IDKlient from Klients where IDUser = '{idu}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            dataBase.closeConnection();

            l_SurName.Text = "Фамилия: " + dataTable.Rows[0].ItemArray[0].ToString();
            l_Name.Text = "Имя: " + dataTable.Rows[0].ItemArray[1].ToString();
            l_LastName.Text = "Отчество: " + dataTable.Rows[0].ItemArray[2].ToString();
            l_Telefon.Text = "Телефон: " + dataTable.Rows[0].ItemArray[3].ToString();

            idk = Convert.ToInt32(dataTable.Rows[0].ItemArray[4]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            raschet();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int kol) && Convert.ToInt32(textBox1.Text) > 0)
            {
                dataBase.openConnection();

                string query = $"insert into Orders (DateOrder, IDProduct, IDKlient, IDStatus, Kolichestvo, Price) values ('{DateTime.Now}', {id}, {idk}, 0, {kol}, {temp})";

                SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();

                dataBase.closeConnection();

                MessageBox.Show("Заказ успешно создан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Поле количество должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void raschet()
        {
            if(int.TryParse(textBox1.Text, out int kol) && Convert.ToInt32(textBox1.Text) > 0)
            {
                temp = PriceT * Convert.ToSingle(kol);

                l_Price.Text = "Конечная цена: " + temp.ToString();
            }
            else
            {
                l_Price.Text = "Конечная цена: Ошибка!";
            }
        }
    }
}
