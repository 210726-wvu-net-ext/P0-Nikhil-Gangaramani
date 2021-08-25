using System;
    
namespace Lib
{
    public enum FoodType
    {
        WetFood,
        DryFood,
        RawFood
        
    }
    public class Meal
    {
        // public Meal() 
        // {
        //     this.timeFed = DateTime.Now;
        // }
        
        // public Meal(string foodName) : this()
        // {
        //     this.foodName = foodName;
        // }

         public Meal(DateTime Time) //: this()
        {
            this.Time = Time;
        }

        // public string foodName{get; set;}

        public FoodType FoodType { get; set; }

        // public DateTime timeFed{get; set;}

        public DateTime Time { get; set; }

        // public override string ToString()
        // {
        //     return $"Name : {this.foodName} \nTime: {this.timeFed}"; 
        // }

        public override string ToString()
        {
            return $"Name : {this.FoodType} \nTime: {this.Time}"; 
        }
    }
}