using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_s19273.DTO.Reponse
{
    public class GetTeamResp
    {
        public int IdChampionship { get; set; }
        public Dictionary<string, float> TeamScore { get; set; }
    }
}
