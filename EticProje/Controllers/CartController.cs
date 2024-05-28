    using EticProje.Data;
using EticProje.Dto;
using EticProje.Models;
using EticProje.Oturum;
using Microsoft.AspNetCore.Mvc;

namespace EticProje.Controllers
{
    public class CartController : Controller
    {
        private readonly ApplicationsDbContext _context;

        public CartController(ApplicationsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<CartItem> items = HttpContext.Session.GetJson<List<CartItem>>("Cart") ?? new List<CartItem>();
            CartDtoModel cartvm = new()
            {
                cardItems = items,
                GrandTotal = items.Sum(x => x.Quantity * x.Price)
            };
            return View(cartvm);
        }
    }
}
