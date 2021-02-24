using GameProject.Entities;

using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class MerniceServiceAdapter
    {

        public bool CheckIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId),gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateOfBirthday.Year);




         


        }

    }
}
