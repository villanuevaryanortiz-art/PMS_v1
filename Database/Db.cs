using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace PMS_v1.Database
{
    public static class Db 
    {
        public static MySqlConnection GetConnection() =>
        new MySqlConnection(ConfigurationManager.ConnectionStrings["pmsDB"].ConnectionString);

    }
}
