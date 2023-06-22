using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    //MicroService
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; //constructor --> class içinde başka bir classı newleme.

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Added!");
            }
            else
            {
                Console.WriteLine("Not validate, not Added");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Update");
        }
    }
}
