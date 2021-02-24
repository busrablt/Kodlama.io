using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameSaleService
    {
        void Buy(GameProduct gameProduct,Campaign campaign);
    }
}
