using System.ComponentModel.DataAnnotations;

namespace DotNet8.Architecture_CleanArchitecture.DbService.Models;

public partial class TblBlog
{
	[Key]
	public long BlogId { get; set; }

	public string BlogTitle { get; set; } = null!;

	public string BlogAuthor { get; set; } = null!;

	public string BlogContent { get; set; } = null!;

	public bool DeleteFlag { get; set; }
}
