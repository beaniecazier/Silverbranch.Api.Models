using Gay.Silverbranch.Api.Models.Enum.V1;

namespace Gay.Silverbranch.Api.Models.Enum.Extensions.V1;

public static class ePropertyModifierExtensions
{
    public static bool IsSpecialConstraint(this ePropertyModifier value)
        => value switch
        {
            ePropertyModifier.None => true,
            ePropertyModifier.Deprecated => true,
            ePropertyModifier.Nullable => true,
            ePropertyModifier.ERROR => throw new Exception("ERROR Constraint found"),
            _ => false
        };
}