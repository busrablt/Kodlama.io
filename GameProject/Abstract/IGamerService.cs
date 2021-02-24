using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGamerService
    {
        void Register(Gamer gamer);
        void Delete(Gamer gamer);
        void Updated(Gamer gamer);
    }
}
