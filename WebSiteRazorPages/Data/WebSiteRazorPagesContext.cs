using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebSiteRazorPages.Models
{
    public class WebSiteRazorPagesContext : DbContext
    {
        public WebSiteRazorPagesContext (DbContextOptions<WebSiteRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<Activity> Activity { get; set; }
    }
}
