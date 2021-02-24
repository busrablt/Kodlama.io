using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class GameProduct: IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
    }
}
