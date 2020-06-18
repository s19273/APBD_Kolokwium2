using Kolokwium2_s19273.DTO.Reponse;
using Kolokwium2_s19273.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium2_s19273.DAL
{
    public class SQLServerDbService : IDbService
    {
        private readonly ZawodyDbContext _context;

        public SQLServerDbService(ZawodyDbContext context)
        {
            _context = context;
        }

        public GetTeamResp GetTeams(int championshipId)
        {
            var teamsInGivenChampionship = _context.Championship_Team
                .Where(x => x.IdChampionship.Equals(championshipId))
                .OrderByDescending(x => x.Score)
                .ToList();

            Dictionary<string, float> teamResults = new Dictionary<string, float>();
            foreach (var team in teamsInGivenChampionship)
            {
                teamResults.Add(
                    _context.Teams.Single(x => x.IdTeam.Equals(team.IdTeam)).TeamName,
                    team.Score
                );
            }

            return new GetTeamResp
            {
                IdChampionship = championshipId,
                TeamScore = teamResults
            };
        }
    }
}
