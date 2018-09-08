using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Pages.MyWorkExperience
{
    public class IndexModel : PageModel
    {
        private readonly MyHomeWebsite.Data.MyWebsiteDbContext _context;

        public IndexModel(MyHomeWebsite.Data.MyWebsiteDbContext context)
        {
            _context = context;
        }

        public IList<WorkExperience> WorkExperience { get;set; }

        public async Task OnGetAsync()
        {
            WorkExperience = await _context.workExperiences.ToListAsync();
        }
    }
}
