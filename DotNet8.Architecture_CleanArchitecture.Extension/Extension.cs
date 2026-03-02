using DotNet8.Architecture_CleanArchitecture.Domain.Features.Blog;
using DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;

namespace DotNet8.Architecture_CleanArchitecture.Extension;

public static class Extension
{
	public static BlogModel ToModel(this TblBlog dataModel)
	{
		return new BlogModel
		{
			BlogId = dataModel.BlogId,
			BlogTitle = dataModel.BlogTitle,
			BlogAuthor = dataModel.BlogAuthor,
			BlogContent = dataModel.BlogContent,
			DeleteFlag = dataModel.DeleteFlag
		};
	}

	public static Tbl_Blog ToEntity(this BlogRequestModel model)
	{
		return new Tbl_Blog
		{
			BlogTitle = model.BlogTitle,
			BlogAuthor = model.BlogAuthor,
			BlogContent = model.BlogContent
		};
	}
}
