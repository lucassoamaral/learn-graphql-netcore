using ProductBacklog.Api.Data.Entity.Type;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Extensions
{
    public static class RequirementExtensions
    {
        public static RequirementModel ToApiModel(this Requirement entity) =>
            new RequirementModel
            {
                Id = entity.Id,
                ShortDescription = entity.ShortDescription,
                DetailedDescription = entity.DetailedDescription,
                ProjectId = entity.ProjectId
            };
    }
}
