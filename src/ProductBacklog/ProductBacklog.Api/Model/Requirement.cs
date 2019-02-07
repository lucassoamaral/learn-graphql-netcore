namespace ProductBacklog.Api.Model
{
    public class Requirement : IApiModel
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
