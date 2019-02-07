using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class RequirementType : ObjectGraphType<Requirement>
    {
        public RequirementType(IProjectRepository projectRepository)
        {
            Field(x => x.Id);
            Field(x => x.ShortDescription);
            Field(x => x.DetailedDescription);

            Field<ProjectType>(
                nameof(Requirement.Project),
                resolve: context => projectRepository.GetById(context.Source.ProjectId));
        }
    }
}
