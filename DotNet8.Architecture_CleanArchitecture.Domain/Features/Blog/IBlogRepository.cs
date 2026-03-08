using DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;
using DotNet8.Architecture_CleanArchitecture.Utils;

namespace DotNet8.Architecture_CleanArchitecture.Domain.Features.Blog;

public interface IBlogRepository
{
	Task<Result<BlogListModelV1>> GetBlogsAsync(int pageNo, int page, CancellationToken cancellationToken);
	Task<Result<BlogModel>> GetBlogByIdAsync(int id, CancellationToken cancellationToken);
}
