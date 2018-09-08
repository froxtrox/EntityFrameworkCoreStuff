using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyHomeWebsite.Data;
using MyHomeWebsite.Models;

namespace MyHomeWebsite.Services
{
    public class WorkExperienceData : IWorkExperienceData
    {

        MyWebsiteDbContext _Context;

        public WorkExperienceData(MyWebsiteDbContext context)
        {
            _Context = context;
        }
        public WorkExperience Add(WorkExperience workExperience)
        {
            _Context.workExperiences.Add(workExperience);
            _Context.SaveChanges();
            return workExperience;
        }
        
        public void Delete(Guid id)
        {
            var we = _Context.workExperiences.FirstOrDefault(x => x.ID == id);
            _Context.workExperiences.Remove(we);
        }

        public WorkExperience Edit()
        {
            throw new NotImplementedException();
        }

        public WorkExperience Get(Guid id)
        {
            return _Context.workExperiences.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<WorkExperience> GetAll()
        {
            return _Context.workExperiences.ToList();
        }
    }
}
