
namespace public_requests.Application.Data.Request.Command
{
    public interface ICreateRequestCommand
    {
        Domain.Entities.Request Create(Domain.Entities.Request request);
    }
}
