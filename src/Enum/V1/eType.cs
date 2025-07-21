using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

/// <summary>
/// The way in which data will be encoded,
///
/// for use in the Scaffolder tool to determine code
/// needed to parse and unpack data
/// </summary>
public enum eType
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "Object")]
    Object = 0,
    [Display(Name = "Boolean")]
    Boolean = 1,
    [Display(Name = "Byte")]
    Byte = 2,
    [Display(Name = "SByte")]
    SByte = 3,
    [Display(Name = "Short")]
    Short = 4,
    [Display(Name = "UShort")]
    UShort = 5,
    [Display(Name = "Int")]
    Int = 6,
    [Display(Name = "UInt")]
    UInt = 7,
    [Display(Name = "Long")]
    Long = 8,
    [Display(Name = "ULong")]
    ULong = 9,
    [Display(Name = "Float")]
    Float = 10,
    [Display(Name = "Double")]
    Double = 11,
    [Display(Name = "Decimal")]
    Decimal = 12,
    [Display(Name = "DateTime")]
    DateTime = 13,
    [Display(Name = "DateTime object with TimeZone offset")]
    DateTimeOffset = 14,
    [Display(Name = "String")]
    String = 15,
    [Display(Name = "Guid")]
    Guid = 16,
    [Display(Name = "Enum")]
    Enum = 17,
    [Display(Name = "Struct")]
    Struct = 18,
    [Display(Name = "NInt")]
    NInt = 19,
    [Display(Name = "NUInt")]
    NUInt = 20,
    [Display(Name = "Model")]
    Model = 21,
    [Display(Name = "Class")]
    Char = 22,
    [Display(Name = "Some Non-model Class")]
    Class = 23,
    [Display(Name = "Version")]
    Version = 24,
}