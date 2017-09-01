using Microsoft.AspNetCore.Mvc;
using FullStackTemplate.Facade.ApiFacades;

namespace FullStackTemplate.UI.Api
{
    [Route("/api/[controller]")]
    public class DatabaseController : BaseApiController
    {
        private readonly IDatabaseFacade _databaseFacade;

        public DatabaseController(IDatabaseFacade databaseFacade)
        {
            _databaseFacade = databaseFacade;
        }

        public string Index()
        {
            return "database api controller";
        }

        [HttpGet("SeedDatabase")]
        public JsonResult SeedDatabase()
        {
            var newEntityCount = _databaseFacade.SeedDatabase();
            return MessageResult($"Number of new entities added: {newEntityCount}");
        }

        [HttpGet("ClearDatabase")]
        public JsonResult ClearDatabase()
        {
            var result = _databaseFacade.ClearDatabase();
            return MessageResult("Clear database complete", result);
        }
    }
}