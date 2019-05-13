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

            Field<ProjectType>(
                "project",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                {
                    Name = "id"
                }),
                resolve: context => 
                {
                    var id = context.GetArgument<int>("id");
                    return projectsRepository.GetById(id);
                }
            );

            Field<ListGraphType<RequirementType>>(
                "requirements",
                resolve: context => requirementsRepository.GetAll());
        }
    }
}
