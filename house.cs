﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment apartment = new SmallApartment();
            Person person = new Person("shiva");
            apartment.door = new House.Door("RED");
            person.house = apartment;
            person.ShowData();
            Console.ReadLine();
        }


        public class House
        {
            public int Area { get; set; }
            public Door door;

            public House(int area = 200)
            {
                Area = area;
            }

            public void ShowData()
            {
                Console.WriteLine($"My area, square feet {Area} m2");
            }

            public Door GetDoor()
            {
                return door;
            }

            public class Door
            {
                public string Color { get; set; }

                public Door(string color = "white")
                {
                    Color = color;
                }

                public void ShowData()
                {
                    Console.WriteLine($"my door, color is {Color}");
                }
            }
        }

        public class SmallApartment : House
        {
            public SmallApartment(int area = 50) : base(area)
            {
            }
        }

        public class Person
        {
            private string name;
            public House house { get; set; }

            public Person(string name)
            {
                this.name = name;
            }

            public void ShowData()
            {
                Console.WriteLine($"A person whose name is {name}");
                Console.WriteLine("Data of house:");
                house.ShowData();
                house.GetDoor().ShowData();
            }

        }
    }
}