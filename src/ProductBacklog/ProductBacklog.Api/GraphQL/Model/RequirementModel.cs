namespace ProductBacklog.Api.GraphQL.Model
{
    public class RequirementModel : IApiModel
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public int ProjectId { get; set; }

        public ProjectModel Project { get; set; }
    }
}
