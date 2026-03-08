using DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;
using DotNet8.Architecture_CleanArchitecture.Utils;
using DotNet8.Architecture_CleanArchitecture.Shared;

namespace DotNet8.Architecture_CleanArchitecture.Infrastructure.Features.Blog;

public class BlogRepository : IBlogRepository
{
	private readonly BlogDbContext _dbContext;

	public BlogRepository(BlogDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<Result<BlogListModelV1>> GetBlogsAsync(int pageNo, int pageSize, CancellationToken cancellationToken)
	{
		Result<BlogListModelV1> result;

		try
		{
			var query = _dbContext.Tbl_Blogs.OrderByDescending(x => x.BlogId);
			var lst = await query
				.Paginate(pageNo, pageSize)
				.ToListAsync(cancellationToken: cancellationToken);

		}
	}
}
