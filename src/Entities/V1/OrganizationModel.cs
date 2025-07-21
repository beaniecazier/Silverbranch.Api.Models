using Gay.Silverbranch.Api.Models.Enum.V1;

namespace Gay.Silverbranch.Api.Models.Entities.V1;

public class OrganizationModel : ContactModel
{
    // [ModelDocumentation("Must be a valid, non-error industry value",
    //     DBType = "smallint",
    //     Required = true,
    //     DefaultValue = "eIndustry.HumanitarianVolunteer")]
    public eIndustry Industry { get; set; } = eIndustry.ERROR;
    
    // [ModelDocumentation("Must be a valid, non-error organization status value",
    //     DBType = "smallint",
    //     Required = true,
    //     DefaultValue = "eOrganizationStatus.Active")]
    public eOrganizationStatus Status { get; set; } = eOrganizationStatus.ERROR;
    
    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "Many;Many")]
    public List<AddressModel> Addresses { get; set; } = new List<AddressModel>();
    
    // [ModelDocumentation("",
    //     Description = "Institution's primary website",
    //     Format = "link",
    //     Encoding = "UTF-16",
    //     DBType = "ntext",
    //     AlternateName = "Link")]
    public string? Website { get; set; }
    
    // [ModelDocumentation("",
    //     DBType = "One;One")]
    // public OrganizationModel ParentOrganization { get; set; }
    //
    // [ModelDocumentation("",
    //     DBType = "One;Many")]
    // public List<OrganizationModel> Subsidiaries { get; set; }
    
    // [ModelDocumentation("",
    //     Description = "The list of departments in the Organization",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     DBType = "ntext")]
    public List<string> Departments { get; set; } = new List<string>();
    
    #region Contructors

    public OrganizationModel() { }

    public OrganizationModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id, 
            name: name, 
            createdBy: createdBy, 
            notes: notes) { }

    public OrganizationModel(
        OrganizationModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Industry = model.Industry;
        Status = model.Status;
        Addresses = model.Addresses;
        Website = model.Website;
        // ParentOrganization = model.ParentOrganization;
        Departments = model.Departments;
        // Subsidiaries = model.Subsidiaries;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public OrganizationModel(
        OrganizationModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Industry = model.Industry;
        Status = model.Status;
        Addresses = model.Addresses;
        Website = model.Website;
        // ParentOrganization = model.ParentOrganization;
        Departments = model.Departments;
        // Subsidiaries = model.Subsidiaries;
    }

    #endregion
}