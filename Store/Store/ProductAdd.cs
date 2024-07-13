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
    public partial class ProductAdd : Form
    {
        dataBase dataBase = new dataBase();

        public ProductAdd()
        {
            InitializeComponent();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            using (var openFIleDialog = new OpenFileDialog()) 
            {
                openFIleDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFIleDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if(openFIleDialog.ShowDialog() == DialogResult.OK)
                {
                    pb_Set.Image = Image.FromFile(openFIleDialog.FileName);
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var name = tb_Name.Text;
            var op = tb_Op.Text;

            float price;

            int art, kol;

            if(float.TryParse(tb_Price.Text, out price)) 
            {
                if (int.TryParse(tb_Art.Text, out art))
                {
                    if (int.TryParse(tb_Kol.Text, out kol))
                    {
                        string query = $"insert into Products (NameProduct, ImageProduct, Opisanie, Price, Articule, Kolichestvo) values ('{name}',@Image,'{op}',{price},{art},{kol})";

                        SqlCommand sqlCommand = new SqlCommand(query, dataBase.getConnection());

                        var image = new Bitmap(pb_Set.Image);
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

                        MessageBox.Show("Товар успешно добавлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
