using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Pages.MyWorkExperience
{
    public class EditModel : PageModel
    {
        private readonly MyHomeWebsite.Data.MyWebsiteDbContext _context;

        public EditModel(MyHomeWebsite.Data.MyWebsiteDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public WorkExperience WorkExperience { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WorkExperience = await _context.workExperiences.SingleOrDefaultAsync(m => m.ID == id);

            if (WorkExperience == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WorkExperience).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkExperienceExists(WorkExperience.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WorkExperienceExists(Guid id)
        {
            return _context.workExperiences.Any(e => e.ID == id);
        }
    }
}
