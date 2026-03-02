using DotNet8.Architecture_CleanArchitecture.Utils.Enums;

namespace DotNet8.Architecture_CleanArchitecture.Utils;

public class Result<T>
{ 
	public T Data { get; set; }
	public string Message {  get; set; }	
	public bool IsSuccess {  get; set; }
	public EnumStatusCode StatusCode { get; set; }
}
