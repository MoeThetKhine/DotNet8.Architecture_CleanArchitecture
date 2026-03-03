using Microsoft.EntityFrameworkCore;

namespace DotNet8.Architecture_CleanArchitecture.DbService.Models;

public partial class AppDbContext : DbContext
{
	public AppDbContext()
	{
	}

	public AppDbContext(DbContextOptions<AppDbContext> options)
	   : base(options)
	{
	}

}
