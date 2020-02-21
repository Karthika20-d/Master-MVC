using System.ComponentModel.DataAnnotations;
namespace OnlineRealEstateEntity
{
    public enum Location
    {
        Erode,
        Salem,
        Chennai,
        Bangalore,
        Hyderabad
    }
    public class UserManager
    {
        [Required(ErrorMessage ="Please enter your name")]
        [Display(Name ="Username")]
        [RegularExpression(@"^[A-Za-z]+$")]
        [MaxLength(20)]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter your mail")]
        [Display(Name ="Email Address")]
        [EmailAddress(ErrorMessage = "Please enter valid mail")]
        public string email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        [Display(Name ="Phone Number")]
        [RegularExpression(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}",ErrorMessage ="Please enter your number")]
        public long phoneNumber { get; set; }
        [Required(ErrorMessage ="Please enter your password")]
        [Display(Name ="Password")]
        [RegularExpression("^(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?!.*s).*$",ErrorMessage ="Please enter valid password like uppercase,lowecase,symbol and number")]
        [MinLength(8,ErrorMessage ="Password should atleast contain 8 characters")]
        public string password { get; set; }
        [Required]
        [Display(Name ="Role")]
        public string role { get; set; }
        [Required]
        [Display(Name ="Location")]
        public Location location { get; set; }
        
        public UserManager()
        {

        }
    }
   
}
