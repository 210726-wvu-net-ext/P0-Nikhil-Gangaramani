using System;
using System.Collections.Generic;

namespace PetManagement
{
    class Program
    {
        // abstract void foobar();
        // virtual void foobar(){

        // }

         static void Main(string[] args)
        {
            AllMeals();
        }
        
        static void AllMeals()
        {
            Pet pet = CreatePet();
            Meal meal1 = CreateMeal("Dry Food");
            Meal meal2 = CreateMeal("Wet Food");
            Meal meal3 = CreateMeal("Raw Food");
            Meal meal4 = CreateMeal("Human Food :(");
            //Console.WriteLine(exampleMeal.foodName);
            //Console.WriteLine(exampleMeal.timeFed);

           // Console.WriteLine(exampleMeal.ToString());

           List<Meal> meals = new List<Meal>(){meal1, meal2, meal3, meal4};
           pet.Meals.AddRange(meals);

           foreach(Meal nom in pet.Meals)
           {
               Console.WriteLine(nom.ToString());
           }
        }

        static Meal CreateMeal(string name)
        {
            return new Meal(name);
        }

        static Pet CreatePet()
        {

            Pet pet1 = new Cat();
            // Pet pet2 = new Pet("Auryn");

           //  assign values to the variables
            // Console.Write("Please enter your pet id: ");
            // pet1.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter your pet's name: ");
            pet1.name = Console.ReadLine();
            Console.Write("\nPlease enter your pet's date of birth as (yyyy/mm/dd): ");
            pet1.dob = Convert.ToDateTime(Console.ReadLine());

            //do
            //{
        
            Console.Write("\nPlease enter your pet Gender: (<Press <1> for female and <0> for male): ");
            string gender = Console.ReadLine();
            if(gender == "0")
                pet1.gender = Gender.Male;
            else if(gender == "1")
                pet1.gender = Gender.Female;
            else
                Console.Write("Incorrect Gender (<Press <1> for female and <0> for male):");
            // pet1.id = 111;
            // pet1.name ="Tolly";
            // pet1.dob = new DateTime(2009, 8, 12);
            // pet1.gender = Gender.Female;
           

            //} while(pet1.gender is null);

            // call the method
            string details = pet1.GetDetails();
            Console.Write(details);
            // Console.Write(pet1.GetDetails());
            // Console.WriteLine();
            // Console.WriteLine(pet2.GetDetails());
            return pet1;

        }
    }
}
