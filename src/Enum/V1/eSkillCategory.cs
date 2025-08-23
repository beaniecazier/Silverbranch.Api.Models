using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.Api.Models.Enum.V1;

public enum eSkillCategory
{
    [Display(Name = "ERROR")]
    ERROR = -1,
    
    [Display(Name = "None")]
    None = 0,

    [Display(Name = "Programming Skills")]
    ProgrammingSkills = 1,

    [Display(Name = "Web Development")]
    WebDevelopment = 2,

    [Display(Name = "Database Management")]
    DatabaseManagement = 3,

    [Display(Name = "Software Development")]
    SoftwareDevelopment = 4,

    [Display(Name = "Tools And Technologies")]
    ToolsAndTechnologies = 5,

    [Display(Name = "Soft Skills")]
    SoftSkills = 6,
}