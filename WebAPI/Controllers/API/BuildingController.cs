using DataAccess;
using Domain.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace WebAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController(IBuildingService _buildingService) : Controller
    {
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _buildingService.Get();
            return new ObjectResult(result);
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Create(BuildingDto buildingDto)
        {
            var result = await _buildingService.AddAsync(buildingDto);
            return Ok(result);
        }
    }
}
