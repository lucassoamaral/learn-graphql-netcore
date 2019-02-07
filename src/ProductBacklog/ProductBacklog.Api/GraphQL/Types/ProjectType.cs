﻿using GraphQL.Types;
using ProductBacklog.Api.Model;

namespace ProductBacklog.Api.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType()
        {
            Field(x => x.Id);
            Field(x => x.Title);
            Field(x => x.Description);
            Field(x => x.RepositoryUrl);
            Field(x => x.ProjectUrl);
            Field(x => x.ParentProject);
            Field(x => x.Subprojects);
        }
    }
}