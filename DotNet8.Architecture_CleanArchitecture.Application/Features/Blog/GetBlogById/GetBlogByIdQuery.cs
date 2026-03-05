using DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;
using DotNet8.Architecture_CleanArchitecture.Utils;
using MediatR;

namespace DotNet8.Architecture_CleanArchitecture.Application.Features.Blog.GetBlogById;

public class GetBlogByIdQuery : IRequest<Result<BlogModel>>
{
	public int BlogId {  get; set; }	

	public GetBlogByIdQuery(int blogId)
	{
		BlogId = blogId;
	}
}
