using GraphQL.Types;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectInputType : InputObjectGraphType
    {
        public ProjectInputType()
        {
            Name = "projectInput";
            
            Field<NonNullGraphType<StringGraphType>>(nameof(ProjectModel.Title));
            Field<NonNullGraphType<StringGraphType>>(nameof(ProjectModel.Description));
        }
    }
}