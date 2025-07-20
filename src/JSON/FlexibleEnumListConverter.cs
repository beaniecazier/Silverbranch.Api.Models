using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gay.Silverbranch.API.Models.JSON;

public class FlexibleEnumListConverter<T> : JsonConverter<List<T>> where T : struct, System.Enum
{
    public override List<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var list = new List<T>();

        if (reader.TokenType == JsonTokenType.StartArray)
        {
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                    break;

                if (reader.TokenType == JsonTokenType.String)
                {
                    if (System.Enum.TryParse(reader.GetString(), true, out T result))
                        list.Add(result);
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    if (System.Enum.IsDefined(typeof(T), reader.GetInt32()))
                        list.Add((T)System.Enum.ToObject(typeof(T), reader.GetInt32()));
                }
                else
                {
                    throw new JsonException($"Invalid value in enum list: {reader.GetString()}");
                }
            }
        }
        else
        {
            throw new JsonException("Expected JSON array for enum list.");
        }

        return list;
    }

    public override void Write(Utf8JsonWriter writer, List<T> value, JsonSerializerOptions options)
    {
        writer.WriteStartArray();
        foreach (var item in value)
        {
            writer.WriteStringValue(item.ToString()); // Change to WriteNumberValue(Convert.ToInt32(item)) if you prefer numbers
        }
        writer.WriteEndArray();
    }
}