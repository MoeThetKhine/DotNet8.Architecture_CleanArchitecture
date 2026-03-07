namespace DotNet8.Architecture_CleanArchitecture.Application.Features.Blog.GetBlogList;

#region GetBlogListQuery

public class GetBlogListQuery : IRequest<Result<BlogListModelV1>>
{
	public int pageNo { get; set; }
	public int pageSize { get; set; }

	public GetBlogListQuery(int pageNo, int pageSize)
	{
		this.pageNo = pageNo;
		this.pageSize = pageSize;
	}
}

#endregion
