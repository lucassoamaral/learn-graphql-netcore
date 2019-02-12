namespace ProductBacklog.Api.Data.Entity.Type
{
    public class Requirement : IEntity
    {
        public int Id { get; set; }

        public string ShortDescription { get; set; }

        public string DetailedDescription { get; set; }

        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
