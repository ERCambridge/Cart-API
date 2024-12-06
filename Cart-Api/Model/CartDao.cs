namespace Cart_Api.Model
{
    public class CartDao
    {
        public static List<CartItem> cart;

        public CartDao()
        {
            cart = new List<CartItem>();

            cart.Add(new CartItem(1, "Apples", 2.50, 10));
            cart.Add(new CartItem(2, "Oranges", 4.25, 15));
            cart.Add(new CartItem(3, "Cucumber", 3.50, 20));
            cart.Add(new CartItem(4, "Bananas", 1.50, 22));
            cart.Add(new CartItem(5, "Steak", 25.50, 12));
        }

        public List<CartItem> getProducts()
        {
            return cart;
        }

        public CartItem getProductById(int id)
        {
            return cart.Find(p => p.id == id);
        }

        public CartItem addProduct(CartItem item)
        {
            cart.Add(item);
            return item;
        }

        public CartItem? removeProduct(int id)
        {
            CartItem item = cart.Find(p => p.id == id);
            if (item != null)
            {
                cart.Remove(item);                
            }
            return item;
        }

        public CartItem updateProduct(CartItem newItem)
        {
            CartItem? item = cart.Find(p =>  p.id == newItem.id);
            if (item != null)
            {
                item.price = newItem.price;
                item.quantity = newItem.quantity;
                item.product = newItem.product;
            }
            return item;

        }
    }
}
