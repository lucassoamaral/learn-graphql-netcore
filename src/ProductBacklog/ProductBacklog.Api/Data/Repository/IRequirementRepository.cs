using ProductBacklog.Api.Model;
using System.Collections.Generic;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IRequirementRepository : IRepository<Requirement>
    {
        IEnumerable<Requirement> GetForProject(int projectId);
    }
}
