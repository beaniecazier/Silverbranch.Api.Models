using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eStyle
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "None")]
    None = 0,
    [Display(Name = "Rest")]
    Rest = 1,
    [Display(Name = "Grpc")]
    Grpc = 2,
    [Display(Name = "GraphQl")]
    GraphQl = 3,
}