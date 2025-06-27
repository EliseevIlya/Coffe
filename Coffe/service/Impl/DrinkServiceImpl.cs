using Coffe.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe.service.Impl
{
    internal class DrinkServiceImpl : IDrinkService
    {
        private readonly IRepository<Drink> _repository;

        public DrinkServiceImpl(IRepository<Drink> repository)
        {
            _repository = repository;
        }

        public void AddDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public void DeleteDrink(Drink drink)
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetAllDrinks()
        {
            throw new NotImplementedException();
        }

        public Drink GetDrink(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateDrink(Drink drink)
        {
            throw new NotImplementedException();
        }
    }
}
