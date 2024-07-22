using System;
using System.Collections.Generic;

namespace CarLotSimulator;

public class CarLot : Car
{
        //It should have at least one property: a List of cars
        public static int numberOfCars = 0;
        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
            numberOfCars++;

        }

        public void ListCars()
        {
            foreach (var car in Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }

    
        }
        //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
        //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    
