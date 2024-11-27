using EvSumativa4.Models;

namespace EvSumativa4.Data
{
    public static class Seeder
    {
        public static void Seed(UserDbContext context)
        {
            if(!context.Users.Any())
            {
                var initialUsers = new List<Usuario>
                {
                    new Usuario {Id=Guid.NewGuid(),Nombre="Aangamio",Apellidos="Aantegamio",Correo="aanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Bangamio",Apellidos="Bantegamio",Correo="banagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Cangamio",Apellidos="Cantegamio",Correo="canagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Dangamio",Apellidos="Dantegamio",Correo="danagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Eangamio",Apellidos="Eantegamio",Correo="eanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Fangamio",Apellidos="Fantegamio",Correo="fanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Gangamio",Apellidos="Gantegamio",Correo="ganagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Hangamio",Apellidos="Hantegamio",Correo="hanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Iangamio",Apellidos="Iantegamio",Correo="ianagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Jangamio",Apellidos="Jantegamio",Correo="janagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Kangamio",Apellidos="Kantegamio",Correo="kanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Langamio",Apellidos="Lantegamio",Correo="lanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Mangamio",Apellidos="Mantegamio",Correo="managamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Nangamio",Apellidos="Nantegamio",Correo="nanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Ñangamio",Apellidos="Ñantegamio",Correo="ñanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Oangamio",Apellidos="Oantegamio",Correo="oanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Pangamio",Apellidos="Pantegamio",Correo="panagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Qangamio",Apellidos="Qantegamio",Correo="qanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Rangamio",Apellidos="Rantegamio",Correo="ranagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Sangamio",Apellidos="Santegamio",Correo="sanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Tangamio",Apellidos="Tantegamio",Correo="tanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Uangamio",Apellidos="Uantegamio",Correo="uanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Vangamio",Apellidos="Vantegamio",Correo="vanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Wangamio",Apellidos="Wantegamio",Correo="wanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Xangamio",Apellidos="Xantegamio",Correo="xanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Yangamio",Apellidos="Yantegamio",Correo="yanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Zangamio",Apellidos="Zantegamio",Correo="zanagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Te maldigo",Apellidos="Perro guano, te maldigo",Correo="angamo@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Huevos",Apellidos="Huevos",Correo="huevos@huevos.com",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Esonoesqueso",Apellidos="Gromit",Correo="queso@cheese.uk",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Breadgamio",Apellidos="Breadtegamio",Correo="breadgamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("PAN")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="nagamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="agamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="gamio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="amio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="mio@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="io@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="o@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="anagami@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="anagam@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="anaga@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="anag@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="ana@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="an@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="a@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="lopez@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="lolpez@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="loloyd@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="L@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Angamio",Apellidos="Antegamio",Correo="Tartamudos@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")},
                    new Usuario {Id=Guid.NewGuid(),Nombre="Analgésico",Apellidos="Angamos",Correo="angamos@angamos.cl",Contraseña=BCrypt.Net.BCrypt.HashPassword("HUEVO")}
                };
                context.Users.AddRange(initialUsers);
                context.SaveChanges();
            }
        }
    }
}