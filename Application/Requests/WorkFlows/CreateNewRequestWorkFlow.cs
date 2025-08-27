using public_requests.Application.Requests.Models;
using public_requests.Application.Requests.Validators.Interfaces;
using public_requests.Application.Requests.WorkFlows.Interfaces;
using public_requests.Application.Requests.WorkFlows.Tasks.Interfaces;
using public_requests.Domain.Dtos;
using public_requests.Domain.Models;

namespace public_requests.Application.Requests.WorkFlows
{
    public class CreateNewRequestWorkFlow : ICreateNewRequestWorkFlow
    {
        private readonly ILogger<CreateNewRequestWorkFlow> _logger;
        private readonly ICreateNewRequestValidator _createNewRequestValidator;
        private readonly ICreateRequestTask _createRequestTask;
        public CreateNewRequestWorkFlow(ILogger<CreateNewRequestWorkFlow> logger, ICreateNewRequestValidator createNewRequestValidator, ICreateRequestTask createRequestTask)
        {
            _logger = logger;
            _createNewRequestValidator = createNewRequestValidator;
            _createRequestTask = createRequestTask;
        }

        public ResultModel<RequestDto> Create(CreateNewRequestModel model)
        {
            try
            {
                var error = _createNewRequestValidator.Validate(model);

                if (string.IsNullOrEmpty(error) == false)
                    return new() { Succese = false, ErrorMessage = error };

                var result = _createRequestTask.Create(model);

                return new() { Succese = true, Model = result };
            }
            catch (Exception ex)
            {
                _logger.LogError($"{ex.StackTrace} - {ex.Message}");
                return new() { Succese = false, ErrorMessage = "ארעה שגיאה לא צפויה  יש לפנות למנהל המערכת" };
            }
        }
    }
}
