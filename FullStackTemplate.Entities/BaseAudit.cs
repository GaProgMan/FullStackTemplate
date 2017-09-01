using System;

namespace FullStackTemplate.Entities
{
    /// <summary>
    /// Determines whether an entity will be auditable
    /// (i.e. whether it will have Created, Modified, etc.)
    /// </summary>
    public class BaseAudit
    {
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}