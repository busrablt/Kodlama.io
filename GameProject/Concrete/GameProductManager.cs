using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameProductManager : IGameProductService
    {
        public void AddProduct(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.Id+"Game added");
        }

        public void DeleteProduct(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.Id + "Game deleted");
        }

        public void Update(GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.Id + "Game updated");
        }
    }
}
