using ProductBacklog.Api.Model;
using System.Collections.Generic;
using System.Linq;

namespace ProductBacklog.Api.Data.Repository
{
    public class RequirementRepository : IRequirementRepository
    {
        private readonly IEnumerable<Requirement> _data = new List<Requirement>
        {
            new Requirement
            {
                Id = 1,
                ShortDescription = "A short requirement 1",
                DetailedDescription = "With some details 1",
                ProjectId = 1
            },
            new Requirement
            {
                Id = 2,
                ShortDescription = "A short requirement 2",
                DetailedDescription = "With some details 2",
                ProjectId = 2
            }
        };

        public IEnumerable<Requirement> GetAll()
        {
            return _data;
        }

        public IEnumerable<Requirement> GetForProject(int projectId)
        {
            return _data.Where(x => x.ProjectId == projectId);
        }

        public Requirement GetById(int id)
        {
            return _data.SingleOrDefault(x => x.Id == id);
        }
    }
}
