using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            Car carOne = new Car() {Year = 2024, Make = "Lexus", Model = "Sliver", IsDriveable = "yes", EngineNoise = "No", HonkNoise = "Not too loud"} ;
            Car carTwo = new Car() { Year = 2013, Make = "BMW", Model = "Super", IsDriveable = "No", EngineNoise = "No", HonkNoise = "Super loud"};
            Car carThree = new Car() { Year = 2001, Make = "Toyata", Model = "High", IsDriveable = "Yes", EngineNoise = "Yes", HonkNoise = "Okay"};
            //Set the properties for each of the cars
            //Call each of the methods for each car
            carOne.MakeEngineNoise();
            carTwo.MakeEngineNoise();
            carThree.MakeEngineNoise();
            
            carOne.MakeHonkNoise();
            carTwo.MakeEngineNoise();
            carThree.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot myCarLot = new CarLot();
            
            myCarLot.AddCar(new Car() {Year = 2023, Model = "Honda", Make = "Civic"});
            myCarLot.AddCar(new Car() {Year = 2019, Model = "Ford", Make = "Mustang"});
            myCarLot.AddCar(new Car() {Year = 2006, Model = "Toyata", Make = "Corolla"});
            
            myCarLot.ListCars();
        }
    }
}
