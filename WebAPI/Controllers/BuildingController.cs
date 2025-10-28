using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController(IBuildingService _buildingService) : Controller
    {
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ObjectResult> GetAll()
        {
            var result = await _buildingService.Get();
            return new ObjectResult(new { data = result });
        }
    }
}
