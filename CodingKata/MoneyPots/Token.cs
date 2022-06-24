using System.Text.Json.Serialization;

namespace CodingKata.MoneyPots;

public record Token(
    [property: JsonPropertyName("access_token")] string AccessToken,
    [property: JsonPropertyName("token_type")] string TokenType,
    [property: JsonPropertyName("expires_in")] int ExpiresIn);