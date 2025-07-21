using Gay.Silverbranch.Api.Models.Enum.V1;

namespace Gay.Silverbranch.Api.Models.Entities.V1;

public class PhoneNumberModel : BaseModel
{
    // ProjectScaffolder.Models Specific Notes Here
    //--------------------------------------------------------------------------
    //


    // [ModelDocumentation("",
    //     Description = "Phone number country code",
    //     DBType = "Many;One",
    //     Required = true)]
    public required CountryCodeModel CountryCode { get; init; }

    // [ModelDocumentation("",
    //     Description = "Phone number area code",
    //     Format = "###",
    //     Encoding = "ascii",
    //     DBType = "varchar",
    //     FieldLength = 3,
    //     Required = true)]
    public required string AreaCode { get; init; }

    // [ModelDocumentation("",
    //     Description = "Phone number prefix",
    //     Format = "###",
    //     Encoding = "ascii",
    //     DBType = "varchar",
    //     FieldLength = 3,
    //     Required = true)]
    public required string TelephonePrefix { get; init; }

    // [ModelDocumentation("",
    //     Description = "Phone number line number",
    //     Format = "####",
    //     Encoding = "ascii",
    //     DBType = "varchar",
    //     FieldLength = 3,
    //     Required = true)]
    public required string LineNumber { get; init; }
    
    // [JsonConverter(typeof(FlexibleEnumConverter<ePhoneType>))]
    // [ModelDocumentation("",
    //     Description = "Phone number country code",
    //     DBType = "smallint",
    //     DefaultValue = "ePhoneType.Mobile")]
    public ePhoneType PhoneType { get; init; }

    #region Contructors

    public PhoneNumberModel() { }

    public PhoneNumberModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id, 
            name: name, 
            createdBy: createdBy, 
            createdOn: DateTime.UtcNow, 
            notes: notes) { }

    public PhoneNumberModel(
        PhoneNumberModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        CountryCode = model.CountryCode;
        AreaCode = model.AreaCode;
        TelephonePrefix = model.TelephonePrefix;
        LineNumber = model.LineNumber;
        PhoneType = model.PhoneType;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public PhoneNumberModel(
        PhoneNumberModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        CountryCode = model.CountryCode;
        AreaCode = model.AreaCode;
        TelephonePrefix = model.TelephonePrefix;
        LineNumber = model.LineNumber;
        PhoneType = model.PhoneType;
    }

    #endregion
}