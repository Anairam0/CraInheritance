using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Car
{
    abstract class Car
    {
        protected bool isSedan;
        protected string seats;

        public Car() { }

        public Car(bool isSedan, string seats)
        {
            this.isSedan = isSedan;
            this.seats = seats;
        }

        public bool getIsSedan()
        {
            return this.isSedan;
        }

        public string getSeats()
        {
            return this.seats;
        }

        abstract public string getMileage();

        public void printCar(string name)
        {
            Console.WriteLine("A {0} is{1} Sedan, is {2}-seater, and has a mileage of around {3}.",
            name,
            this.getIsSedan() ? "" : " not",
            this.getSeats(),
            this.getMileage());
        }
    }

    // Write your code here.

    /**
    *   WagonR class
    **/
    class WagonR : Car
    {
        int carMillage { get; set; }
        public WagonR(int carMillage) : base(false, "4")
        {
            this.carMillage = carMillage;
        }

        public override string getMileage()
        {
            return this.carMillage.ToString() + " kmpl";
        }
    }

    /**
    *   HondaCity class
    **/
    class HondaCity : Car
    {
        int carMillage { get; set; }

        public HondaCity(int carMillage): base (true, "4")
        {
            this.carMillage = carMillage;
        }

        public override string getMileage()
        {
            return this.carMillage.ToString() + " kmpl";
        }
    }
    /**
    *   InnovaCrysta class
    **/
    class InnovaCrysta : Car
    {
        int carMillage { get; set; }

        public InnovaCrysta(int carMillage) : base(false, "6")
        {
            this.carMillage = carMillage;
        }

        public override string getMileage()
        {
            return this.carMillage.ToString() + " kmpl";
        }
    }

    class Solution
    {
        static void Main(string[] args)
        {
            int carType = Convert.ToInt32(Console.ReadLine().Trim());
            int carMileage = Convert.ToInt32(Console.ReadLine().Trim());

            if (carType == 0)
            {
                Car wagonR = new WagonR(carMileage);
                wagonR.printCar("WagonR");
            }

            if (carType == 1)
            {
                Car hondaCity = new HondaCity(carMileage);
                hondaCity.printCar("HondaCity");
            }

            if (carType == 2)
            {
                Car innovaCrysta = new InnovaCrysta(carMileage);
                innovaCrysta.printCar("InnovaCrysta");
            }
        }
    }
}