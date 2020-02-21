using OnlineRealEstateEntity;
using OnlineRealEstateRepositary;

namespace OnlineRealEstateBL
{
    public class UserBL
    {
        public static int SignUp(UserManager userManager)
        {
            return UserRepositary.SignUp(userManager);
        }
        
    }
}



