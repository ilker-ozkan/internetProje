
using Microsoft.AspNetCore.Mvc;
using Internet_1.Repositories;
using Internet_1.Models;

namespace Internet_1.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public IActionResult Index()
        {
            var cartItems = _cartRepository.GetCartItems();
            return View(cartItems);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int quantity)
        {
            _cartRepository.AddToCart(productId, quantity);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId)
        {
            _cartRepository.RemoveFromCart(productId);
            return RedirectToAction("Index");
        }
    }
}
