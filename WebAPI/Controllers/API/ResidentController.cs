using DataAccess;
using Domain.Models.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contract;

namespace WebAPI.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController(IResidentService _residentService) : Controller
    {
        [AllowAnonymous]
        [HttpGet("all")]
        public async Task<ActionResult> GetAll()
        {
            var result = await _residentService.Get();
            return new ObjectResult(result);
        }


        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Create(ResidentDto dto)
        {
            var result = await _residentService.AddAsync(dto);
            return Ok(result);
        }
    }
}
