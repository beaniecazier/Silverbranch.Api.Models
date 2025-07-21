using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum ePronoun
{
    [Display(Name = "ERROR")]
    ERROR = -1,

    [Display(Name = "She/Her")]
    SheHer = 0,

    [Display(Name = "Fae/Faer")]
    FaeFaer = 1,

    [Display(Name = "They/Them")]
    TheyThem = 2,

    [Display(Name = "He/Him")]
    HeHim = 3,

    [Display(Name = "It/Its")]
    ItIts = 4,
}