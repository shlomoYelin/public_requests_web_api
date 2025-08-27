using Microsoft.EntityFrameworkCore;
using public_requests.Application.Data.Request.Query;

namespace public_requests.Persistence.Data.Request.Query
{
    public class GetAllRequestsQuery : IGetAllRequestsQuery
    {
        private readonly AppDbContext _appDbContext;

        public GetAllRequestsQuery(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IQueryable<Domain.Entities.Request> Get()
        {
            return _appDbContext.Requests.AsQueryable().AsNoTracking();   
        }
    }
}
