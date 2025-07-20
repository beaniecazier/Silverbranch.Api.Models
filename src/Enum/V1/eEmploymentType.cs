using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum eEmploymentType
{
    [Display(Name = "ERROR")]
    ERROR = -1,

    [Display(Name = "Full Time")]
    FullTime = 0,

    [Display(Name = "Part Time")]
    PartTime = 1,

    [Display(Name = "Contract")]
    Contract = 2,

    [Display(Name = "Internship")]
    Internship = 3,
}