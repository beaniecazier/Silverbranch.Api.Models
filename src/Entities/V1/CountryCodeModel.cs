namespace Gay.Silverbranch.Api.Models.Entities.V1;

public class CountryCodeModel : BaseModel
{
    // [ModelDocumentation("",
    //     Description = "Country Name",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*",
    //     Required = true)]
    public required string Country { get; init; }
    
    // [ModelDocumentation("",
    //     Description = "The calling code",
    //     DBType = "nvarchar",
    //     FieldLength = 8,
    //     Format = ".*",
    //     Required = true)]
    public required string CallingCode { get; init; }
    
    // [ModelDocumentation("",
    //     Description = "3-Letter ISO",
    //     DBType = "nvarchar",
    //     FieldLength = 3,
    //     Format = ".*",
    //     Required = true)]
    public required string Iso3Letter { get; init; }
    
    // [ModelDocumentation("",
    //     Description = "2-Letter ISO",
    //     DBType = "nvarchar",
    //     FieldLength = 2,
    //     Format = ".*",
    //     Required = true)]
    public required string Iso2Letter { get; init; }
    
    // [ModelDocumentation("",
    //     Description = "3-Digit ISO Numeric",
    //     DBType = "smallint",
    //     Format = "###",
    //     Required = true)]
    public uint IsoNumeric { get; set; }

    #region Contructors

    public CountryCodeModel() { }

    public CountryCodeModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id, 
            name: name, 
            createdBy: createdBy, 
            createdOn: DateTime.UtcNow, 
            notes: notes) { }

    public CountryCodeModel(
        CountryCodeModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Country = model.Country;
        CallingCode = model.CallingCode;
        Iso3Letter = model.Iso3Letter;
        Iso2Letter = model.Iso2Letter;
        IsoNumeric = model.IsoNumeric;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public CountryCodeModel(
        CountryCodeModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    {
        Country = model.Country;
        CallingCode = model.CallingCode;
        Iso3Letter = model.Iso3Letter;
        Iso2Letter = model.Iso2Letter;
        IsoNumeric = model.IsoNumeric;
    }

    #endregion
}