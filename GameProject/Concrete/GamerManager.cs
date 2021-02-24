using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        MernisServiceAdapter _mernisServiceAdapter;
        public GamerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }

        public void Register(Gamer gamer)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + gamer.LastName + ": registered in the system");
            }
            else
            {
                throw new Exception("Not a valid gamer");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + ": deleted in the system");
        }

        public void Updated(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + ": updated in the system");
        }
    }
}
