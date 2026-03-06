using DotNet8.Architecture_CleanArchitecture.Utils;
using DotNet8.Architecture_CleanArchitecture.Utils.Resource;
using MediatR;

namespace DotNet8.Architecture_CleanArchitecture.Application.Features.Blog.GetBlogList;

public class GetBlogListQueryHandler : IRequestHandler<GetBlogListQuery, Result<BlogListModelV1>>
{
	private readonly IBlogRepository _blogRepository;

	public GetBlogListQueryHandler(IBlogRepository blogRepository)
	{
		_blogRepository = blogRepository;
	}

	#region Handle

	public async Task<Result<BlogListModelV1>> Handle(GetBlogListQuery request, CancellationToken cancellationToken)
	{
		Result<BlogListModelV1> result;

		if(request.pageNo <= 0)
		{
			result = Result<BlogListModelV1>.Fail(MessageResource.InvalidPageNo);
			goto result;
		}

		if(request.pageSize <= 0)
		{
			result = Result<BlogListModelV1>.Fail(MessageResource.InvalidPageSize);
			goto result;
		}

		result = await _blogRepository.GetBlogsAsync(request.pageNo,request.pageSize, cancellationToken);
	result:
		return result;

	}

	#endregion

}
