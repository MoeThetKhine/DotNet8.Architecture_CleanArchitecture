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

	public virtual DbSet<TaskCategory> TaskCategories { get; set; }

	public virtual DbSet<TblBlog> Tbl_Blogs { get; set; }

	public virtual DbSet<ToDoList> ToDoLists { get; set; }



}
