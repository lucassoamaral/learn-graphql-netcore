using ProductBacklog.Api.GraphQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IProjectRepository : IRepository<ProjectModel>
    {
        Task<IEnumerable<ProjectModel>> GetSubprojects(int projectId);
    }
}
