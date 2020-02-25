using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineRealEstateEntity
{
    public class Land
    {
        [Required]
        [Key]
        public int landId { get; set; }
        [Required]
        public string propertyType { get; set; }
        [Required]
        public int area { get; set; }
        [Required]
        public string location { get; set; }
        public ICollection<UserManager> User { get; set; }

    }
}
