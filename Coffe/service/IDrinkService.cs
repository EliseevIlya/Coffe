using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service
{
    internal interface IDrinkService
    {
        void AddDrink(Drink drink);
        void UpdateDrink(Drink updatedDrink);
        void DeleteDrink(Drink drink);
        List<Drink> GetAllDrinks();
        Drink? GetDrinkById(int id);

    }
}
