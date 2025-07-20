using Gay.Silverbranch.API.Models.Enum.V1;

namespace Gay.Silverbranch.API.Models.Enum.Extensions.V1;

public static class eCollectionTypeExtensions
{
    public static bool IsCollection(this eCollectionType item) =>
        item != eCollectionType.None && item != eCollectionType.ERROR;
}