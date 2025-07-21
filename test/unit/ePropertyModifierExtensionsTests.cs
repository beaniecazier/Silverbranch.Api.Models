using FluentAssertions;

using Gay.Silverbranch.Api.Models.Enum.Extensions.V1;
using Gay.Silverbranch.Api.Models.Enum.V1;

namespace Models.Tests.Unit;

public class ePropertyModifierExtensionsTests
{
    [Theory]
    //[InlineData(ePropertyModifier.ERROR, true)]
    [InlineData(ePropertyModifier.None, true)]
    [InlineData(ePropertyModifier.Abstract, false)]
    [InlineData(ePropertyModifier.Const, false)]
    [InlineData(ePropertyModifier.Deprecated, true)]
    [InlineData(ePropertyModifier.Event, false)]
    [InlineData(ePropertyModifier.New, false)]
    [InlineData(ePropertyModifier.Nullable, true)]
    [InlineData(ePropertyModifier.Partial, false)]
    [InlineData(ePropertyModifier.ReadOnly, false)]
    [InlineData(ePropertyModifier.Required, false)]
    [InlineData(ePropertyModifier.Sealed, false)]
    [InlineData(ePropertyModifier.Static, false)]
    [InlineData(ePropertyModifier.Unsafe, false)]
    [InlineData(ePropertyModifier.Virtual, false)]
    [InlineData(ePropertyModifier.Volatile, false)]
    private void IsSpecialConstraint_ShouldBeTrue_WhenIsSpecialConstraint(
        ePropertyModifier modifier,
        bool expected)
    {
        // Act
        var result = modifier.IsSpecialConstraint();

        // Assert
        result.Should().Be(expected);
    }
}