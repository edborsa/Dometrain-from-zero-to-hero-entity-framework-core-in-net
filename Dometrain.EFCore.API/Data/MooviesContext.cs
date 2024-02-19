using Dometrain.EFCore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Dometrain.EFCore.API.Data;

public class MooviesContext : DbContext
{
    public DbSet<Movie> Movies => Set<Movie>();
}