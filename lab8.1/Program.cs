using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;

public class Test
{

    public class DeliverySystem
    {

        public string name;
        public string surname;
        public string adress;
        public double weight;
        public int telephone;


        public DeliverySystem()
        {
            this.name = "none";
            this.surname = "none";
            this.adress = "none";
            this.weight = 0;
            this.telephone = 0;
        }

        public DeliverySystem(string name, string surname, string adress, double weight, int telephone)
        {
            this.name = name;
            this.surname = surname;
            this.adress = adress;
            this.weight = weight;
            this.telephone = telephone;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSurname(string surname)
        {
            this.surname = surname;
        }

        public string getSurname()
        {
            return this.surname;
        }

        public void setAdress(string adress)
        {
            this.adress = adress;
        }

        public string getAdress()
        {
            return this.adress;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public double getMath()
        {
            return this.weight;
        }

        public void setTelephone(int telephone)
        {
            this.telephone = telephone;
        }

        public int getTelephone()
        {
            return this.telephone;
        }

        public void setParam()
        {
            this.name = "none";
            this.surname = "none";
            this.adress = "none";
            this.weight = 0;
            this.telephone = 0;
        }

        public void info()
        {

            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Surname: " + this.surname);
            Console.WriteLine("Adress: " + this.adress);
            Console.WriteLine("Weight: " + this.weight);
            Console.WriteLine("Telephone: " + this.telephone);
            Console.WriteLine("-------------------");

        }


    }

    public class Lists
    {

        public int length;
        public List<DeliverySystem> ds = new List<DeliverySystem>();

        public Lists()
        {
            this.length = 3;
            std();
        }

        public Lists(int length)
        {
            this.length = length;
            std();
        }

        public void std()
        {

            for (int i = 0; i < this.length; i++)
            {
                ds.Add(new DeliverySystem("none", "none", "none", 0, 0));
            }

        }

        public void print()
        {

            foreach (DeliverySystem x in ds) x.info();

        }

        public void sort()
        {

            Console.WriteLine("Press - n - if you whant sort DeliverySystem by the Name.");
            Console.WriteLine("Press - s - if you whant sort DeliverySystem by the Surname.");
            Console.WriteLine("Press - a - if you whant sort DeliverySystem by the Adress.");
            Console.WriteLine("Press - w - if you whant sort DeliverySystem by the Weight.");
            Console.WriteLine("Press - t - if you whant sort DeliverySystem by the Telephone.");
            string x = Console.ReadLine();
            const string s = "You enter wrong date!";

            switch (x)
            {
                case "n":
                    sortName();
                    break;
                case "s":
                    sortSurname();
                    break;
                case "a":
                    sortAdress();
                    break;
                case "w":
                    sortWeight();
                    break;
                case "t":
                    sortTelephone();
                    break;
                default:
                    Console.WriteLine("You enter wrong date!");
                    break;
                    throw new ArgumentException(s);
            }

        }

        public void sortName()
        {

            var ds0 = ds.OrderBy(a => a.name);

            foreach (DeliverySystem x in ds0) x.info();

        }

        public void sortSurname()
        {

            var ds0 = ds.OrderBy(a => a.surname);

            foreach (DeliverySystem x in ds0) x.info();

        }

        public void sortAdress()
        {

            var ds0 = ds.OrderBy(a => a.adress);

            foreach (DeliverySystem x in ds0) x.info();

        }

        public void sortWeight()
        {

            var ds0 = ds.OrderBy(a => a.weight);

            foreach (DeliverySystem x in ds0) x.info();

        }

        public void sortTelephone()
        {

            var ds0 = ds.OrderBy(a => a.telephone);

            foreach (DeliverySystem x in ds0) x.info();

        }

        public void add()
        {

            string name;
            string surname;
            string adress;
            double weight;
            int telephone;

            Console.WriteLine("Add new DeliverySystem:");

            Console.WriteLine("Add new name:");
            name = Console.ReadLine();

            Console.WriteLine("Add new surname:");
            surname = Console.ReadLine();

            Console.WriteLine("Add new adress:");
            adress = Console.ReadLine();

            Console.WriteLine("Add new weight:");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Add new telephone:");
            telephone = Int32.Parse(Console.ReadLine());

            ds.Add(new DeliverySystem(name, surname, adress, weight, telephone));

        }

        public void edit()
        {

            string name;
            string surname;
            string adress;
            double weight;
            int telephone;

            Console.WriteLine("Edit DeliverySystem:");

            Console.WriteLine("Find elemen that you whant Edit adn remove it. Then add new corect element:");

            remove();

            Console.WriteLine("Edit name:");
            name = Console.ReadLine();

            Console.WriteLine("Edit surname:");
            surname = Console.ReadLine();

            Console.WriteLine("Edit adress:");
            adress = Console.ReadLine();

            Console.WriteLine("Edit weight:");
            weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Edit telephone:");
            telephone = Int32.Parse(Console.ReadLine());

            ds.Add(new DeliverySystem(name, surname, adress, weight, telephone));
        }

        public void remove()
        {

            Console.WriteLine("Remove DeliverySystem, insert index:");
            int a = 0;
            foreach (DeliverySystem x in ds)
            {
                Console.WriteLine("Index: " + a);
                x.info();
                a++;
            }

            ds.RemoveAt(Int32.Parse(Console.ReadLine()));


        }

    }


    public static void Main()
    {

        Lists lists1 = new Lists();

        Console.WriteLine("Press - a - if you whant add DeliverySystem.");
        Console.WriteLine("Press - r - if you whant remove DeliverySystem.");
        Console.WriteLine("Press - e - if you whant edit DeliverySystem.");
        Console.WriteLine("Press - s - if you whant sort DeliverySystem.");
        Console.WriteLine("Press - x - if you whant exit.");

        string x = Console.ReadLine();

        switch (x)
        {
            case "a":
                lists1.add();
                break;
            case "r":
                lists1.remove();
                break;
            case "e":
                lists1.edit();
                break;
            case "s":
                lists1.sort();
                break;
            case "x":
                Console.WriteLine("Exit.");
                break;
            default:
                Console.WriteLine("You enter wrong method!");
                break;
        }


        lists1.print();

    }
}