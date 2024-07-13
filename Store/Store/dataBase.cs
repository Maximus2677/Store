using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Store
{
    internal class dataBase
    {
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
