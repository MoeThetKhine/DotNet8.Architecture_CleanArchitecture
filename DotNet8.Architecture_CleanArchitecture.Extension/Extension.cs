namespace DotNet8.Architecture_CleanArchitecture.Extension;

public static class Extension
{
	public static BlogModel ToModel(this Tbl_Blog dataModel)
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
