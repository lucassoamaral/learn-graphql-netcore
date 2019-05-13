using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using ProductBacklog.Api.GraphQL.Model;

namespace ProductBacklog.Api.GraphQL.Messaging
{
    public class ProjectMessageService
    {
        private readonly ISubject<ProjectAddedMessage> _projectStream =
            new ReplaySubject<ProjectAddedMessage>(1);

        public ProjectAddedMessage AddProjectAddedMessage(ProjectModel project)
        {
            var projectAdded = new ProjectAddedMessage
            {
                ProjectId = project.Id,
                Title = project.Title,
                Description = project.Description
            };

            _projectStream.OnNext(projectAdded);
            return projectAdded;
        }

        public IObservable<ProjectAddedMessage> GetMessages()
        {
            return _projectStream.AsObservable();
        }
    }
}