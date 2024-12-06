
namespace Cart_Api.Model
{
    public class CartItem
    {

        public int id { get; set; }
        public string product { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

       
        public CartItem() { }

    
        public CartItem(int Id, string Product, double Price, int Quantity)
        {
            id = Id;
            product = Product;
            price = Price;
            quantity = Quantity;
        }

        public override bool Equals(object? obj)
        {
            return obj is CartItem item &&
                   id == item.id &&
                   product == item.product &&
                   price == item.price &&
                   quantity == item.quantity;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, product, price, quantity);
        }
    } // End of class
} // End of namespace
