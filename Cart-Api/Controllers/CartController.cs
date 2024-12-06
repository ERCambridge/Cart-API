using Cart_Api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cart_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {

        CartDao theData = new CartDao();

        //      curl -X 'GET' \
        //'https://localhost:7282/cart-items' \
        //-H 'accept: */*'
        [HttpGet("/cart-items")]
        public IActionResult getItems() 
        {
            return Ok(theData.getProducts());
        }

        //      curl -X 'GET' \
        //'https://localhost:7282/cart-items/5' \
        //-H 'accept: */*'
        [HttpGet("/cart-items/{id}")]
        public IActionResult getItemById(int id)
        {
            return Ok(theData.getProductById(id));
        }

        //        curl -X 'POST' \
        //  'https://localhost:7282/cart-items' \
        //  -H 'accept: */*' \
        //  -H 'Content-Type: application/json' \
        //  -d '{
        //  "id": 6,
        //  "product": "bacon",
        //  "price": 5.00,
        //  "quantity": 11
        //}'
        [HttpPost("/cart-items")]
        public IActionResult addItem(CartItem item)
        {
            return Ok(theData.addProduct(item));    
        }

        //        curl -X 'PUT' \
        //  'https://localhost:7282/cart-items/5' \
        //  -H 'accept: */*' \
        //  -H 'Content-Type: application/json' \
        //  -d '{
        //  "id": 5,
        //  "product": "string",
        //  "price": 0,
        //  "quantity": 0
        //}'
        [HttpPut("/cart-items/{id}")]
        public IActionResult updateItem(CartItem item)
        {
            return Ok(theData.updateProduct(item));
        }

        //      curl -X 'DELETE' \
        //'https://localhost:7282/cart-items/5' \
        //-H 'accept: */*'
        [HttpDelete("/cart-items/{id}")]
        public IActionResult removeItem(int id)
        {   
            return Ok(theData.removeProduct(id));
        }
    }
}
