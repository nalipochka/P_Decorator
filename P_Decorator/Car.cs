using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Decorator
{
    public abstract class Car
    {
        public string Brand { get; init; } = null!;
        public string Model { get; init; } = null!;
        public string Number { get; init; } = null!;
        public double Price { get; set; }
        public int Distance { get; set; }
        public Car(string brand, string model, string number, double price, int distance)
        {
            Brand = brand;
            Model = model;
            Number = number;
            Price = price;
            Distance = distance;
        }
        public abstract string GetInfo();
    }
    public class BMW : Car
    {
        public BMW() : base("BMW", "M5","AE3465VF" , 2199.90, 1000)
        {
        }

        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand: {Brand} {Model}");
            sb.AppendLine($"Number: {Number}");
            sb.AppendLine($"Price: {Price}");
            sb.AppendLine($"Max. Distance: {Distance}");
            return sb.ToString();
        }
    }
    public class Toyota : Car
    {
        public Toyota() : base("Toyota", "RAV4", "AX2396DW", 1990.90, 1500)
        {
        }
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand: {Brand} {Model}");
            sb.AppendLine($"Number: {Number}");
            sb.AppendLine($"Price: {Price}");
            sb.AppendLine($"Max. Distance: {Distance}");
            return sb.ToString();
        }
    }
    public class KIA : Car
    {
        public KIA() : base("KIA", "Magentis", "AO2934LE", 1340.90, 2000)
        {
        }
        public override string GetInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand: {Brand} {Model}");
            sb.AppendLine($"Number: {Number}");
            sb.AppendLine($"Price: {Price}");
            sb.AppendLine($"Max. Distance: {Distance}");
            return sb.ToString();
        }
    }
}
