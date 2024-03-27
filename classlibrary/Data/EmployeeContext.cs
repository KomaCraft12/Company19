using classlibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace classlibrary.Data;

public class EmployeeContext : DbContext
{

    public EmployeeContext()
    {
        
    }
    
    public DbSet<Employee> Employee { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conn = "Server=komacloud.synology.me;User Id=jano;Password=Katica.bogar2002;Database=cegnyilvantartas2";
        optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        
        // MSSQL: optionBuilder.UseSqlServer("Server=(localdb)\MSSQLLocalDB;Database=Cegnyilvantartas2;") 
    }
}