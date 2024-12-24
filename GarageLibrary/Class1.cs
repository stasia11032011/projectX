using System;
using System.Collections.Generic;

namespace GarageLibrary
{
    // Класс Car - Автомобиль (Автор: [Ваша Фамилия])
    public class Car
    {
        public string Owner { get; set; }
        public string Number { get; set; }

        public Car(string owner, string number)
        {
            Owner = owner;
            Number = number;
        }

        public void Show()
        {
            Console.WriteLine($"Владелец: {Owner}, Гос.номер: {Number}");
        }
    }
}

namespace GarageLibrary
{
    // Класс Garage - Гараж (Автор: Бережной Кирилл)
    public class Garage
    {
        public string Address { get; set; }
        public List<Car> Cars { get; set; }

        public Garage(string address)
        {
            Address = address;
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void ShowAll()
        {
            if (Cars.Count == 0)
            {
                Console.WriteLine("В гараже нет автомобилей.");
                return;
            }
            Console.WriteLine($"Гараж по адресу: {Address}");
            foreach (var car in Cars)
            {
                car.Show();
            }

        }
        public void ShowAll(Comparison<Car> comparison)
        {
            if (Cars.Count == 0)
            {
                Console.WriteLine("В гараже нет автомобилей.");
                return;
            }
            Console.WriteLine($"Гараж по адресу: {Address}");
            Cars.Sort(comparison);
            foreach (var car in Cars)
            {
                car.Show();
            }

        }
    }
}