using System;
using System.Collections.Generic;
using System.Linq;
using ProductBacklog.Api.Model;

namespace ProductBacklog.Api.Data.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly IEnumerable<Project> _data = new List<Project>
            {
                new Project
                {
                    Id = 2,
                    Title = "Test 2",
                    Description = "Test  2",
                    Type = Enums.ProjectType.Customer,
                    CreatedAt = DateTimeOffset.Now.AddDays(-5),
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

        public IEnumerable<Project> GetAll()
        {
            return _data;
        }

        public Project GetById(int id)
        {
            return _data.SingleOrDefault(x => x.Id == id);
        }
    }
}
