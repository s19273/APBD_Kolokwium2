using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2_s19273.DAL;
using Kolokwium2_s19273.DTO.Reponse;
using Kolokwium2_s19273.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2_s19273.Controllers
{
    [ApiController]
    [Route("api")]
    public class ZawodyController : ControllerBase
    {
        private readonly IDbService _service;

        public ZawodyController(IDbService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("championship/{id}/teams")]
        public IActionResult GetTeams(int id)
        {
            
            IActionResult response;
            try
            {
                GetTeamResp teams = _service.GetTeams(id);
                response = Ok(teams);
            }
            catch (Exception e)
            {
                response = BadRequest($"Some other error occurred:\n{e.StackTrace}\n{e.Message}");
            }
            return response;
        }

        [HttpPost]
        [Route("teams/{id}/players")]
        public IActionResult AddPlayerToTeam(int id, AddPlayerReq request)
        {
            
            IActionResult response;
            try
            {
                _service.AddPlayerToTeam(id, request);
                response = Ok();
            }
            catch (Exception e)
            {
                response = BadRequest($"Some other error occurred:\n{e.StackTrace}\n{e.Message}");
            }
            return response;
        }

    }
}