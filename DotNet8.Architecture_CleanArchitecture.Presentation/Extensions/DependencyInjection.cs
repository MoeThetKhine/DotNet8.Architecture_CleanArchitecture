using DotNet8.Architecture_CleanArchitecture.Infrastructure.Features.Blog;
using Microsoft.EntityFrameworkCore;

namespace DotNet8.Architecture_CleanArchitecture.Presentation.Extensions;

public static class DependencyInjection
{

	public static IServiceCollection AddDependencyInjection(this  IServiceCollection services, WebApplicationBuilder builder)
	{

	}

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

}
