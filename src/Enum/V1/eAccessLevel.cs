using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

/// <summary>
/// The way in which data will be encoded,
///
/// for use in the Scaffolder tool to determine code
/// needed to parse and unpack data
/// </summary>
public enum eAccessLevel
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "Private")]
    Private = 0,
    [Display(Name = "Public")]
    Public = 1,
    [Display(Name = "Protected")]
    Protected = 2,
    [Display(Name = "Internal")]
    Internal = 3,
    [Display(Name = "Protected Internal")]
    ProtectedInternal = 4,
    [Display(Name = "Private Protected")]
    PrivateProtected = 5,
    [Display(Name = "File")]
    File = 6,
}