using System;
using System.Collections.Generic; 

    



namespace Lib
{
    public partial class Pet
    {
        /// <summary>
        /// Explicit Impementation of Interface
        /// </summary>
        /// <returns></returns>
        string IPet.GetDetails(){
            return $" Pet ID:{id}\n Pet name:{name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}\n";
        }

        string IOmnivorous.GetDetails(){
            return $" Pet ID:{id}\n Pet name:{name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}\n";
        }

        /// <summary>
        /// This method takes string input and returns the output as formatted strings
        /// </summary>
        /// <param name=String name></param>
        /// <returns>String - formatted string</returns>

        public string GetDetails(string name){
            return $" Pet ID:{id}\n Pet name:{this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}\n";
        }

         public string GetDetails(int id, string name){
            return $" Pet ID:{this.id=id}\n Pet name:{this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}\n";
        }
        public string GetDetails(int id, string name, Gender gender){
            return $" Pet ID:{this.id=id}\n Pet name:{this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {this.gender=gender}\n";
        }

        // public abstract string GetMeal(Gender Gender);

         public virtual string GetMeal(Gender Gender)
         {
            Meal meal=new Meal(DateTime.Now);
            if(Gender == Gender.Male)
                return $"125 gms of {FoodType.DryFood}";    
            else
                return $"100 gms of {FoodType.DryFood}";               
        }

        // public virtual string GetMeal(Gender Gender)
        //  {
        //      Meal meal = new Meal(DateTime.Now);
        //     if(Gender == Gender.Male)
        //     {
        //         if(TimeConversion.GetTime(meal.Time.ToLongDateString())<12&&TimeConversion.GetTime(meal.Time.ToLongDateString())>5)
        //             return $"125 gms of {FoodType.DryFood}";
        //         else if (TimeConversion.GetTime(meal.Time.ToLongDateString())>=12 && TimeConversion.GetTime(meal.Time.ToLongDateString())<=18)
        //              return $"150 gms of {FoodType.WetFood}";
        //         else 
        //             return $"150 gms of {FoodType.RawFood}";

        //     } 

        //     else 
        //     {
        //         if(TimeConversion.GetTime(meal.Time.ToLongDateString())<12 && TimeConversion.GetTime(meal.Time.ToLongDateString())>5)
        //             return $"100 gms of {FoodType.DryFood}";
        //         else if (TimeConversion.GetTime(meal.Time.ToLongDateString())>=12 && TimeConversion.GetTime(meal.Time.ToLongDateString())<=18)
        //              return $"120 gms of {FoodType.WetFood}";
        //         else 
        //             return $"100 gms of {FoodType.RawFood}";
        //     }         
        // }

        public static IEnumerable<Pet> InitializePet(){
            // List<int> list = new List<int>(){1, 2, 3, 4, 5, 6}; check
            //Console.WriteLine(list.Count()); check
            // list.Add(10); check
            // Stack<int> stack = new Stack<int>(); //check
            // stack.Push(10); //check
            // stack.Pop(10); //check

            // Stack<Pet> pets = new Stack<Pet>();
           
                /* pets.Push(new Pet{Id=100, Name="Snow", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Push(new Pet{Id=101, Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Push(new Pet{Id=102, Name="Baxter", Dob=DateTime.Now, Gender=Gender.Female});
                pets.Push(new Pet{Id=103, Name="Smarty", Dob=DateTime.Now, Gender=Gender.Male}); */

                /* Queue<Pet> pets = new Queue<Pet>();
                pets.Enqueue(new Pet{Id=100, Name="Snow", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Enqueue(new Pet{Id=101, Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Enqueue(new Pet{Id=102, Name="Baxter", Dob=DateTime.Now, Gender=Gender.Female});
                pets.Enqueue(new Pet{Id=103, Name="Smarty", Dob=DateTime.Now, Gender=Gender.Male}); */
                
                List<Pet> pets = new List<Pet>(){
                new Pet{Id=100, Name="Snow", Dob=DateTime.Now, Gender=Gender.Male},
                new Pet{Id=101, Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male},
                new Pet{Id=102, Name="Baxter", Dob=DateTime.Now, Gender=Gender.Female},
                new Pet{Id=103, Name="Smarty", Dob=DateTime.Now, Gender=Gender.Male} 
                }; 
                pets.Add(new Pet{Id=104, Name="Rover", Dob=DateTime.MaxValue, Gender=Gender.Female} );
               
                return pets;
        }
        
        public static IDictionary<int, Pet> InitializePetDictionary(){
             Dictionary<int, Pet> pets = new Dictionary<int, Pet>();
                pets.Add(1, new Pet{Id=100, Name="Snow", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Add(2, new Pet{Id=101, Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
                pets.Add(3, new Pet{Id=102, Name="Baxter", Dob=DateTime.Now, Gender=Gender.Female});
                pets.Add(4, new Pet{Id=103, Name="Smarty", Dob=DateTime.Now, Gender=Gender.Male});
                return pets;
        }
    }
}