using System.ComponentModel.DataAnnotations;

namespace Gay.Silverbranch.API.Models.Enum.V1;

public enum eSkillCategory
{
    [Display(Name = "ERROR")]
    ERROR = -1,

    [Display(Name = "Programming Skills")]
    ProgrammingSkills = 0,

    [Display(Name = "Web Development")]
    WebDevelopment = 1,

    [Display(Name = "Database Management")]
    DatabaseManagement = 2,

    [Display(Name = "Software Development")]
    SoftwareDevelopment = 3,

    [Display(Name = "Tools And Technologies")]
    ToolsAndTechnologies = 4,

    [Display(Name = "Soft Skills")]
    SoftSkills = 5,
}