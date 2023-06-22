using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1996 && gamer.FirstName == "Muzaffer" && gamer.LastName == "Senkal" && gamer.IdentityNumber ==12345)
            {
                //Mernis validation system...
                //..
                //..

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
