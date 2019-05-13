using GraphQL;
using GraphQL.Types;
using ProductBacklog.Api.GraphQL.Types;

namespace ProductBacklog.Api.GraphQL
{
    public class ProductBacklogSchema : Schema
    {
        public ProductBacklogSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<ProductBacklogQuery>();
            Mutation = resolver.Resolve<ProductBacklogMutation>();
            Subscription = resolver.Resolve<ProjectSubscription>();
        }
    }
}
