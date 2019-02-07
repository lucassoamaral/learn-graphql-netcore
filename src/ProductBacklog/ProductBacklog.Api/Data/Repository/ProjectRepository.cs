using System.Collections.Generic;
using ProductBacklog.Api.Model;

namespace ProductBacklog.Api.Data.Repository
{
    public class ProjectRepository : IRepository<Project>
    {
        public IEnumerable<Project> GetAll()
        {
            return new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Test",
                    Description = "Test"
                }
            };
        }
    }
}
