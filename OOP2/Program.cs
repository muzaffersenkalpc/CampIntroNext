// See https://aka.ms/new-console-template for more information


using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.CustomerNumber = "12345";
customer1.Name = "Muzo";
customer1.Surname = "senkal";
customer1.TcNo = "322323523";


CoorporateCustomer customer2 = new CoorporateCustomer();

customer2.Id = 2;
customer2.CustomerNumber = "325235";
customer2.CompanyName = "Udemy";
customer2.VergiNo = "3242332";


Customer customer3 = new IndividualCustomer();
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);


//Gerçek Müşteri - Tüzel Müşteri.
