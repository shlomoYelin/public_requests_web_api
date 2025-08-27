using public_requests.Application.Requests.Models;
using public_requests.Application.Requests.Validators.Interfaces;

namespace public_requests.Application.Requests.Validators
{
    public class CreateNewRequestValidator : ICreateNewRequestValidator
    {
        public string Validate(CreateNewRequestModel model)
        {

            return string.Empty;
        }
    }
}
