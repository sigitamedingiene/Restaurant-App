using BusinessClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository
{
    public class FoodRepository
    {
        List<Food> SnackList;
        public List<Food> GetSnackList()
        {
            var dataFile = File.ReadAllLines(@"C:\Users\Vartotojas\source\repos\Advanced\Restaurant App\snack.txt")
               .Skip(1)
               .Select(x => x.Split(','))
               .Select(x => new Food(
                   x[0],                                 
                   decimal.Parse(x[1])
               )).ToList();
            SnackList.AddRange(dataFile);
            return SnackList;
        }
    }
}
