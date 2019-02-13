using ProductBacklog.Api.GraphQL.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IRequirementRepository : IRepository<RequirementModel>
    {
        Task<ILookup<int, RequirementModel>> GetForProjects(IEnumerable<int> projectIds);
    }
}
