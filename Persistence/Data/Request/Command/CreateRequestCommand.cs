using public_requests.Application.Data.Request.Command;

namespace public_requests.Persistence.Data.Request.Command
{
    public class CreateRequestCommand : ICreateRequestCommand
    {
        private readonly AppDbContext _appDbContext;

        public CreateRequestCommand(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Domain.Entities.Request Create(Domain.Entities.Request request)
        {
            _appDbContext.Requests.Add(request);
            _appDbContext.SaveChanges();
            return request;
        }
    }
}
