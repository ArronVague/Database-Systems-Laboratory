using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab11_case0604
{
    public static class DatabaseConfig
    {
        public static List<string> GetConfig()
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

            return config;
        }
    }
}
