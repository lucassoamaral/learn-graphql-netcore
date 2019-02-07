using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProductBacklogQuery : ObjectGraphType
    {
        public ProductBacklogQuery(
            IProjectRepository projectsRepository,
            IRequirementRepository requirementsRepository)
        {
            Field<ListGraphType<ProjectType>>(
                "projects",
                resolve: context => projectsRepository.GetAll()
            );

            Field<ListGraphType<RequirementType>>(
                "requirements",
                resolve: context => requirementsRepository.GetAll());
        }
    }
}
