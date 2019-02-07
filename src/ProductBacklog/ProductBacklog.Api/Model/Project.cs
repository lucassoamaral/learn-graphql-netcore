using System.Collections.Generic;

namespace ProductBacklog.Api.Model
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string RepositoryUrl { get; set; }

        public string ProjectUrl { get; set; }

        public Project ParentProject { get; set; }

        public IEnumerable<Project> Subprojects { get; set; }
    }
}
