using DotNet8.Architecture_CleanArchitecture.DTOs.PageSetting;

namespace DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;

public class BlogListModel
{
	public IEnumerable<BlogModel> DataLst { get; set; }
	public PageSettingModel PageSetting { get; set; }
}
