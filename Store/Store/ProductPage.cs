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

namespace Store
{
    public partial class ProductPage : Form
    {
        int id;

        dataBase dataBase = new dataBase();

        public ProductPage(int iid)
        {
            InitializeComponent();
            id = iid;
        }

        private void ProductPage_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();

            string query = $"Select * from Products where IDProduct = '{id}'";

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            tb_Name.Text = dataTable.Rows[0].ItemArray[1].ToString();
            tb_Op.Text = dataTable.Rows[0].ItemArray[3].ToString();
            tb_Price.Text = dataTable.Rows[0].ItemArray[4].ToString();
            tb_Art.Text = dataTable.Rows[0].ItemArray[5].ToString();
            tb_Kol.Text = dataTable.Rows[0].ItemArray[6].ToString();

            var imageData = (byte[])dataTable.Rows[0].ItemArray[2];
            var memorySream = new MemoryStream(imageData);

            pictureBox1.Image = Image.FromStream(memorySream);

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

            var name = tb_Name.Text;
            var op = tb_Op.Text;

            float price;

            int art, kol;

            if (float.TryParse(tb_Price.Text, out price))
            {
                if (int.TryParse(tb_Art.Text, out art))
                {
                    if (int.TryParse(tb_Kol.Text, out kol))
                    {
                        string query = $"Update Products set NameProduct = '{name}', ImageProduct = @Image, Opisanie = '{op}', Price = {price}, Articule = {art}, Kolichestvo = {kol} where IDProduct = {id}";

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

                        MessageBox.Show("Страница товара успешна изменена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Поле количество должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Поле артикул должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Поле цена должен иметь числовой формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataBase.openConnection();
        }
    }
}
