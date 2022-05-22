using eTickets.Data.Cart;
using eTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ShoppingCart _shoppingCart;

        public OrdersController(IMovieService movieService, ShoppingCart shoppingCart)
        {
            _movieService = movieService;
            _shoppingCart = shoppingCart;

        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShophingCartItems();
            return View();
        }
    }
}
