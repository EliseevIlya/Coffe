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
            _repository.Add(drink);
        }

        public void DeleteDrink(Drink drink)
        {
            _repository.DeleteById(drink.Id);
        }

        public List<Drink> GetAllDrinks()
        {
            return _repository.GetAll();
        }

        public Drink? GetDrinkById(int id)
        {
            return _repository.GetById(id);
        }

        public void UpdateDrink(Drink updatedDrink)
        {
            var existingDrink = _repository.GetById(updatedDrink.Id);
            if (existingDrink == null)
            {
                Console.WriteLine("Drink not found");
                return;
            }
            existingDrink.Name = updatedDrink.Name;
            existingDrink.Price = updatedDrink.Price;

        }
    }
}
