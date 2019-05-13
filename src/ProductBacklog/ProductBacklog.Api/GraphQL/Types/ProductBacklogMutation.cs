using GraphQL.Types;
using ProductBacklog.Api.Data.Repository;
using ProductBacklog.Api.GraphQL.Messaging;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProductBacklogMutation : ObjectGraphType
    {
        public ProductBacklogMutation(
            IProjectRepository projectsRepository,
            ProjectMessageService messageService
        )
        {
            FieldAsync<ProjectType>(
                "createProject",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProjectInputType>> { Name = "project" }
                ),
                resolve: async context => 
                {
                    var project = context.GetArgument<ProjectModel>("project");
                    await context.TryAsyncResolve(
                        async c => await projectsRepository.Add(project)
                    );

                    messageService.AddProjectAddedMessage(project);
                    return project;
                }
            );
        }        
    }
}