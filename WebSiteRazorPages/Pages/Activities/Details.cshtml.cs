using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebSiteRazorPages.Models;

namespace WebSiteRazorPages.Pages.Activities
{
    public class DetailsModel : PageModel
    {
        private readonly WebSiteRazorPages.Models.WebSiteRazorPagesContext _context;

        public DetailsModel(WebSiteRazorPages.Models.WebSiteRazorPagesContext context)
        {
            _context = context;
        }

        public Activity Activity { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Activity = await _context.Activity.FirstOrDefaultAsync(m => m.ActivityId == id);

            if (Activity == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
