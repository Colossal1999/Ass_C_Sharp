namespace Ass_C_sharp
{
    public class Product
    {
        private string productId;
        private string name;
        private string price;

        public Product()
        {
        }

        public Product(string productId, string name, string price)
        {
            this.productId = productId;
            this.name = name;
            this.price = price;
        }

        public string ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Price
        {
            get => price;
            set => price = value;
        }
    }
}