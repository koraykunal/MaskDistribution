

using Business.Concrete;
using Entities.Concrete;

Person p1 = new Person();
p1.nationalId = 11515241128;
p1.FirstName = "Koray";
p1.LastName = "Kunal";
p1.DateOfBirthYear = 2000;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(p1);