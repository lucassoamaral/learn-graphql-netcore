using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class RequirementType : ObjectGraphType<RequirementModel>
    {
        public RequirementType(IProjectRepository projectRepository)
        {
            Field(x => x.Id);
            Field(x => x.ShortDescription);
            Field(x => x.DetailedDescription);

            Field<ProjectType>(
                nameof(RequirementModel.Project),
                resolve: context => projectRepository.GetById(context.Source.ProjectId));
        }
    }
}
