using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;

namespace lab11_case0604
{
    public static class Database
    {
        public static MySqlConnection GetMySqlConnection()
        {
            string filePath = "../../../config.ini";
            List<string> config = new List<string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string value = parts[1];
                        config.Add(value);
                    }
                }
            }
            string connectStr = string.Format("server={0}; database={1}; UID={2}; PWD={3}; port={4}", config[0], config[1], config[2], config[3], config[4]);


            MySqlConnection conn = new MySqlConnection(connectStr);

            return conn;
        }
    }
}
