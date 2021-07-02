using IdentityManager.Data;
using IdentityManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{

    public class PagesController : Controller
    {

        private readonly ApplicationDbContext context;

        public PagesController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task <IActionResult> Page (string slug)
        {
            if (slug == null)
            {
                return View(await context.Pages.Where(x => x.Slug == "home").FirstOrDefaultAsync());
            }

            Page page = await context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();
            if (page == null)
            {
                return NotFound();
            }
            return View(page);
        }
    }
}