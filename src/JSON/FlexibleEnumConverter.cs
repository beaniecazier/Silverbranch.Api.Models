using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gay.Silverbranch.Api.Models.JSON;

public class FlexibleEnumConverter<T> : JsonConverter<T> where T : struct, System.Enum
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            if (System.Enum.TryParse(reader.GetString(), true, out T result))
                return result;
        }
        else if (reader.TokenType == JsonTokenType.Number)
        {
            if (System.Enum.IsDefined(typeof(T), reader.GetInt32()))
                return (T)System.Enum.ToObject(typeof(T), reader.GetInt32());
        }

        throw new JsonException($"Unable to convert {reader.GetString()} to {typeof(T).Name}.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}