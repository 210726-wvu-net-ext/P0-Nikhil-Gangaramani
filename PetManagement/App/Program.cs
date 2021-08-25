using System;
using Lib;
using System.Collections.Generic;
using System.Linq; 


    


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
          // AllMeals();
          // Console.WriteLine("time of the day " + DateTime.Now.TimeOfDay);
          // CreateCat();
          // GetPets();
          // GetPetsFromDictionary();
          
          // var pet = GetPetById(100);
          // Console.WriteLine($"{pet.Id} {pet.Name}");
          // UsingData.CallDatabaseCon();
          // UsingData.Serialize_Xml();
          // UsingData.Deserialize_Xml();
          //UsingData.Serialize_Json();
          //UsingData.DeSerialize_Json();
          
          // DelCatOperations del = new DelCatOperations(UsingData.Serialize_Xml);
           /* del += UsingData.Deserialize_Xml; //multitask delegate // store method in invocation list
            del += UsingData.Serialize_Json;
           // del += UsingData.DeSerialize_Json; */

          

            Action del = new Action(UsingData.Serialize_Xml);
            // Func<int, string, int> del1
            // Predicate<string> del2
            del += UsingData.Deserialize_Xml; //multitask delegate // store method in invocation list
            del += UsingData.Serialize_Json;
            // del += UsingData.DeSerialize_Json; */
           
           // Invocation of delegate
            del.Invoke(); // del();
           //del();


          // Console.ReadKey();
         


        }

       
          
            /* try
            {
                System.Console.WriteLine("Hello Let's see dispose working"); 
            }
            finally
            {
                // connection.Dispose();
                connection=null;
                
            } */
        //}

        static Lib.Pet GetPetById(int id){
            var pets = Pet.InitializePet();
            
            var pet = pets.FirstOrDefault<Pet>(x=>x.Id==id);

            if(pet!=null)
                return pet;
            else
                return null;
        }

        static void GetPets()
        {
             var pets = Lib.Pet.InitializePet(); 
             Console.WriteLine("#   |Pet Name| DOB | Gender");
             foreach (var pet in pets)
             {
              Console.WriteLine($"{pet.Id} {pet.Name} {(pet.Dob).ToShortDateString()} {pet.Gender}");   
             }
        }

        static void GetPetsFromDictionary(){
            var pets = Lib.Pet.InitializePetDictionary();
            foreach (var key in pets.Keys)
            {
                Console.WriteLine($"{key} {pets[key].Id} {pets[key].Name}");
            }
        }
        
         // private static void AllMeals()
        // {
        //     Pet pet = CreatePet();
        //     Meal meal1 = CreateMeal("Dry Food");
        //     Meal meal2 = CreateMeal("Wet Food");
        //     Meal meal3 = CreateMeal("Raw Food");
        //     Meal meal4 = CreateMeal("Human Food :(");
        //     //Console.WriteLine(exampleMeal.foodName);
        //     //Console.WriteLine(exampleMeal.timeFed);

        //     // Console.WriteLine(exampleMeal.ToString());

        //     List<Meal> meals = new List<Meal>() { meal1, meal2, meal3, meal4 };
        //     pet.Meals.AddRange(meals);

        //     foreach (Meal nom in pet.Meals)
        //     {
        //         Console.WriteLine(nom.ToString());
        //     }
        // }

        // static Meal CreateMeal(string name)
        // {
        //     return new Meal(name);
        // }

        static IPet CreatePet()
        {
            IPet pet1 = new Lib.Cat(); //Upcasting
            // Pet pet1 = new Pet();
            // Pet pet2 = new Pet("Auryn");

           //  assign values to the variables
            // Console.Write("Please enter your pet id: ");
            // pet1.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter your pet's name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your pet's date of birth as (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());

            //do
            // {
        
            Console.Write("\nPlease enter your pet Gender: (<Press <1> for female and <0> for male): ");
            string gender = Console.ReadLine();
            if(gender == "0")
                pet1.Gender = Gender.Male;
            else if(gender == "1")
                pet1.Gender = Gender.Female;
            else
                Console.Write("Incorrect Gender (<Press <1> for female and <0> for male):");
            // pet1.id = 111;
            // pet1.name ="Tolly";
            // pet1.dob = new DateTime(2009, 8, 12);
            // pet1.gender = Gender.Female;
           

            // } while(pet1.Gender is null);

            // call the method
            string details = pet1.GetDetails();
            Console.Write(details);
            // Console.Write(pet1.GetDetails());
            // Console.WriteLine();
            // Console.WriteLine(pet2.GetDetails());
            return pet1;

        }
    
        static void CreateCat()
        {
            Lib.Cat pet1 = new Lib.Cat();
            // Pet pet1 = new Pet();
            // Pet pet2 = new Pet("Auryn");

           //  assign values to the variables
            // Console.Write("Please enter your pet id: ");
            // pet1.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nPlease enter your pet's name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your pet's date of birth as (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());

            //while(pet1.Gender is not null);
            // {
        
            Console.Write("\nPlease enter your pet Gender: (<Press <1> for female and <0> for male): ");
            string gender = Console.ReadLine();
            if(gender == "0")
                pet1.Gender = Gender.Male;
            else if(gender == "1")
                pet1.Gender = Gender.Female;
            else
                Console.Write("Incorrect Gender (<Press <1> for female and <0> for male):");
            // pet1.id = 111;
            // pet1.name ="Tolly";
            // pet1.dob = new DateTime(2009, 8, 12);
            // pet1.gender = Gender.Female;
           

           // } 

            // call the method
            Console.WriteLine(pet1.GetDetails(101, pet1.Name));// Calling the overlaod in Pet class
            Console.WriteLine(pet1.GetMeal(pet1.Gender));
            

        }
    }

}
