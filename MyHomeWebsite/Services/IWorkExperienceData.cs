using MyHomeWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHomeWebsite.Services
{
   public interface IWorkExperienceData
    {        
        IEnumerable<WorkExperience> GetAll();

        //WorkExperience Edit(WorkExperience workExperience);

        WorkExperience Add(WorkExperience workExperience);

        WorkExperience Get(Guid id);

        void Delete(Guid id);
    }
}
