using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eCardinalDirection
{
    [Display(Name ="ERROR")] ERROR = -1,
    [Display(Name ="North")] N = 0,
    [Display(Name ="East")] E = 1,
    [Display(Name ="South")] S = 2,
    [Display(Name ="West")] W = 3,    
    [Display(Name ="Northeast")] NE = 4,
    [Display(Name ="Southeast")] SE = 5,
    [Display(Name ="Southwest")] SW = 6,
    [Display(Name ="Northwest")] NW = 7,    
    [Display(Name ="North-Northeast")] NNE = 8,
    [Display(Name ="East-Northeast")] ENE = 9,
    [Display(Name ="East-Southeast")] ESE = 10,
    [Display(Name ="South-Southeast")] SSE = 11,
    [Display(Name ="South-Southwest")] SSW = 12,
    [Display(Name ="West-Southwest")] WSW = 13,
    [Display(Name ="West-Northwest")] WNW = 14,
    [Display(Name ="North-Northwest")] NNW = 15,
}