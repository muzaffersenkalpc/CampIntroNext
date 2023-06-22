using OOP3;
using System.Collections.Generic;

//IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
//ihtiyacKrediManager.Hesapla();

//OgrenciKrediManager ogrenciKrediManager = new OgrenciKrediManager();
//ogrenciKrediManager.Hesapla();

//IKrediManager konutKrediManager = new KonutKrediManager(); //Interfaceler, o interface i referans alan
//konutKrediManager.Hesapla();                                //classsın yerini tutar.


IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  //Seçenek1 gibi düşün.
IKrediManager ogrenciKrediManager = new OgrenciKrediManager(); //Seçenek2 gibi düşün.
IKrediManager konutKrediManager = new KonutKrediManager(); //Seçenek3 gibi düşün.
ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLogerService = new FileLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(ogrenciKrediManager, new FileLoggerService());

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,ogrenciKrediManager,konutKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
                              
