using Microsoft.EntityFrameworkCore;
namespace ApiEstudiantes.Models;

public class Conexiones : DbContext{
    public Conexiones(DbContextOptions<Conexiones> options)
        : base(options){
            
        }

    public DbSet<Estudiantes> Estudiantes { get; set; } = null;
}