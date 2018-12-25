using System;
/*
 * author: Duvall Pinkney
 * email: Duvall.Pinkney@gmail.com
 * Research several car-pooling websites. Create an app that
calculates your daily driving cost, so that you can estimate how much money could be saved by car
pooling, which also has other advantages such as reducing carbon emissions and reducing traffic
congestion. The app should input the following information and display the user’s cost per day of
driving to work:
a) Total miles driven per day.
b) Cost per gallon of gasoline (in cents).
c) Average miles per gallon.
d) Parking fees per day (in cents).
e) Tolls per day (in cents).
*/

namespace ConsoleApp_Car_pool_savings_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalMilesDrivenPerDay = 0;// in miles
            int costPerGallonOfGasoline = 0;// in cents
            int averageMilesPerGallon = 0;
            int parkingFeesPerDay = 0;// in cents
            int tollsPerDay = 0; // in cents
            int cost = 0;
            int totalCost = 0;


            Console.WriteLine("CAR _POOL SAVING CALCULATOR");
            Console.WriteLine("\n\n\n");

            // user enters the number of miles drivern per day
            Console.WriteLine("Enter number of miles driven per day: ");
            totalMilesDrivenPerDay = Convert.ToInt32(Console.ReadLine());

            // user enters the cost of gasoline per gallon in cents
            Console.WriteLine("Enter the cost of gasoline per gallon in cents: ");
            costPerGallonOfGasoline = Convert.ToInt32(Console.ReadLine());

            // user enters average miles per gallon
            Console.WriteLine("Enter the average miles per gallon: ");
            averageMilesPerGallon = Convert.ToInt32(Console.ReadLine());

            //user enters the parking fees per day
            Console.WriteLine("Enter the parking fees per day in cents: ");
            parkingFeesPerDay = Convert.ToInt32(Console.ReadLine());

            //user enter the tolls per day in cents
            Console.WriteLine("Enter the tolls per day in cents: ");
            tollsPerDay = Convert.ToInt32(Console.ReadLine());

            //calculations
            cost = totalMilesDrivenPerDay * (averageMilesPerGallon * costPerGallonOfGasoline);
            totalCost = cost + parkingFeesPerDay + tollsPerDay;

            Console.WriteLine("\n\nThe total cost for the day is: ", totalCost);



        }
    }
}
