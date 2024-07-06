namespace BOL
{
    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double unit_price { get; set; }
        public string image_url { get; set; }
        public int quantity {  get; set; }


        public Product(int id, string title, string description, double unit_price, string image_url, int quantity)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.unit_price = unit_price;
            this.image_url = image_url;
            this.quantity = quantity;
        }

        public Product(string title, string description, double unit_price, string image_url, int quantity)
        {
           
            this.title = title;
            this.description = description;
            this.unit_price = unit_price;
            this.image_url = image_url;
            this.quantity = quantity;
        }

    }


}
