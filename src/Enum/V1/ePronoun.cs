using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum ePronoun
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    
    [Display(Name = "None")]
    None = 0,

    [Display(Name = "She/Her")]
    SheHer = 1,

    [Display(Name = "Fae/Faer")]
    FaeFaer = 2,

    [Display(Name = "They/Them")]
    TheyThem = 3,

    [Display(Name = "He/Him")]
    HeHim = 4,

    [Display(Name = "It/Its")]
    ItIts = 5,
}