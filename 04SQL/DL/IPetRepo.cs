using Models;
using System.Collections.Generic;

namespace DL
{
    public interface IPetRepo
    {
        List<Cat> GetAllCats();
    }
}