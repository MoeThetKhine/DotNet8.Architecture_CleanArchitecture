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

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer("Server=.;Database=DotNetTrainingBatch5;User Id=sa;Password=sasa@123;TrustServerCertificate=True;");


}
