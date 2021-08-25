using System;
using System.Collections.Generic;
    

namespace Lib
{
    public enum Gender{
        Male = 0,
        Female
    }
    public partial class Pet:IPet, IOmnivorous // Implementing Interface
    {
        // public Pet()
        // {
        //     Console.WriteLine("Empty Constructor has been called");
        //     Random rand = new Random();
        //     this.id = rand.Next();
        //     this.gender = null;
        //     this.Meals = new List<Meal>();
        // }
        
        // public Pet(string name) : this()
        // {
        //     Console.WriteLine("Constructor with name has been called");
        //     this.name = name;  
        //     // Random rand = new Random();
        //     // this.id = rand.Next();
        //     // this.gender = null;
             
        // }
        //Pet pet = new Pet("auryn");

        // 1. Variables
        int id;

        public int Id{
            get => id;

            set => id = value;
            
        }
        string name;

        public String Name{
            get{
                if(!string.IsNullOrEmpty(name))
                    return name;
                else
                    throw new NullReferenceException();
            }
            set{
                name = value;
            }
        }
         DateTime dob;

         public DateTime Dob {
            get{
                return dob;
            } 
            set{
                dob = value;
            } 
         }
         Gender gender;

         public Gender Gender {
            get{
                return gender;
            } 
            set{
                gender = value;
            } 
         }

        List<Meal> meals;

        List<Meal> IPet.Meals {
            get{
                return meals;
            } 
            set{
                meals = value;
            } 
         }

        List<Meal> mealsOmnivorous;
         List<Meal> IOmnivorous.Meals{
            get{
                return mealsOmnivorous;
            } 
            set{
                mealsOmnivorous= value;
            } 
         }
            

        // 2. Methods

        
    }
}
