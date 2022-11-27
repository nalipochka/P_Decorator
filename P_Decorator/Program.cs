using P_Decorator;


BMW bmw = new BMW();
Console.WriteLine(bmw.GetInfo());

Discount discountBMW = new Discount(bmw, 10);
Console.WriteLine(discountBMW.GetInfo());

Person personBMW = new Person(discountBMW, "Petr", "Petrov", "3423AF231");
Console.WriteLine(personBMW.GetInfo());


Console.WriteLine("-------------------------");

KIA kia = new KIA();
Console.WriteLine(kia.GetInfo());

Discount discountKIA = new Discount(kia, 20);
Console.WriteLine(discountKIA.GetInfo());

Person personKIA = new Person(discountKIA, "Ivan", "Ivanov", "426LO212");
Console.WriteLine(personKIA.GetInfo());

