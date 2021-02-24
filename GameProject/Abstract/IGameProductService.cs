using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameProductService
    {
        void AddProduct(GameProduct gameProduct);
        void DeleteProduct(GameProduct gameProduct);
        void Update(GameProduct gameProduct);
    }
}
