using System.Collections.Generic;
using static ProductBacklog.Api.Model.Enums;

namespace ProductBacklog.Api.Model
{
    public class Project : IApiModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string RepositoryUrl { get; set; }

        public string ProjectUrl { get; set; }

        public ProjectType Type { get; set; }

        public Project ParentProject { get; set; }

        public IEnumerable<Project> Subprojects { get; set; }
    }
}
