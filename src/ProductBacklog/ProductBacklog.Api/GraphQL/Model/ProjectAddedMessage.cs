namespace ProductBacklog.Api.GraphQL.Model
{
    public class ProjectAddedMessage
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}