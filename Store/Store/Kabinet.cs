using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Kabinet : Form
    {
        int idu;

        dataBase dataBase = new dataBase();

        public Kabinet(int idu)
        {
            InitializeComponent();
            this.idu = idu;
        }

        private void Kabinet_Load(object sender, EventArgs e)
        {
            chekKlient();
            loadInfoKlient();
        }

        private void chekKlient()
        {
            dataBase.openConnection();
            string query = $"Select * from Klients where IDUser = '{idu}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
            {
                query = $"insert into Klients (KlientName, IDUser) values ('Имя', '{idu}')";

                sqlCommand = new SqlCommand(query, dataBase.getConnection());
                sqlCommand.ExecuteNonQuery();
            }
            dataBase.closeConnection();
        }

        private void loadInfoKlient()
        {
            dataBase.openConnection();

            string query = $"Select Surname, KlientName, LastName, ImageKlient, Telefon, Users.UserLogin from Klients, Users where Klients.IDUser = Users.IDUser and Klients.IDUser = '{idu}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            tb_Surname.Text = dataTable.Rows[0].ItemArray[0].ToString();
            tb_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();
            tb_LastName.Text = dataTable.Rows[0].ItemArray[2].ToString();
            tb_Telefon.Text = dataTable.Rows[0].ItemArray[4].ToString();
            l_Login.Text = dataTable.Rows[0].ItemArray[5].ToString();

            if (dataTable.Rows[0].ItemArray[3] != Convert.DBNull)
            {
                var imageData = (byte[])dataTable.Rows[0].ItemArray[3];
                var memorySream = new MemoryStream(imageData);

                pictureBox1.Image = Image.FromStream(memorySream);
            }
            
            dataBase.closeConnection();
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            using (var openFIleDialog = new OpenFileDialog())
            {
                openFIleDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFIleDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFIleDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFIleDialog.FileName);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var surName = tb_Surname.Text;
            var name = tb_Name.Text;
            var lastName = tb_LastName.Text;
            var tel = tb_Telefon.Text;

            string query = $"Update Klients set Surname = '{surName}', KlientName = '{name}', LastName = '{lastName}', ImageKlient = @Image, Telefon = '{tel}' where IDUser = '{idu}'";

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            var image = new Bitmap(pictureBox1.Image);
            using (var memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                memoryStream.Position = 0;
                var sqlParameter = new SqlParameter("@Image", SqlDbType.VarBinary, (int)memoryStream.Length)
                {
                    Value = memoryStream.ToArray()
                };
                sqlCommand.Parameters.Add(sqlParameter);
            }
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Данные в личном кабинете успешно изменены!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataBase.openConnection();
        }
    }
}
