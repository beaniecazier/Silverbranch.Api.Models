using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum eMethodModifier
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "None")]
    None = 0,
    [Display(Name = "Abstract")]
    Abstract = 1,
    [Display(Name = "Asynchronous")]
    Async = 2,
    [Display(Name = "Constructor")]
    Constructor = 3,
    [Display(Name = "Event")]
    Event = 4,
    [Display(Name = "External Method")]
    Extern = 5,
    [Display(Name = "Indexer")]
    Indexer = 6,
    [Display(Name = "New")]
    New = 7,
    [Display(Name = "Operator")]
    Operator = 8,
    [Display(Name = "Overrides")]
    Override = 9,
    [Display(Name = "Partial")]
    Partial = 10,
    [Display(Name = "ReadOnly")]
    ReadOnly = 11,
    [Display(Name = "Sealed")]
    Sealed = 12,
    [Display(Name = "Static")]
    Static = 13,
    [Display(Name = "Unsafe")]
    Unsafe = 14,
    [Display(Name = "Virtual")]
    Virtual = 15,
}