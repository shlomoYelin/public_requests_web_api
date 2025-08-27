using public_requests.Application.Requests.Models;

namespace public_requests.Application.Requests.Validators.Interfaces
{
    public interface ICreateNewRequestValidator
    {
        string Validate(CreateNewRequestModel model);
    }
}
