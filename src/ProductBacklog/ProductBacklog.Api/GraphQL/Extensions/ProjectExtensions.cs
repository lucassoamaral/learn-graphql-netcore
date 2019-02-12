using ProductBacklog.Api.Data.Entity.Type;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Extensions
{
    public static class ProjectExtensions
    {
        public static ProjectModel ToApiModel(this Project entity) =>
            new ProjectModel
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                RepositoryUrl = entity.RepositoryUrl,
                ProjectUrl = entity.ProjectUrl,
                CreatedAt = entity.CreatedAt,
                Type = entity.Type,
                ParentProjectId = entity.ParentProjectId
            };
    }
}
