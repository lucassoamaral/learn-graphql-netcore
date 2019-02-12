using Microsoft.EntityFrameworkCore;
using ProductBacklog.Api.Data.Context;
using ProductBacklog.Api.GraphQL.Extensions;
using ProductBacklog.Api.GraphQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductBacklog.Api.Data.Repository
{
    public class RequirementRepository : IRequirementRepository
    {
        private readonly ProductBacklogContext _context;

        public RequirementRepository(ProductBacklogContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<RequirementModel>>GetAll() =>
            await _context.Requirements.Select(x => x.ToApiModel()).ToListAsync();

        public async Task<IEnumerable<RequirementModel>> GetForProject(int projectId) =>
            await _context.Requirements.Where(x => x.ProjectId == projectId).Select(x => x.ToApiModel()).ToListAsync();

        public async Task<RequirementModel> GetById(int id) =>
            await _context.Requirements.Where(x => x.Id == id).Select(x => x.ToApiModel()).SingleOrDefaultAsync();
    }
}
