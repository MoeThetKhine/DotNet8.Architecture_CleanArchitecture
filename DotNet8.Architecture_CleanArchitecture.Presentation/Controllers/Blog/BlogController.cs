using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Architecture_CleanArchitecture.Presentation.Controllers.Blog;

[Route("api/[controller]")]
[ApiController]
public class BlogController : BaseController
{
	private readonly IMediator _mediator;

	public BlogController(IMediator mediator)
	{
		_mediator = mediator;
	}
}
