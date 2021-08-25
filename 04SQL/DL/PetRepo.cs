using Models;
using System.Collections.Generic;
using System.Linq;


namespace DL
{
    public class PetRepo : IPetRepo
    {
        // private petdbContext _context;

        // public PetRepo(petdbContext context)
        // {
           // _context = context;
        //}
        public List<Models.Cat> GetAllCats(){
           return new List<Models.Cat>();
        }
    }
}