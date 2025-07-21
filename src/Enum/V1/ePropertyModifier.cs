using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

/// <summary>
/// The way in which data will be encoded,
///
/// for use in the Scaffolder tool to determine code
/// needed to parse and unpack data
/// </summary>
public enum ePropertyModifier
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "None")]
    None = 0,
    [Display(Name = "Abstract")]
    Abstract = 1,
    [Display(Name = "Constant Field")]
    Const = 2,
    [Display(Name = "Deprecated")]
    Deprecated = 3,
    [Display(Name = "Event")]
    Event = 4,
    [Display(Name = "New")]
    New = 5,
    [Display(Name = "Nullable")]
    Nullable = 6,
    [Display(Name = "Partial")]
    Partial = 7,
    [Display(Name = "ReadOnly")]
    ReadOnly = 8,
    [Display(Name = "Required")]
    Required = 9,
    [Display(Name = "Sealed")]
    Sealed = 10,
    [Display(Name = "Static")]
    Static = 11,
    [Display(Name = "Unsafe")]
    Unsafe = 12,
    [Display(Name = "Virtual")]
    Virtual = 13,
    [Display(Name = "Volatile")]
    Volatile = 14,
}