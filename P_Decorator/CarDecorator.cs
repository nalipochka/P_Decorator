using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    public abstract class CarDecorator : Car
    {
        protected Car car;
        protected CarDecorator(string brand, string model, string number, double price, int distance, Car car)
            : base(brand, model, number, price, distance)
        {
            this.car = car;
        }
    }
    public class Discount : CarDecorator
    {
        int discount;
        public Discount(Car c, int discount) : base(c.Brand, c.Model, c.Number, c.Price, c.Distance, c) 
        {
            this.discount = discount;
            car.Price -= (car.Price * ((double)discount / 100));
            car.Distance += discount * 10;
        }
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder(car.GetInfo());
            sb.AppendLine($"Discount: {discount}%");
            return sb.ToString();
        }
    }
    public class Person : CarDecorator
    {
        string name, surname, series;
        public Person(Car car, string name, string surname, string series) : base(car.Brand, car.Model, car.Number, car.Price, car.Distance, car)
        {
            this.name = name;
            this.surname = surname;
            this.series = series;
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder(car.GetInfo());
            sb.AppendLine($"Fullname: {name} {surname}");
            sb.AppendLine($"Passport series: {series}");
            return sb.ToString();
        }
    }
}
