using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<ProjectModel>
    {
        public ProjectType(IRequirementRepository requirementRepository, IProjectRepository projectRepository)
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Description);
            Field(x => x.RepositoryUrl);
            Field(x => x.ProjectUrl);
            Field(x => x.CreatedAt);
            Field<ProjectTypeEnumType>(nameof(ProjectModel.Type));

            Field<ProjectType>(
                nameof(ProjectModel.ParentProject),
                resolve: context => context.Source.ParentProjectId.HasValue ? projectRepository.GetById(context.Source.ParentProjectId.Value) : null);

            Field<ListGraphType<ProjectType>>(
                nameof(ProjectModel.Subprojects),
                resolve: context => projectRepository.GetSubprojects(context.Source.Id));

            Field<ListGraphType<RequirementType>>(
                nameof(ProjectModel.Requirements),
                resolve: context => requirementRepository.GetForProject(context.Source.Id));
        }
    }
}
