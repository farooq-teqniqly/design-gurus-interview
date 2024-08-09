using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Lib;
public static class FileHashing
{
    private static readonly JsonSerializerOptions jsonSerializerOptions = JsonSerializerOptions.Default;

    public static string Hash(string content)
    {
        var normalizedJson = NormalizeJson(content);
        return HashJson(normalizedJson);
    }

    private static string HashJson(string json)
    {
        using (var sha256 = SHA256.Create())
        {
            var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(json));
            return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
        }
    }

    private static string NormalizeJson(string content)
    {
        using (var document = JsonDocument.Parse(content))
        {
            return JsonSerializer.Serialize(document.RootElement, jsonSerializerOptions);
        }
    }
}
