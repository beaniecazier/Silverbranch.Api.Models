using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eCollectionType
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    [Display(Name = "Not A Collecion")]
    None = 0,
    [Display(Name = "IEnumerable")]
    IEnumerable = 1,
    [Display(Name = "List")]
    List = 2,
    [Display(Name = "Array")]
    Array = 3,
    [Display(Name = "Dictionary")]
    Dictionary = 4,
    [Display(Name = "Queryable")]
    Queryable = -1,
}