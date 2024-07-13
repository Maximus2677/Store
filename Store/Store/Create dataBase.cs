using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Store
{
    internal class Create_dataBase
    {
        public void createDB()
        {
            if (File.Exists("dbExist.txt") == false)
            {
                File.Create("dbExist.txt");

                SqlConnection sqlConnection1 = new SqlConnection(@"Persist Security Info=True;Trusted_Connection=True; database=Master;server=(local)");

                sqlConnection1.Open();

                string querystring = $"Create database store";
                SqlCommand sqlCommand = new SqlCommand(querystring, sqlConnection1);
                sqlCommand.ExecuteNonQuery();

                sqlConnection1.Close();

                createTable();
                createForeignKeys();
                insertUser();
                insertStatus();
            }
        }

        //Создание таблиц
        private void createTable()
        {
            openConnection();

            string querystring = $"Create table Orders(\r\nIDOrder int primary key identity(1,1),\r\nDateOrder date,\r\nIDProduct int,\r\nIDKlient int,\r\nIDStatus int,\r\nKolichestvo int,\r\nPrice float)\r\n\r\nCreate table Products(\r\nIDProduct int primary key identity(1,1),\r\nNameProduct varchar(40),\r\nImageProduct varbinary(max),\r\nOpisanie varchar(500),\r\nPrice float,\r\nArticule int,\r\nKolichestvo int,\r\nrating int)\r\n\r\nCreate table Klients(\r\nIDKlient int primary key identity(1,1),\r\nSurname varchar(20),\r\nKlientName varchar(20),\r\nLastName varchar(20),\r\nImageKlient varbinary(max),\r\nTelefon varchar(20),\r\nIDUser int)\r\n\r\nCreate table Statuses(\r\nIDStatus int primary key,\r\nStatusName varchar(40))\r\n\r\nCreate table Users(\r\nIDUser int primary key identity(1,1),\r\nUserLogin varchar(40),\r\nUserPassword varchar (40),\r\nUserRole bit,\r\nIsAdmin bit)";
            SqlCommand sqlCommand = new SqlCommand(querystring, getConnection());
            sqlCommand.ExecuteNonQuery();

            closeConnection();
        }

        //Создание связей между таблицами
        private void createForeignKeys()
        {
            openConnection();

            string querystring = $"alter table Orders\r\nAdd constraint FK_Orders_Products foreign key (IDProduct)\r\nreferences Products (IDProduct)\r\n\r\nalter table Orders\r\nAdd constraint FK_Orders_Klients foreign key (IDKlient)\r\nreferences Klients (IDKlient)\r\n\r\nalter table Orders\r\nAdd constraint FK_Orders_Statuses foreign key (IDStatus)\r\nreferences Statuses (IDStatus)\r\n\r\nalter table Klients\r\nAdd constraint FK_Klients_Users foreign key (IDUser)\r\nreferences Users (IDUser)";
            SqlCommand sqlCommand = new SqlCommand(querystring, getConnection());
            sqlCommand.ExecuteNonQuery();

            closeConnection();
        }

        //Внесение данных в таблицы
        private void insertUser()
        {
            openConnection();

            string querystring = $"insert into Users (UserLogin, UserPassword, UserRole, IsAdmin) values ('admin','21232F297A57A5A743894A0E4A801FC3',1,1)";
            SqlCommand sqlCommand = new SqlCommand(querystring, getConnection());
            sqlCommand.ExecuteNonQuery();

            closeConnection();
        }

        private void insertStatus()
        {
            openConnection();

            string querystring = $"insert into Statuses (IDStatus, StatusName) values ('0','не выполнено')\r\ninsert into Statuses (IDStatus, StatusName) values ('1','выполнено')\r\ninsert into Statuses (IDStatus, StatusName) values ('2','отменено')";
            SqlCommand sqlCommand = new SqlCommand(querystring, getConnection());
            sqlCommand.ExecuteNonQuery();

            closeConnection();
        }

        SqlConnection sqlConnection = new SqlConnection(@"Persist Security Info=True;Trusted_Connection=True; database=store;server=(local)");

        //Подключение к субд
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        //Отключение от субд
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //Возращает строку подключение к бд
        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
