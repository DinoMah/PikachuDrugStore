using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaPikachu
{
    class Search
    {
        private DataBase db;
        private List<Product> productList;

        public Search()
        {
            this.db = new DataBase();
            this.productList = new List<Product>();
        }

        public List<Product> SearchByName(String productName)
        {
            this.productList.Clear();
            String command = $"SELECT * FROM product WHERE Name LIKE '{productName.Trim()}%'";
            var reader = this.db.executeCommand(command);
            while(reader.Read())
            {
                this.productList.Add(
                    new ModifiableProduct {
                        Key = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetFloat(2),
                        Provider = reader.GetString(3),
                        Description = (reader[4] is DBNull) ? "" : reader.GetString(4),
                        ExpirationDate = DateTime.Parse(reader.GetString(5)),
                        Changed = false
                    }
                );
            }
            reader.Close();
            db.closeConnection();
            return this.productList;
        }
    }
}
