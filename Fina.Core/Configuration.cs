namespace Fina.Core;

public static class Configuration
{
    public const int DefaultStatusCode = 200;
    public const int DefaultPageNumber = 1;
    public const int DefaultPageSize = 25;

    public static string ConnectionString { get; set; } = string.Empty;
    public static string BackendUrl { get; set; } = "http://localhost:5105";
    public static string FrontendUrl { get; set; } = "http://localhost:5241";
}
