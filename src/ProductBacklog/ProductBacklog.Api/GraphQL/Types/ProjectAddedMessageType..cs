using GraphQL.Types;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectAddedMessageType : ObjectGraphType<ProjectAddedMessage>
    {
        public ProjectAddedMessageType()
        {
            Field(x => x.ProjectId);
            Field(x => x.Title);
            Field(x => x.Description);
        }
    }
}