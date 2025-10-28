using DataAccess;
using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.API
{
    [Authorize]
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController(AppDbContext context,
                    UserManager<AppUser> userManager,
                    RoleManager<IdentityRole> roleManager) : Controller
    {

        // GET: api/User
        //[HttpGet]
        //public IActionResult GetUser()
        //{
        //    List<IdentityUser> Items = new List<IdentityUser>();
        //    Items = _context.AspnetUsers.ToList();
        //    int Count = Items.Count();
        //    return Ok(new { Items, Count });
        //}

        //[HttpGet("all")]
        //public IActionResult GetAllUser()
        //{
        //    List<AppUser> Items = new List<AppUser>();
        //    Items = _userManager.Users.ToList();            
        //    return new ObjectResult(Items);
        //}

        //[HttpGet("[action]/{id}")]
        //public IActionResult GetByAppUserId([FromRoute]string id)
        //{
        //    UserProfile userProfile = _context.UserProfiles.SingleOrDefault(x => x.AppUserId.Equals(id));
        //    List<UserProfile> Items = new List<UserProfile>();
        //    if (userProfile != null)
        //    {
        //        Items.Add(userProfile);
        //    }
        //    int Count = Items.Count();
        //    return Ok(new { Items, Count });
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> Insert([FromBody]CrudViewModel<UserProfile> payload)
        //{
        //    UserProfile register = payload.Value;
        //    if (register.Password.Equals(register.ConfirmPassword))
        //    {
        //        AppUser user = new AppUser() { Email = register.Email, UserName = register.Email, EmailConfirmed = true };
        //        var result = await _userManager.CreateAsync(user, register.Password);
        //        if (result.Succeeded)
        //        {
        //            register.Password = user.PasswordHash;
        //            register.ConfirmPassword = user.PasswordHash;
        //            register.AppUserId = user.Id;
        //            _context.UserProfiles.Add(register);
        //            await _context.SaveChangesAsync();
        //        }

        //    }
        //    return Ok(register);
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> Update([FromBody]CrudViewModel<UserProfile> payload)
        //{
        //    UserProfile profile = payload.Value;
        //    _context.UserProfiles.Update(profile);
        //    await _context.SaveChangesAsync();
        //    return Ok(profile);
        //}

        //[HttpPost("[action]")]
        //public async Task<IActionResult> ChangePassword([FromBody]CrudViewModel<UserProfile> payload)
        //{
        //    UserProfile profile = payload.Value;
        //    if (profile.Password.Equals(profile.ConfirmPassword))
        //    {
        //        var user = await _userManager.FindByIdAsync(profile.AppUserId);
        //        var result = await _userManager.ChangePasswordAsync(user, profile.OldPassword, profile.Password);
        //    }
        //    profile = _context.UserProfiles.SingleOrDefault(x => x.AppUserId.Equals(profile.AppUserId));
        //    return Ok(profile);
        //}

        //[HttpPost("[action]")]
        //public IActionResult ChangeRole([FromBody]CrudViewModel<UserProfile> payload)
        //{
        //    UserProfile profile = payload.Value;
        //    return Ok(profile);
        //}

        //[HttpDelete("Delete/{id}")]
        //public async Task<IActionResult> Remove([FromBody]CrudViewModel<UserProfile> payload)
        //{
        //    var userProfile = _context.UserProfiles.SingleOrDefault(x => x.UserProfileId.Equals((int)payload.Key));
        //    if (userProfile != null)
        //    {
        //        var user = _context.Users.Where(x => x.Id.Equals(userProfile.AppUserId)).FirstOrDefault();
        //        var result = await _userManager.DeleteAsync(user);
        //        if (result.Succeeded)
        //        {
        //            _context.Remove(userProfile);
        //            await _context.SaveChangesAsync();
        //        }                
        //    }            
        //    return Ok();
        //}
    }
}