using System; 
using System.Collections.Generic;
    

namespace Lib
{
    // Interface is a contract which is implemented by classes. Interfaces can have only declaration of 4 types members(properties, methods, indexers, event)

    // Interface memebers should not use public keyword because they are implicitly public and abstract 
    public interface IPet
    {
        int Id { get; set; }

        string Name { get; set; }

        DateTime Dob { get; set; }

        Gender Gender{ get; set; }

        List<Meal> Meals{ get; set; }

        string GetDetails();
    }

    interface IOmnivorous
    {
        List<Meal> Meals { get; set; }

         string GetDetails();
    }
}