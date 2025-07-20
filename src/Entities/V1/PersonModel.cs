using Gay.Silverbranch.API.Models.Enum;
using Gay.Silverbranch.API.Models.Enum.V1;

namespace Gay.Silverbranch.API.Models.Entities.V1;

public class PersonModel : ContactModel
{
    // ProjectScaffolder.Models Specific Notes Here
    //--------------------------------------------------------------------------
    //

    // [ModelDocumentation("",
    //     Description = "The person's prefered name",
    //     Format = ".*",
    //     Encoding = "UTF-16",
    //     DBType = "nvarchar",
    //     FieldLength = 512)]
    public string? PreferedName { get; set; }

    //[PropertyDocumentation("",
    //    Description = "Undescribed property of this model")]
    public List<ePronoun> Pronouns { get; set; } = new List<ePronoun>();
    
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

    #region Contructors

    public PersonModel() { }

    public PersonModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id, 
            name: name, 
            createdBy: createdBy, 
            notes: notes) { }

    public PersonModel(
        PersonModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        PreferedName = model.PreferedName;
        Pronouns = model.Pronouns;
        Emails = model.Emails;
        Socials = model.Socials;
        Addresses = model.Addresses;
        PhoneNumbers = model.PhoneNumbers;
        Website = model.Website;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public PersonModel(
        PersonModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        PreferedName = model.PreferedName;
        Pronouns = model.Pronouns;
        Emails = model.Emails;
        Socials = model.Socials;
        Addresses = model.Addresses;
        PhoneNumbers = model.PhoneNumbers;
        Website = model.Website;
    }

    #endregion
}