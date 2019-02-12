using System;
using System.Collections.Generic;
using static ProductBacklog.Api.GraphQL.Model.Enums;

namespace ProductBacklog.Api.Data.Entity.Type
{
    public class Project : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string RepositoryUrl { get; set; }

        public string ProjectUrl { get; set; }

        public ProjectType Type { get; set; }

        public DateTimeOffset CreatedAt { get; set; }

        public int? ParentProjectId { get; set; }

        public Project ParentProject { get; set; }

        public ICollection<Project> Subprojects { get; set; }

        public ICollection<Requirement> Requirements { get; set; }
    }
}
