using Microsoft.AspNetCore.Identity;

namespace ko.entity_framework.entities
{
    public class ApplicationUser : IdentityUser
    {

    }

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
