using System;
using FullStackTemplate.Facade.ApiFacades;

namespace FullStackTemplate.UI.Api
{
    public class ApiController : BaseApiController
    {
        private readonly IBaseApiFacade _baseApiFacade;

        public ApiController(IBaseApiFacade baseApiFacade)
        {
            _baseApiFacade = baseApiFacade;
        }

        public string Index()
        {
            return _baseApiFacade.ApiUseageString();
        }
    }
}