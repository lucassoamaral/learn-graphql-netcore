using System;
using System.Collections.Generic;
using static ProductBacklog.Api.GraphQL.Model.Enums;

namespace ProductBacklog.Api.GraphQL.Model
{
    public class ProjectModel : IApiModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string RepositoryUrl { get; set; }

        public string ProjectUrl { get; set; }

        public ProjectType Type { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public int? ParentProjectId { get; set; }

        public ProjectModel ParentProject { get; set; }

        public IEnumerable<ProjectModel> Subprojects { get; set; }

        public IEnumerable<RequirementModel> Requirements { get; set; }
    }
}
