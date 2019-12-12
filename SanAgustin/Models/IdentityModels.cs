using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using SanAgustin.Models;

namespace SanAgustin.Models
{
    public class ApplicationUser : IdentityUser
    {
        private DataClasses1DataContext contexto = new DataClasses1DataContext();
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }

        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [StringLength(13, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 13)]
        public string Cedula { get; set; }

    }

}
public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext()
        : base("DefaultConnection", throwIfV1Schema: false)
    {
        var objectContext = (this as IObjectContextAdapter).ObjectContext;
        objectContext.CommandTimeout = 5600;
    }

    public static ApplicationDbContext Create()
    {
        return new ApplicationDbContext();
    }

    public System.Data.Entity.DbSet<SanAgustin.Models.Bautizos> Bautizos { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.InfAdicional> InfAdicional { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Personal> Personal { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.PrimeraComunion> PrimeraComunion { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Sacramentos> Sacramentos { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Bodas> Bodas { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Cargos> Cargos { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Comunidades> Comunidades { get; set; }
    public System.Data.Entity.DbSet<SanAgustin.Models.Confirmacion> Confirmacion { get; set; }

    // // public class EclesialDbContext : DbContext
    // //{
    // //public DbSet<Bautizo> Bautizos { get; set; }
    // //public DbSet<InfAdicional> InfAdicionals { get; set; }
    // //public DbSet<PersonalSA> PersonalSAs { get; set; }
    // //public DbSet<PrimeraComunion> PrimeraComunions { get; set; }
    // //public DbSet<Sacramento> Sacramentos { get; set; }
    // //public DbSet<sysdiagram> sysdiagrams { get; set; }
    // //public DbSet<Boda> Bodas { get; set; }
    // //public DbSet<Cargo> Cargos { get; set; }
    // //public DbSet<Comunidade> Comunidades { get; set; }
    // //public DbSet<Confirmacion> Confirmacions { get; set; }
    // //public DbSet<Sacramentos_SanAgustin> Sacramentos_SanAgustins { get; set; }
    // //}
}
