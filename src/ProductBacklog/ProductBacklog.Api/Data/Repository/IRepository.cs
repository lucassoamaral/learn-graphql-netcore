using ProductBacklog.Api.Model;
using System.Collections.Generic;

namespace ProductBacklog.Api.Data.Repository
{
    public interface IRepository<TModel>
        where TModel : IApiModel
    {
        IEnumerable<TModel> GetAll();

        TModel GetById(int id);
    }
}
