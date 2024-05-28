using EticProje.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace EticProje.Compenent
{
    public class TrendList : ViewComponent
    {
        private readonly ApplicationsDbContext _context;
        public TrendList(ApplicationsDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var resault = _context.Products.ToList();
            return View(resault);
        }
    }
}
