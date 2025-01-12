using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql;
using MySql.Data.MySqlClient;

namespace HotelReservationSystem.DataAccessLayer
{
    class databaseConnection
    {
        // Data Access Object for database connection.
        public MySqlConnection connection()
        {
            MySqlConnection connection = new MySqlConnection("Server=172.21.54.253; Database=25_132330038; Uid=25_132330038; Pwd=!nif.ogr38DE;");
            connection.Open();
            return connection;
        }
    }
}
