using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Campaign:IEntity
    {
        public string CampaignType { get; set; }
        public string CampaignName { get; set; }
    }
}
