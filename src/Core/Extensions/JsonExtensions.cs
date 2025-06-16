using System.Text.Json;

public static class JsonExtensions
{
  static readonly JsonSerializerOptions options = new()
  {
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
  };

  public static T FromJson<T>(this string json) => JsonSerializer.Deserialize<T>(json);
  public static string ToJson<T>(this T serializable) => JsonSerializer.Serialize<T>(serializable, options);
}