using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.Model;
using System.Collections;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectsQuery : ObjectGraphType
    {
        public ProjectsQuery(IRepository<Project> projectsRepository)
        {
            Field<ListGraphType<ProjectType>>(
                "projects",
                resolve: context => projectsRepository.GetAll()
            );
        }
    }
}
