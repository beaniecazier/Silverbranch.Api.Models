using Gay.Silverbranch.Api.Models.Enum.V1;

namespace Gay.Silverbranch.Api.Models.Entities.V1;

public class AddressModel : BaseModel
{
    // ProjectScaffolder.Models Specific Notes Here
    //--------------------------------------------------------------------------
    //https://desktop.arcgis.com/en/arcmap/latest/manage-data/geocoding/what-is-an-address.htm#:~:text=A%20common%20address%20format%20used,are%20presented%20in%20different%20formats.


    // [ModelDocumentation("",
    //     Description = "Building number",
    //     DBType = "smallint",
    //     FieldLength = 128,
    //     Format = "uint",
    //     Required = true)]
    public int HouseNumber { get; init; }

    // [ModelDocumentation("",
    //     Description = "Street name",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*",
    //     Required = true)]
    public required string StreetName { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "smallint",
    //     Format = "Valid address street type",
    //     DefaultValue = "eStreetType.Lane",
    //     Required = true)]
    public eStreetType StreetType { get; init; }

    // [ModelDocumentation("",
    //     Description = "Name of a the city the address is located in",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*",
    //     Required = true)]
    public required string City { get; init; }

    // [ModelDocumentation("",
    //     Description = "Name of a the region/county the address is located in",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*")]
    public string? Region { get; init; }

    // [ModelDocumentation("",
    //     Description = "Name of a the state the address is located in",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*",
    //     Required = true)]
    public required string State { get; init; }

    // [ModelDocumentation("",
    //     Description = "Name of a the country the address is located in",
    //     DBType = "nvarchar",
    //     FieldLength = 256,
    //     Format = ".*",
    //     Required = true)]
    public required string Country { get; init; }

    // [ModelDocumentation("",
    //     Description = "Postal code for address",
    //     DBType = "int",
    //     Format = "uint;#####",
    //     Required = true)]
    public int PostalCode { get; init; }

    // [ModelDocumentation("",
    //     Description = "USA Zip4 postal code addition",
    //     DBType = "int",
    //     Format = "uint;####")]
    public int? Zip4 { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "nvarchar",
    //     FieldLength = 512,
    //     Format = ".*")]
    public string? CrossStreetName { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "nvarchar",
    //     FieldLength = 8,
    //     Format = "Valid cardinal direction")]
    public string? PrefixDirection { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "smallint",
    //     Format = "Valid address street type",
    //     DefaultValue = "eStreetType.Lane")]
    public eStreetType? PrefixType { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "nvarchar",
    //     FieldLength = 8,
    //     Format = "Valid cardinal direction")]
    public string? SuffixDirection { get; init; }

    // [ModelDocumentation("",
    //     Description = "Undescribed property of this model",
    //     DBType = "smallint",
    //     Format = "Valid address street type",
    //     DefaultValue = "eStreetType.Lane")]
    public eStreetType? SuffixType { get; init; }

    #region Contructors

    public AddressModel() { }

    public AddressModel(
        string id, string name, string createdBy, string notes) : 
        base(id: id,
            name: name,
            createdBy: createdBy,
            createdOn: DateTime.UtcNow,
            notes: notes) { }

    public AddressModel(
        AddressModel model, string user,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            isHidden: isHidden,
            isDeleted: isDeleted)
    { 
        HouseNumber = model.HouseNumber;
        StreetName = model.StreetName;
        StreetType = model.StreetType;
        City = model.City;
        Region = model.Region;
        State = model.State;
        Country = model.Country;
        PostalCode = model.PostalCode;
        Zip4 = model.Zip4;
        CrossStreetName = model.CrossStreetName;
        PrefixDirection = model.PrefixDirection;
        PrefixType = model.PrefixType;
        SuffixDirection = model.SuffixDirection;
        SuffixType = model.SuffixType;
    }

    /// <summary>
    /// DO NOT USE NORMALLY, THIS CONSTRUCTOR BREAKS EFCORE AND SQL DATABASES
    /// </summary>
    public AddressModel(
        AddressModel model, string user, int entryId,
        bool? isHidden = null, bool? isDeleted = null) :
        base(model:model,
            user: user,
            entryId: entryId,
            isHidden: isHidden,
            isDeleted: isDeleted)
    { 
        HouseNumber = model.HouseNumber;
        StreetName = model.StreetName;
        StreetType = model.StreetType;
        City = model.City;
        Region = model.Region;
        State = model.State;
        Country = model.Country;
        PostalCode = model.PostalCode;
        Zip4 = model.Zip4;
        CrossStreetName = model.CrossStreetName;
        PrefixDirection = model.PrefixDirection;
        PrefixType = model.PrefixType;
        SuffixDirection = model.SuffixDirection;
        SuffixType = model.SuffixType;
    }

    #endregion
}