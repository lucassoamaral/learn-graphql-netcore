using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductBacklog.Api.Data.Context;
using ProductBacklog.Api.GraphQL.Extensions;
using ProductBacklog.Api.GraphQL.Model;


namespace ProductBacklog.Api.Data.Repository
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ProductBacklogContext _context;

        public ProjectRepository(ProductBacklogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<ProjectModel> Add(ProjectModel apiModel)
        {
            _context.Projects.Add(apiModel.ToDbModel());
            await _context.SaveChangesAsync();

            return apiModel;
        }

        public async Task<IEnumerable<ProjectModel>> GetAll() =>
            await _context.Projects
                .Select(x => x.ToApiModel())
                .ToListAsync();

        public async Task<ProjectModel> GetById(int id) =>
            await _context.Projects.Select(x => x.ToApiModel()).SingleOrDefaultAsync(x => x.Id == id);

        public async Task<IEnumerable<ProjectModel>> GetSubprojects(int projectId) =>
            await _context.Projects.Where(x => x.ParentProjectId == projectId).Select(x => x.ToApiModel()).ToListAsync();
    }
}
