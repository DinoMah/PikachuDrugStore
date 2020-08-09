using System;

namespace FarmaciaPikachu
{
    class Product
    {
        private DateTime expirationDate;
        private float price;
        public int Key { get; set; } // Acts like an id for the product
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Provider { get; set; }

        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (DateTime.Compare(value, DateTime.Now) > 0)
                {
                    expirationDate = value;
                    Available = true;
                }
                else
                {
                    expirationDate = value;
                    Available = false;
                }
            }
        }

        public float Price
        {
            get { return price; }
            set => price = (value > 0) ? value : float.Parse(null);
        }
    }
}
