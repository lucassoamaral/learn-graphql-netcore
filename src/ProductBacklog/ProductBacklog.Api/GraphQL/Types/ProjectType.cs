using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType(IRequirementRepository requirementRepository)
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Description);
            Field(x => x.RepositoryUrl);
            Field(x => x.ProjectUrl);
            Field(x => x.CreatedAt);
            Field<ProjectTypeEnumType>(nameof(Project.Type));
            Field<ProjectType>(nameof(Project.ParentProject));
            Field<ListGraphType<ProjectType>>(nameof(Project.Subprojects));

            Field<ListGraphType<RequirementType>>(
                nameof(Project.Requirements),
                resolve: context => requirementRepository.GetForProject(context.Source.Id));
        }
    }
}
