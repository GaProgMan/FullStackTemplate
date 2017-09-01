using System;
using FullStackTemplate.DAL;

namespace FullStackTemplate.Facade.ApiFacades
{
    public class BaseApiFacade : IBaseApiFacade
    {
        private readonly IDatabaseService _databaseService;

        public BaseApiFacade(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        public string ApiUseageString()
        {
            var sb = new System.Text.StringBuilder();
            sb.Append($"Incorrect useage of API{Environment.NewLine}");

            sb.Append($"The following functions are available for Entities:{Environment.NewLine}");
            
            // TODO add api method descriptions
            
            return sb.ToString();
        }

        public bool DropData()
        {
            return _databaseService.ClearDatabase();
        }

        public int SeedData()
        {
            return _databaseService.SeedDatabase();
        }
    }
}