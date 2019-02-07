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
                    Id = 2,
                    Title = "Test 2",
                    Description = "Test  2",
                    Type = Enums.ProjectType.Customer,
                    ParentProject = new Project
                    {
                        Id = 1,
                        Title = "Test 1",
                        Description = "Test 1"
                    },
                    Subprojects = new List<Project>
                    {
                        new Project
                        {
                            Id = 3,
                            Title = "Test 3",
                            Description = "Test 3"
                        }
                    }
                }
            };
        }
    }
}
