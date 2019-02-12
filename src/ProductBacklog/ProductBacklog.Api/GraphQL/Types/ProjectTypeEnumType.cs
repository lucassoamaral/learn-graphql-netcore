using GraphQL.Types;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectTypeEnumType : EnumerationGraphType<Enums.ProjectType>
    {
        public ProjectTypeEnumType()
        {
            Name = "Type";
            Description = "The project type. If it's an internal project or a project for customers";
        }
    }
}
