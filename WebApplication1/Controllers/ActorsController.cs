using eCommerce.Data;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Controllers
{
    public class ActorsController : Controller
    {
        //Injjecting  app db context
        private readonly AppDbContext _Context;
        public ActorsController(AppDbContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            var data = _Context.Actors.ToList();
            return View();
        }
    }
}
