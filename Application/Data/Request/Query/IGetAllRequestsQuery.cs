namespace public_requests.Application.Data.Request.Query
{
    public interface IGetAllRequestsQuery
    {
        IQueryable<Domain.Entities.Request> Get();
    }
}
