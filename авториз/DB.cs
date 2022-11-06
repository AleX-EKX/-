using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoriz
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3307; username=root; password=root; database=baza");
        public void openConnection()
        {

            if (connection.State == System.Data.ConnectionState.Closed)  //если состояние бд закрыто, то делаем
                connection.Open();
            //открывает соединение
        }

        public void closeConnection()
        {

            if (connection.State == System.Data.ConnectionState.Open)  //если состояние бд открыто, то делаем
                connection.Close();
            //закрывает соединение
        }

        public MySqlConnection GetConnection() //возвращает определенный обьект
        {
            return connection; //возвращаем конектион
        }

    }
}
