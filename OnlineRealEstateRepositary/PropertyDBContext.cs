using System.Data.Entity;
using OnlineRealEstateEntity;

namespace OnlineRealEstateRepositary
{
    public class PropertyDBContext:DbContext
    {
        public PropertyDBContext():base("RealEstate")
        {

        }
        public DbSet<UserManager> User { get; set; }
        public DbSet<Land> LandDetails { get; set; }

    }
}
