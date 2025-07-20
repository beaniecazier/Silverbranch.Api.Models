namespace Gay.Silverbranch.API.Models.Entities.V1;

public class ContactModel: BaseModel
{
    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     Format = "email",
    //     Encoding = "UTF-16",
    //     DBType = "ntext")]
    public List<string> Emails { get; set; } = new List<string>();

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     Format = "link",
    //     Encoding = "UTF-16",
    //     DBType = "ntext")]
    public List<string> Socials { get; set; } = new List<string>();

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "One;Many")]
    public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    
    #region Contructors

    public ContactModel() { }

    public ContactModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id, 
            name: name, 
            createdBy: createdBy, 
            createdOn: DateTime.UtcNow, 
            notes: notes) { }

    public ContactModel(
        ContactModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Emails = model.Emails;
        Socials = model.Socials;
        PhoneNumbers = model.PhoneNumbers;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public ContactModel(
        ContactModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Emails = model.Emails;
        Socials = model.Socials;
        PhoneNumbers = model.PhoneNumbers;
    }

    #endregion
}