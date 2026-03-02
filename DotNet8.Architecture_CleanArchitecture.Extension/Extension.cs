using DotNet8.Architecture_CleanArchitecture.DbService.Models;
using DotNet8.Architecture_CleanArchitecture.DTOs.Features.Blog;

namespace DotNet8.Architecture_CleanArchitecture.Extension;

public static class Extension
{

	#region  BlogModel ToModel

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

	#endregion

	public static TblBlog ToEntity(this BlogRequestModel model)
	{
		return new TblBlog
		{
			BlogTitle = model.BlogTitle,
			BlogAuthor = model.BlogAuthor,
			BlogContent = model.BlogContent
		};
	}

}
