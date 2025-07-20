using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum ePhoneType
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    
    [Display(Name = "Home Phone")]
    Home = 0,
    
    [Display(Name = "Mobile Phone")]
    Mobile = 1,
    
    [Display(Name = "Work Phone")]
    Work = 2,
    
    [Display(Name = "Fax Number")]
    Fax = 3,
    
    [Display(Name = "Other")]
    Other = 4,
}