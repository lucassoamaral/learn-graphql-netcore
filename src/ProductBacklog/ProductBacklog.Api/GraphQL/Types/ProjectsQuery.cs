using GraphQL.Types;
using System.Collections;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectsQuery : ObjectGraphType
    {
        public ProjectsQuery(IProjectsRepository projectsRepository)
        {
            Field<ListGraphType<ProjectType>>(
                "projects",
                resolve: context => projectsRepository.GetAll()
            );
        }
    }

    public interface IProjectsRepository
    {
        IEnumerable GetAll();
    }
}
