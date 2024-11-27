using System.Security.Cryptography.X509Certificates;
using EvSumativa4.Data;
using EvSumativa4.Models;
using EvSumativa4.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace EvSumativa4.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserDbContext _context;
        private readonly IConfiguration _configuration;

        public UserController(UserDbContext context,IConfiguration configuration)
        {
            _context=context;
            _configuration=configuration;
        }

        [Authorize]
        [HttpPost]
        public async Task<ActionResult<Usuario>> CrearUsuario(UserDTO dto)
        {
            var user= new Usuario
            {
                Id= Guid.NewGuid(),
                Nombre=dto.Nombre,
                Apellidos=dto.Apellidos,
                Correo=dto.Contraseña,
                Contraseña=BCrypt.Net.BCrypt.HashPassword(dto.Contraseña)
            };
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Created();
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> LeerUsuario(Guid id)
        {
            var user= await _context.Users.FindAsync(id);
            if(user==null)
            {
                return NotFound();
            }
            return user;
        }

        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> LeerUsuarios([FromQuery] int page,[FromQuery] int pagesize)
        {
            if(page<1||pagesize<1)
            {
                return BadRequest();
            }
            var totalUsers = await _context.Users.CountAsync();
            var totalPages = (int)Math.Ceiling(totalUsers / (double)pagesize);
            if(page>totalPages)
            {
                return BadRequest();
            }
            var users = await _context.Users.Skip((page-1)*pagesize).Take(pagesize).ToListAsync();
            var respuesta = new
            {
                TotalUsers=totalUsers,
                TotalPages=totalPages,
                CurrentPage=page,
                PageSize=pagesize,
                Users=users
            };
            return Ok(respuesta);
        }

        [Authorize]
        [HttpPatch("{id}")]
        public async Task<ActionResult<Usuario>> ActualizarUsuario(Guid id,UserDTO dto)
        {
            var user= await _context.Users.FindAsync(id);
            if(user==null)
            {
                return NotFound();
            }
            if(dto.Nombre!=null)
            {
                user.Nombre=dto.Nombre;
            }
            if(dto.Apellidos!=null)
            {
                user.Apellidos=dto.Apellidos;
            }
            if(dto.Contraseña!=null)
            {
                user.Contraseña=BCrypt.Net.BCrypt.HashPassword(dto.Contraseña);
            }
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> EliminarUsuario(Guid id)
        {
            var user= await _context.Users.FindAsync(id);
            if(user==null||user.EstaEliminado)
            {
                return NotFound();
            }
            user.EstaEliminado=true;
            return NoContent();
        }

        [HttpPost("TokenGet")]
        public string GenerateToken(string correo)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, correo),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: jwtSettings["Issuer"],
                audience: jwtSettings["Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMonths(2),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserLoginDTO request)
        {
            var user= _context.Users.FirstOrDefault(p=> p.Correo==request.Correo);
            if (user!=null)
            {
                if(user.Contraseña==BCrypt.Net.BCrypt.HashPassword(request.Contraseña))
                {
                    var token = GenerateToken(request.Correo);
                return Ok(new { Token = token });
                }
                 return Unauthorized();
            }
            return BadRequest();
        }
    }
}