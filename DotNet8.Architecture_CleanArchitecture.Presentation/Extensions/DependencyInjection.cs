using DotNet8.Architecture_CleanArchitecture.Domain.Features.Blog;
using DotNet8.Architecture_CleanArchitecture.Infrastructure.Features.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Architecture_CleanArchitecture.Presentation.Extensions;

public static class DependencyInjection
{

	#region AddDependencyInjection

	public static IServiceCollection AddDependencyInjection(this IServiceCollection services, WebApplicationBuilder builder)
	{
		return services.AddDbContextService(builder).AddRepositoryService();
	}

	#endregion

	private static IServiceCollection AddDbContextService(this IServiceCollection services, WebApplicationBuilder builder)
	{
		builder.Services.AddDbContext<BlogDbContext>(
			opt =>
			{
				opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
				opt.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
			},
			ServiceLifetime.Transient,
			ServiceLifetime.Transient
		);

		return services;
	}

	private static IServiceCollection AddRepositoryService(this IServiceCollection services)
	{
		return services.AddScoped<IBlogRepository, BlogRepository>();
	}

}
