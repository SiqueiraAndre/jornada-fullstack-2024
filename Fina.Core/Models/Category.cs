namespace Fina.Core.Models;

public class Category
{
  public long Id { get; set; }
  public string PageTitle { get; set; } = string.Empty;
  public string? Description { get; set; }
  public string UserId { get; set; } = string.Empty;
}