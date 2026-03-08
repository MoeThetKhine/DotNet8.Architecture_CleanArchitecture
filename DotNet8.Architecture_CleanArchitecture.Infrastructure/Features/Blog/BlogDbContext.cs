using DotNet8.Architecture_CleanArchitecture.Domain.Features.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Architecture_CleanArchitecture.Infrastructure.Features.Blog;

#region BlogDbContext

public class BlogDbContext : DbContext
{
	public BlogDbContext(DbContextOptions options) : base(options) { }

	public DbSet<Tbl_Blog> Tbl_Blogs { get; set; }
}

#endregion
