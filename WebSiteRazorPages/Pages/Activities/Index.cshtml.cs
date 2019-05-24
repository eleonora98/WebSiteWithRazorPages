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
    public class IndexModel : PageModel
    {
        private readonly WebSiteRazorPages.Models.WebSiteRazorPagesContext _context;

        public IndexModel(WebSiteRazorPages.Models.WebSiteRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Activity> Activity { get;set; }

        public async Task OnGetAsync()
        {
            Activity = await _context.Activity.ToListAsync();
        }
    }
}
