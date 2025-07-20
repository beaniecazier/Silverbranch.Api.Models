using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum eClassModifier
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "None")]
    None = 0,
    [Display(Name = "Abstract")]
    Abstract = 1,
    [Display(Name = "New")]
    New = 2,
    [Display(Name = "Partial")]
    Partial = 3,
    [Display(Name = "ReadOnly")]
    ReadOnly = 4,
    [Display(Name = "Sealed")]
    Sealed = 5,
    [Display(Name = "Static")]
    Static = 6,
}