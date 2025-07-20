using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum eOrganizationStatus
{
    
    [Display(Name = "ERROR")]
    ERROR = -1,
    
    [Display(Name = "Active")]
    Active = 0,
    
    [Display(Name = "Inactive")]
    Inactive = 1, 
    
    [Display(Name = "Closed")]
    Closed = 2,
}