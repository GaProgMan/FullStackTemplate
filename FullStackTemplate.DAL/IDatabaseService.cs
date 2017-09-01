namespace FullStackTemplate.DAL
{
    public interface IDatabaseService
    {
        /// <summary>
        /// Used to drop all pre-existing data from the database
        /// </summary>
        /// <returns>Indicates the success or failure</returns>
        bool ClearDatabase();

        /// <summary>
        /// Used to insert all seed data into the database
        /// </summary>
        /// <returns></returns>
        int SeedDatabase();

        /// <summary>
        /// Used to get the count of all entities in the database
        /// </summary>
        /// <returns></returns>
        /// <remarks>Fro diagnostic purposes only</remarks>
        int GetEntityCount();
    }
}