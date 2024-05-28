using EticProje.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EticProje.Compenent
{
    public class SliderList : ViewComponent
    {

        private readonly ApplicationsDbContext _context;
        public SliderList(ApplicationsDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var resault = _context.Sliders.ToList();
            return View(resault);
        }
    }
}
