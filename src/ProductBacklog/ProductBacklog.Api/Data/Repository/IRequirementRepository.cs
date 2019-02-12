using ProductBacklog.Api.GraphQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IRequirementRepository : IRepository<RequirementModel>
    {
        Task<IEnumerable<RequirementModel>> GetForProject(int projectId);
    }
}
