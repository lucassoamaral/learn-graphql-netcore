using ProductBacklog.Api.GraphQL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IRepository<TModel>
        where TModel : IApiModel
    {
        Task<IEnumerable<TModel>> GetAll();

        Task<TModel> GetById(int id);

        Task<TModel> Add(TModel model);
    }
}
