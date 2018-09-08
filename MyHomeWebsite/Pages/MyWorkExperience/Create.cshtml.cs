using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Pages.MyWorkExperience
{
    public class CreateModel : PageModel
    {
        private readonly MyHomeWebsite.Data.MyWebsiteDbContext _context;

        public CreateModel(MyHomeWebsite.Data.MyWebsiteDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public WorkExperience WorkExperience { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.workExperiences.Add(WorkExperience);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

      //  [Route("[controller]/[action]")]
    }
}