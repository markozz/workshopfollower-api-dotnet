using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Provider.Exceptions;
using Provider.Services;

namespace Provider.Controllers
{
    [Route("api/[controller]")]
    public class WorkshopFollowersController: Controller
    {
        private IConfiguration _Configuration { get; }
        private IWorkshopFollowersService _WorkshopFollowersService;
        public WorkshopFollowersController(IConfiguration configuration, IWorkshopFollowersService service)
        {
            this._Configuration = configuration;
            this._WorkshopFollowersService = service;
        }

        [HttpPost]
        public IActionResult SaveWorkshopFollower([FromBody] WorkshopFollower workshopFollower)
        {
            IActionResult response;
            try
            {
                Guid id = this._WorkshopFollowersService.SaveWorkshopFollower(workshopFollower);
                response = Ok(id);
            } 
            catch(Exception e)
            {
                Console.Write(e.Message);
                response = BadRequest();
            }
            return response;
        }

        [HttpGet]
        [Route("{id}")]        
        public IActionResult GetWorkshopFollowers(String id)
        {
            IActionResult response;
            try
            {
                Guid guid = Guid.Parse(id);
                WorkshopFollower found = this._WorkshopFollowersService.GetWorkshopFollower(guid);
                response = Ok(found);
            }
            catch(WorkshopFollowersException e)
            {
                Console.Write(e.Message);
                response = NotFound();
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
                response = StatusCode(500);
            }
            return response;
        }
    }
}