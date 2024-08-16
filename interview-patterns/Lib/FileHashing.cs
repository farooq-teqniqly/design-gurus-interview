using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Lib;

public static class FileHashing
{
    private static readonly JsonSerializerOptions _jsonSerializerOptions = JsonSerializerOptions.Default;

    public static string Hash(string content)
    {
        var normalizedJson = NormalizeJson(content);
        return HashJson(normalizedJson);
    }

    private static string HashJson(string json)
    {
        var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(json));
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
    }

    private static string NormalizeJson(string content)
    {
        using (var document = JsonDocument.Parse(content))
        {
            return JsonSerializer.Serialize(document.RootElement, _jsonSerializerOptions);
        }
    }
}
