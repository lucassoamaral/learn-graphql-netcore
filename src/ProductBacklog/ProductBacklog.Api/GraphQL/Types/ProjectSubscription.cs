using GraphQL.Resolvers;
using GraphQL.Types;
using ProductBacklog.Api.GraphQL.Messaging;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectSubscription : ObjectGraphType
    {
        public ProjectSubscription(ProjectMessageService messageService)
        {
            Name = "Subscription";
            AddField(new EventStreamFieldType
            {
                Name = "projectAdded",
                Type = typeof(ProjectAddedMessageType),
                Resolver = new FuncFieldResolver<ProjectAddedMessage>(c =>
                    c.Source as ProjectAddedMessage),
                Subscriber = new EventStreamResolver<ProjectAddedMessage>(c => 
                    messageService.GetMessages())
            });
        }
        
    }
}