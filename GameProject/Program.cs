// See https://aka.ms/new-console-template for more information


using GameProject;

GamerManager gamerManager = new GamerManager(new UserValidationManager());
gamerManager.Add(new Gamer { BirthYear = 1996, IdentityNumber = 12345, FirstName = "Muzaffer", LastName = "Senkal" });
