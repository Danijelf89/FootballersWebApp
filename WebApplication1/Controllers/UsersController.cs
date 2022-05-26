using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("auth")]
    public class UsersController : Controller
    {

        private DataContext context;

        public UsersController(DataContext con)
        {
            if (context == null)
            {
                context = con;
            }
        }

        private DataContext Context
        {
            get
            {
                return context;
            }
            set
            {
                context = value;
            }
        }

        [HttpPost, Route("login")]
        public IActionResult Login([FromBody]Users users)
        {
            if(users == null)
            {
                return BadRequest();
            }

            if (context != null && context.Users != null)
            {
                foreach(Users user in context.Users)
                {
                    if(user.UserName == users.UserName && user.Password == users.Password)
                    {
                        var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                        var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);





                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, user.UserName),
                             new Claim(ClaimTypes.Role, user.Role)
                        };

                        var tokenOptions = new JwtSecurityToken(
                            issuer: "https://localhost:44307",
                            audience: "https://localhost:44307",
                            claims: claims,
                            expires: DateTime.Now.AddMinutes(5),
                            signingCredentials: signingCredentials

                            );

                        var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                        return Ok(new { Token = tokenString , User = user.UserName, Role = user.Role });
                    }
                }
               
            }

            return Unauthorized();
        }
    }
}
