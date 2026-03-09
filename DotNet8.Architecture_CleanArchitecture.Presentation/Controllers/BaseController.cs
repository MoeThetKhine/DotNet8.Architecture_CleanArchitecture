using DotNet8.Architecture_CleanArchitecture.Shared;
using Microsoft.AspNetCore.Mvc;

namespace DotNet8.Architecture_CleanArchitecture.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseController : ControllerBase
{
	protected IActionResult Content(object obj)
	{
		return Content(obj.ToJson(), "application/json");
	}
}
