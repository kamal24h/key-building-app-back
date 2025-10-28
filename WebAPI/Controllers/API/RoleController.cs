using DataAccess;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.API
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/Role")]
    public class RoleController(AppDbContext context,
                    UserManager<AppUser> userManager,
                    RoleManager<IdentityRole> roleManager) : Controller
    {

        // GET: api/Role
        //[HttpGet]
        //public async Task<IActionResult> GetRole()
        //{
        //    await _roles.GenerateRolesFromPagesAsync();

        //    List<IdentityRole> Items = new List<IdentityRole>();
        //    Items = roleManager.Roles.ToList();
        //    int Count = Items.Count();
        //    return Ok(new { Items, Count });
        //}

        // GET: api/Role
        //[HttpGet("[action]/{id}")]
        //public async Task<IActionResult> GetRoleByAppUserId([FromRoute]string id)
        //{
        //    await _roles.GenerateRolesFromPagesAsync();
        //    var user = await userManager.FindByIdAsync(id);
        //    var roles = roleManager.Roles.ToList();
        //    List<UserRoleViewModel> Items = new List<UserRoleViewModel>();
        //    int count = 1;
        //    foreach (var item in roles)
        //    {
        //        bool isInRole = (await userManager.IsInRoleAsync(user, item.Name)) ? true : false;
        //        Items.Add(new UserRoleViewModel { CounterId = count, AppUserId = id, RoleName = item.Name, IsHaveAccess = isInRole });
        //        count++;
        //    }
            
        //    int Count = Items.Count();
        //    return Ok(new { Items, Count });
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> UpdateUserRole([FromBody]CrudViewModel<UserRoleViewModel> payload)
        //{
        //    UserRoleViewModel userRole = payload.Value;
        //    if (userRole != null)
        //    {
        //        var user = await userManager.FindByIdAsync(userRole.AppUserId);
        //        if (user != null)
        //        {
        //            if (userRole.IsHaveAccess)
        //            {
        //                await userManager.AddToRoleAsync(user, userRole.RoleName);
        //            }
        //            else
        //            {
        //                await userManager.RemoveFromRoleAsync(user, userRole.RoleName);
        //            }
        //        }
        //    }
        //    return Ok(userRole);
        //}

        //[HttpDelete("Delete/{id}")]
        //public async Task<ObjectResult> DeleteAsync(string id)
        //{
        //    var role = await roleManager.FindByIdAsync(id);
        //    if (role != null)
        //    {
        //        var result = await roleManager.DeleteAsync(role);
        //        return new ObjectResult(new { success = true, message = "حذف با موفقیت انجام شد." });
        //    }                
        //    else
        //        return new ObjectResult(new { success = false, message = "حذف انجام نشد و خطا رخ داد." });
        //}        
    }
}