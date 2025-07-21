using Gay.Silverbranch.Api.Models.Enum.V1;
using LanguageExt;

namespace Gay.Silverbranch.Api.Models.Interfaces.V1;

public interface ISerializable
{
    Fin<string> Serialize(eSerializationType type);
}

//public static class Converter
//{
//    public static extern Result<ISerializable> Deserialize(this ISerializable model, string modelString);
//}
